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

    // TODO: người phụ trách nhánh feature/repository viết tiếp các hàm còn lại
}