using Microsoft.Data.SqlClient;

namespace QuanLyNguoiDung.DuLieu;

/// <summary>
/// Mọi câu lệnh SQL của ứng dụng nằm trong lớp này.
/// Không tham chiếu tới Form hay MessageBox. Luôn dùng tham số, không nối chuỗi.
/// </summary>
public class NguoiDungRepository
{
    private readonly string _chuoiKetNoi = CauHinh.ChuoiKetNoi;

    /// <summary>Đếm số tài khoản trong bảng Users. Dùng để kiểm tra kết nối.</summary>
    public async Task<int> DemSoNguoiDungAsync()
    {
        const string sql = "SELECT COUNT(*) FROM Users";

        await using var conn = new SqlConnection(_chuoiKetNoi);
        await using var cmd = new SqlCommand(sql, conn);
        await conn.OpenAsync();
        return (int)(await cmd.ExecuteScalarAsync())!;
    }

    /// <summary>
    /// Kiểm tra tên đăng nhập đã tồn tại chưa.
    /// Trả về true nếu đã tồn tại, false nếu chưa tồn tại.
    /// </summary>
    public async Task<bool> KiemTraTenDangNhapTonTaiAsync(
        string tenDangNhap)
    {
        const string sql = """
            SELECT CASE
                WHEN EXISTS (
                    SELECT 1
                    FROM dbo.Users
                    WHERE TenDangNhap = @tenDangNhap
                )
                THEN 1
                ELSE 0
            END;
            """;

        await using var conn = new SqlConnection(_chuoiKetNoi);
        await using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.Add(
            "@tenDangNhap", SqlDbType.NVarChar, 20
        ).Value = tenDangNhap;

        await conn.OpenAsync();

        object? ketQua = await cmd.ExecuteScalarAsync();

        return Convert.ToInt32(ketQua) == 1;
    }

    /// <summary>
    /// Thêm tài khoản mới vào database.
    /// Trả về true nếu thêm thành công,
    /// false nếu tên đăng nhập đã tồn tại.
    /// MatKhauBam phải là chuỗi băm, không phải mật khẩu gốc.
    /// </summary>
    public async Task<bool> DangKyNguoiDungAsync(
        string tenDangNhap,
        string matKhauBam,
        string salt,
        string hoTen,
        string? email)
    {
        // Kiểm tra trùng trước khi thêm.
        if (await KiemTraTenDangNhapTonTaiAsync(tenDangNhap))
        {
            return false;
        }

        const string sql = """
            INSERT INTO dbo.Users
            (
                TenDangNhap,
                MatKhauBam,
                Salt,
                HoTen,
                Email
            )
            VALUES
            (
                @tenDangNhap,
                @matKhauBam,
                @salt,
                @hoTen,
                @email
            );
            """;

        try
        {
            await using var conn = new SqlConnection(_chuoiKetNoi);
            await using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add(
                "@tenDangNhap", SqlDbType.NVarChar, 20
            ).Value = tenDangNhap;

            cmd.Parameters.Add(
                "@matKhauBam", SqlDbType.NVarChar, 64
            ).Value = matKhauBam;

            cmd.Parameters.Add(
                "@salt", SqlDbType.NVarChar, 32
            ).Value = salt;

            cmd.Parameters.Add(
                "@hoTen", SqlDbType.NVarChar, 50
            ).Value = hoTen;

            cmd.Parameters.Add(
                "@email", SqlDbType.NVarChar, 100
            ).Value = string.IsNullOrWhiteSpace(email)
                ? DBNull.Value
                : email;

            await conn.OpenAsync();

            int soDong = await cmd.ExecuteNonQueryAsync();

            return soDong == 1;
        }
        catch (SqlException ex)
            when (ex.Number == 2601 || ex.Number == 2627)
        {
            // Tên đăng nhập bị trùng ở database.
            // Có thể xảy ra nếu hai yêu cầu đăng ký
            // đến gần như đồng thời.
            return false;
        }
    }
}}