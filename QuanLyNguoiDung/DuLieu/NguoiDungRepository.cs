using Microsoft.Data.SqlClient;
using System.Data;
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
    /// <summary>
    /// Tìm người dùng theo tên đăng nhập.
    /// Trả về null nếu không tìm thấy.
    /// </summary>
    public async Task<NguoiDung?> TimTheoTenAsync(string tenDangNhap)
    {
        const string sql = """
        SELECT UserId, TenDangNhap, MatKhauBam, Salt,
               HoTen, Email, NgayTao, LanDangNhapCuoi
        FROM dbo.Users
        WHERE TenDangNhap = @tenDangNhap;
        """;

        await using var conn = new SqlConnection(_chuoiKetNoi);
        await using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.Add(
            "@tenDangNhap", SqlDbType.NVarChar, 20
        ).Value = tenDangNhap;

        await conn.OpenAsync();

        await using var reader = await cmd.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
        {
            return null;
        }

        NguoiDung nguoiDung = new NguoiDung
        {
            UserId = reader.GetInt32(0),
            TenDangNhap = reader.GetString(1),
            MatKhauBam = reader.GetString(2),
            Salt = reader.GetString(3),
            HoTen = reader.GetString(4),
            Email = reader.IsDBNull(5)
                ? null
                : reader.GetString(5),
            NgayTao = reader.GetDateTime(6),
            LanDangNhapCuoi = reader.IsDBNull(7)
                ? null
                : reader.GetDateTime(7)
        };

        return nguoiDung;
    }

    /// <summary>
    /// Cập nhật thời điểm đăng nhập gần nhất của người dùng.
    /// </summary>
    public async Task CapNhatLanDangNhapAsync(int userId)
    {
        const string sql = """
        UPDATE dbo.Users
        SET LanDangNhapCuoi = SYSDATETIME()
        WHERE UserId = @id;
        """;

        await using var conn = new SqlConnection(_chuoiKetNoi);
        await using var cmd = new SqlCommand(sql, conn);

        cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;

        await conn.OpenAsync();
        await cmd.ExecuteNonQueryAsync();
    }
}