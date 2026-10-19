using Microsoft.Data.SqlClient;
using QuanLyNguoiDung.BaoMat;
using QuanLyNguoiDung.DuLieu;
using System;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class FormDangKy : Form
    {
        private readonly NguoiDungRepository _repo = new NguoiDungRepository();

        public FormDangKy()
        {
            InitializeComponent();
            lblLoiChung.Text = string.Empty;
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            lblLoiChung.Text = string.Empty;
            string ten = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text; // Lấy dữ liệu từ ô mới

            // 1. Kiểm tra bỏ trống
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                lblLoiChung.Text = "Vui lòng nhập đầy đủ thông tin.";
                return;
            }

            // 2. Kiểm tra 2 mật khẩu có khớp nhau không
            if (matKhau != nhapLaiMatKhau)
            {
                lblLoiChung.Text = "Mật khẩu nhập lại không khớp!";
                txtNhapLaiMatKhau.Clear();
                txtNhapLaiMatKhau.Focus();
                return;
            }

            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                // 3. Băm mật khẩu
                var (salt, bam) = MatKhau.Tao(matKhau);

                // 4. Lưu vào CSDL
                bool thanhCong = await _repo.ThemNguoiDungAsync(ten, salt, bam);

                if (thanhCong)
                {
                    MessageBox.Show("Đăng ký thành công! Hãy quay lại đăng nhập.");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                // Bắt lỗi trùng tên đăng nhập
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    lblLoiChung.Text = "Tên đăng nhập này đã có người sử dụng!";
                }
                else
                {
                    lblLoiChung.Text = "Lỗi SQL: " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                lblLoiChung.Text = "Lỗi: " + ex.Message;
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng Ký";
            }
        }
    }
}