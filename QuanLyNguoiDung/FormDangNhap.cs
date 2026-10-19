using Microsoft.Data.SqlClient;
using QuanLyNguoiDung.BaoMat;
using QuanLyNguoiDung.DuLieu;

namespace QuanLyNguoiDung
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var formDangKy = new FormDangKy();
            Hide();
            formDangKy.ShowDialog();
            Show();
            txtTenDangNhap.Focus();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblLoi.Text = string.Empty;
            string ten = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(matKhau))
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                if (string.IsNullOrEmpty(ten)) txtTenDangNhap.Focus();
                else txtMatKhau.Focus();
                return;
            }

            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";

            try
            {
                var repo = new NguoiDungRepository();
                var user = await repo.TimTheoTenAsync(ten);

                bool dungMatKhau = user != null &&
                    await Task.Run(() => MatKhau.KiemTra(matKhau, user.Salt, user.MatKhauBam));

                if (user == null || !dungMatKhau)
                {
                    lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                await repo.CapNhatLanDangNhapAsync(user.UserId);

                using var f = new FormChinh();
                f.HienThiThongTin(user.HoTen, user.TenDangNhap, user.Email, user.LanDangNhapCuoi);

                Hide();
                f.ShowDialog();
                Show();

                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
            catch (SqlException)
            {
                lblLoi.Text = "Không kết nối được tới máy chủ cơ sở dữ liệu. Vui lòng thử lại sau.";
            }
            catch (Exception)
            {
                lblLoi.Text = "Đã xảy ra lỗi không mong muốn. Vui lòng thử lại.";
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
