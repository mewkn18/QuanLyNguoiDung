namespace QuanLyNguoiDung
{
   
public partial class FormDangNhap : Form
{
    private readonly TaiKhoanRepository _repo = new TaiKhoanRepository();

    public FormDangNhap()
    {
        InitializeComponent();
        lblLoiChung.Text = string.Empty;     }

    private async void btnDangNhap_Click(object sender, EventArgs e)
    {
        lblLoiChung.Text = string.Empty;
        string ten = txtTenDangNhap.Text.Trim();
        string matKhau = txtMatKhau.Text;

        if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(matKhau))
        {
            lblLoiChung.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
            return;
        }

        btnDangNhap.Enabled = false;
        btnDangNhap.Text = "Đang xử lý...";

        try
        {
            var user = await _repo.DangNhapAsync(ten, matKhau);
            if (user == null)
            {
                lblLoiChung.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            var formChinh = new FormChinh(user);
            formChinh.FormClosed += (s, args) => 
            {
                txtMatKhau.Clear();
                this.Show();
            };
            this.Hide();
            formChinh.Show();
        }
        catch (SqlException)
        {
            lblLoiChung.Text = "Không thể kết nối đến cơ sở dữ liệu. Vui lòng kiểm tra lại dịch vụ SQL Server.";
        }
        catch (Exception)
        {
            lblLoiChung.Text = "Đã xảy ra lỗi không xác định. Vui lòng thử lại sau.";
        }
        finally
        {
            btnDangNhap.Enabled = true;
            btnDangNhap.Text = "Đăng nhập";
        }
    }

    private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var formDangKy = new FormDangKy();
        formDangKy.FormClosed += (s, args) => this.Show();
        this.Hide();
        formDangKy.Show();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }}
