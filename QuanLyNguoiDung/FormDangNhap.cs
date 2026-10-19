namespace QuanLyNguoiDung
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        // Chọn liên kết "Đăng ký": ẩn form Đăng nhập, mở form Đăng ký, đóng lại thì hiện về.
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var formDangKy = new FormDangKy();
            Hide();
            formDangKy.ShowDialog();
            Show();
            txtTenDangNhap.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // TODO (tiêu chí 3 - chức năng đăng nhập): bạn phụ trách đăng nhập viết tiếp ở đây.
            // Đăng nhập thành công thì mở form chính:
            //   using var formChinh = new FormChinh();
            //   formChinh.HienThiThongTin(hoTen, tenDangNhap, email, lanDangNhapCuoi);
            //   Hide(); formChinh.ShowDialog(); Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
