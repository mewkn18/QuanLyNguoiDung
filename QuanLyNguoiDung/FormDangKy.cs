using Microsoft.Data.SqlClient;
using QuanLyNguoiDung.BaoMat;
using QuanLyNguoiDung.DuLieu;
using System.Text.RegularExpressions;

namespace QuanLyNguoiDung
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void XoaLoi()
        {
            lblLoiTenDangNhap.Text = "";
            lblLoiHoTen.Text = "";
            lblLoiMatKhau.Text = "";
            lblLoiXacNhanMatKhau.Text = "";
            lblLoiEmail.Text = "";
        }

        private bool KiemTraDuLieu()
        {
            XoaLoi();

            bool hopLe = true;

            string ten = txtTenDangNhap.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string nhapLai = txtXacNhanMatKhau.Text;
            string email = txtEmail.Text.Trim();

            if (ten == "")
            {
                lblLoiTenDangNhap.Text =
                    "Vui lòng nhập tên đăng nhập.";
                hopLe = false;
            }
            else if (ten.Length < 3)
            {
                lblLoiTenDangNhap.Text =
                    "Tên đăng nhập tối thiểu 3 ký tự.";
                hopLe = false;
            }
            else if (ten.Length > 20)
            {
                lblLoiTenDangNhap.Text =
                    "Tên đăng nhập tối đa 20 ký tự.";
                hopLe = false;
            }

            if (hoTen == "")
            {
                lblLoiHoTen.Text = "Vui lòng nhập họ tên.";
                hopLe = false;
            }
            else if (hoTen.Length > 50)
            {
                lblLoiHoTen.Text = "Họ tên tối đa 50 ký tự.";
                hopLe = false;
            }

            if (matKhau == "")
            {
                lblLoiMatKhau.Text = "Vui lòng nhập mật khẩu.";
                hopLe = false;
            }
            else if (matKhau.Length < 8)
            {
                lblLoiMatKhau.Text = "Mật khẩu tối thiểu 8 ký tự.";
                hopLe = false;
            }

            if (nhapLai == "")
            {
                lblLoiXacNhanMatKhau.Text =
                    "Vui lòng nhập lại mật khẩu.";
                hopLe = false;
            }
            else if (matKhau != nhapLai)
            {
                lblLoiXacNhanMatKhau.Text =
                    "Hai mật khẩu không khớp.";
                hopLe = false;
            }

            if (email != "" &&
                (!Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ||
                 email.Length > 100))
            {
                lblLoiEmail.Text = "Email không hợp lệ.";
                hopLe = false;
            }

            // Đưa con trỏ về ô bị lỗi đầu tiên
            if (lblLoiTenDangNhap.Text != "") txtTenDangNhap.Focus();
            else if (lblLoiHoTen.Text != "") txtHoTen.Focus();
            else if (lblLoiMatKhau.Text != "") txtMatKhau.Focus();
            else if (lblLoiXacNhanMatKhau.Text != "") txtXacNhanMatKhau.Focus();
            else if (lblLoiEmail.Text != "") txtEmail.Focus();

            return hopLe;
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu trước khi truy cập database
            if (!KiemTraDuLieu())
                return;

            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                string ten = txtTenDangNhap.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text;

                NguoiDungRepository ndr = new NguoiDungRepository();

                // 2. Kiểm tra tên đăng nhập trùng
                bool daTonTai =
                    await ndr.KiemTraTenDangNhapTonTaiAsync(ten);

                if (daTonTai)
                {
                    lblLoiTenDangNhap.Text =
                        "Tên đăng nhập đã tồn tại.";
                    txtTenDangNhap.Focus();
                    return;
                }

                // 3. Băm mật khẩu và tạo Salt riêng
                var ketQua = await Task.Run(() => MatKhau.Tao(matKhau));

                // 4. Lưu thông tin vào SQL Server
                bool thanhCong =
                    await ndr.DangKyNguoiDungAsync(
                        ten,
                        ketQua.Bam,
                        ketQua.Salt,
                        hoTen,
                        string.IsNullOrWhiteSpace(email)
                            ? null
                            : email
                    );

                if (!thanhCong)
                {
                    lblLoiTenDangNhap.Text =
                        "Tên đăng nhập đã tồn tại.";
                    txtTenDangNhap.Focus();
                    return;
                }

                MessageBox.Show(
                    "Đăng ký tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // 5. Xóa dữ liệu sau khi đăng ký thành công
                txtTenDangNhap.Clear();
                txtHoTen.Clear();
                txtMatKhau.Clear();
                txtXacNhanMatKhau.Clear();
                txtEmail.Clear();

                Close();
            }

            catch (SqlException)
            {
                MessageBox.Show(
                    "Không thể lưu dữ liệu. " +
                    "Vui lòng kiểm tra kết nối cơ sở dữ liệu.",
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Đã xảy ra lỗi khi đăng ký. Vui lòng thử lại.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        // Chọn "Huỷ" (hoặc nhấn Esc): đóng form, quay lại form Đăng nhập.
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
