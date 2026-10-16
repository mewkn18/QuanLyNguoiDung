using Microsoft.Data.SqlClient;
using QuanLyNguoiDung.BaoMat;
using QuanLyNguoiDung.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            lblLoiMatKhau.Text = "";
            lblLoiXacNhanMatKhau.Text = "";
            lblLoiEmail.Text = "";
        }

        private bool KiemTraDuLieu()
        {
            XoaLoi();

            bool hopLe = true;

            string ten = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string XacNhan = txtXacNhanMatKhau.Text;
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

            if (matKhau == "")
            {
                lblLoiMatKhau.Text = "Vui lòng nhập mật khẩu.";
                hopLe = false;
            }

            if (XacNhan == "")
            {
                lblLoiXacNhanMatKhau.Text =
                    "Vui lòng nhập lại mật khẩu.";
                hopLe = false;
            }
            else if (matKhau != XacNhan)
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

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu trước khi truy cập database
            if (!KiemTraDuLieu())
                return;

            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                string ten = txtTenDangNhap.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text;

                NguoiDungRepository NDrepo = new NguoiDungRepository();

                // 2. Kiểm tra tên đăng nhập trùng
                if (NDrepo.KiemTraTenDangNhapTonTaiAsync(ten))
                {
                    lblLoiTenDangNhap.Text =
                        "Tên đăng nhập đã tồn tại.";
                    txtTenDangNhap.Focus();
                    return;
                }

                // 3. Băm mật khẩu và tạo Salt riêng
                var ketQua = MatKhau.Tao(matKhau);

                // 4. Lưu thông tin vào SQL Server
                NDrepo.DangKyNguoiDungAsync(
                    ten,
                    email,
                    ketQua.Bam,
                    ketQua.Salt
                );

                MessageBox.Show(
                    "Đăng ký tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // 5. Xóa dữ liệu sau khi đăng ký thành công
                txtTenDangNhap.Clear();
                txtMatKhau.Clear();
                txtXacNhanMatKhau.Clear();
                txtEmail.Clear();

                // Có thể đóng form đăng ký để quay lại đăng nhập
                this.Close();
            }
            catch (SqlException ex) when (
                ex.Number == 2601 || ex.Number == 2627)
            {
                // UNIQUE vẫn bảo vệ dữ liệu nếu có đăng ký đồng thời
                lblLoiTenDangNhap.Text =
                    "Tên đăng nhập đã tồn tại.";
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
