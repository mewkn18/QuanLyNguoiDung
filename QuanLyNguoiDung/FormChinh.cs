namespace QuanLyNguoiDung
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gọi sau khi đăng nhập thành công để hiển thị thông tin lấy từ cơ sở dữ liệu.
        /// </summary>
        public void HienThiThongTin(string hoTen, string tenDangNhap, string? email, DateTime? lanDangNhapCuoi)
        {
            lblXinChao.Text = $"Xin chào, {hoTen}";
            lblTenDangNhap.Text = $"Tên đăng nhập:  {tenDangNhap}";
            lblEmail.Text = $"Email:  {email ?? "(chưa cung cấp)"}";
            lblLanDangNhapCuoi.Text = "Lần đăng nhập gần nhất:  " +
                (lanDangNhapCuoi?.ToString("dd/MM/yyyy HH:mm") ?? "đây là lần đầu");
        }

        // Chọn "Đăng xuất": đóng form chính, form Đăng nhập tự hiện lại.
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
