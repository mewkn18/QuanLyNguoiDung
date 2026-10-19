using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNguoiDung.DuLieu
{
    class NguoiDung
    {
        public int UserId { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhauBam { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string? Email { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? LanDangNhapCuoi { get; set; }
    }
}
