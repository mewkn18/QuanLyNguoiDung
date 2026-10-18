using System;
using System.IO;
using System.Text.Json;
using Microsoft.Data.SqlClient; 

namespace QuanLyNguoiDung;

/// <summary>Đọc chuỗi kết nối từ appsettings.json và tự động sửa lỗi nếu sai Server.</summary>
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

        // 1. Đọc chuỗi kết nối từ file json như bình thường
        using var doc = JsonDocument.Parse(File.ReadAllText(duongDan));
        string? chuoiTrongFile = doc.RootElement.GetProperty("ChuoiKetNoi").GetString();

        if (string.IsNullOrEmpty(chuoiTrongFile))
            throw new InvalidOperationException("appsettings.json chưa có ChuoiKetNoi.");

        // 2. Thử xem chuỗi trong file có kết nối được không
        if (ThuKetNoi(chuoiTrongFile))
        {
            return chuoiTrongFile; // Kết nối OK thì dùng luôn
        }

        // 3. Nếu chuỗi trong file bị lỗi (sai tên Server), tự động dò các Server phổ biến
        string[] dsServer = {
            "localhost",
            ".",
            @".\SQLEXPRESS",
            @"(localdb)\MSSQLLocalDB"
        };
        
        // LƯU Ý: Tên Database này phải khớp với tên bạn đã tạo trong SQL Server
        string dbName = "QuanLyNguoiDung"; 

        foreach (string server in dsServer)
        {
            string connStrThu = $"Server={server};Database={dbName};Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=2;";
            if (ThuKetNoi(connStrThu))
            {
                // Nếu tìm thấy server chạy được, tự động đổi sang dùng server đó
                return connStrThu; 
            }
        }

        // 4. Nếu thử hết mà không được (có thể do chưa cài SQL), trả về chuỗi gốc để báo lỗi
        return chuoiTrongFile; 
    }

    // Hàm phụ trợ: Thử mở kết nối xem có thành công không
    private static bool ThuKetNoi(string connStr)
    {
        try
        {
            using var conn = new SqlConnection(connStr);
            conn.Open(); // Thử mở
            return true; // Mở được -> Đúng server
        }
        catch
        {
            return false; // Lỗi -> Sai server hoặc chưa bật SQL Server
        }
    }
}
