namespace QuanLyNguoiDung
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // TODO (tiêu chí 2 - chức năng đăng ký): bạn phụ trách đăng ký viết tiếp ở đây.
            // Mỗi ô có nhãn lỗi riêng: lblLoiTenDangNhap, lblLoiHoTen, lblLoiMatKhau,
            // lblLoiXacNhanMatKhau, lblLoiEmail.
        }

        // Chọn "Huỷ" (hoặc nhấn Esc): đóng form, quay lại form Đăng nhập.
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
