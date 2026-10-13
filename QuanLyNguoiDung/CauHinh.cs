using System.Text.Json;

namespace QuanLyNguoiDung;

/// <summary>Đọc chuỗi kết nối từ appsettings.json (file riêng từng máy, không commit).</summary>
public static class CauHinh
{
    private static string? _chuoiKetNoi;

    public static string ChuoiKetNoi => _chuoiKetNoi ??= Doc();

    private static string Doc()
    {
        string duongDan = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

        if (!File.Exists(duongDan))
            throw new InvalidOperationException(
                "Thiếu file appsettings.json. Hãy sao chép appsettings.example.json thành appsettings.json.");

        using var doc = JsonDocument.Parse(File.ReadAllText(duongDan));
        return doc.RootElement.GetProperty("ChuoiKetNoi").GetString()
               ?? throw new InvalidOperationException("appsettings.json chưa có ChuoiKetNoi.");
    }
}