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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblLoi.Text = string.Empty;
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;


            if (string.IsNullOrEmpty(tenDangNhap))
            {
                lblLoi.Text = "Vui lòng nhập tên đăng nhập.";
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                lblLoi.Text = "Vui lòng nhập mật khẩu.";
                txtMatKhau.Focus();
                return;
            }


            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";

            try
            {
                bool thanhCong = await XacThucNguoiDungAsync(tenDangNhap, matKhau);

                if (thanhCong)
                {

                    FormChinh frmChinh = new FormChinh(tenDangNhap);

                    frmChinh.FormClosed += (s, args) =>
                    {
                        txtMatKhau.Clear();
                        lblLoi.Text = string.Empty;
                        this.Show();
                    };

                    this.Hide();
                    frmChinh.Show();
                }
                else
                {
   
                    lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không chính xác.";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
            catch (SqlException)
            {
                lblLoi.Text = "Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại dịch vụ SQL Server.";
            }
            catch (Exception ex)
            {
                lblLoi.Text = "Đã xảy ra lỗi hệ thống: " + ex.Message;
            }
            finally
            {
           
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";
            }
        }


        private async Task<bool> XacThucNguoiDungAsync(string ten, string matKhau)
        {

            const string sql = "SELECT Salt, MatKhauBam FROM Users WHERE TenDangNhap = @ten";

            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = ten;

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                string salt = reader.GetString(reader.GetOrdinal("Salt"));
                string matKhauBam = reader.GetString(reader.GetOrdinal("MatKhauBam"));

                return MatKhau.KiemTra(matKhau, salt, matKhauBam);
            }

            return false;

        }
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy frmDangKy = new FormDangKy();
            frmDangKy.FormClosed += (s, args) => this.Show();
            this.Hide();
            frmDangKy.Show();
        }
    }
}
