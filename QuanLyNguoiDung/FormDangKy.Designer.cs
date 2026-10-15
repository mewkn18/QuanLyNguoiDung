namespace QuanLyNguoiDung
{
    partial class FormDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblLoiTenDangNhap = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLoiHoTen = new Label();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblLoiMatKhau = new Label();
            lblXacNhanMatKhau = new Label();
            txtXacNhanMatKhau = new TextBox();
            lblLoiXacNhanMatKhau = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblLoiEmail = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            pnlTieuDe.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.FromArgb(31, 111, 120);
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(460, 56);
            pnlTieuDe.TabIndex = 20;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(28, 13);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(200, 32);
            lblTieuDe.TabIndex = 21;
            lblTieuDe.Text = "Đăng ký tài khoản";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(32, 72);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(120, 23);
            lblTenDangNhap.TabIndex = 10;
            lblTenDangNhap.Text = "Tên đăng nhập *";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(32, 96);
            txtTenDangNhap.MaxLength = 20;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "3 – 20 ký tự";
            txtTenDangNhap.Size = new Size(396, 30);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblLoiTenDangNhap
            // 
            lblLoiTenDangNhap.Font = new Font("Segoe UI", 9F);
            lblLoiTenDangNhap.ForeColor = Color.FromArgb(192, 0, 0);
            lblLoiTenDangNhap.Location = new Point(32, 128);
            lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            lblLoiTenDangNhap.Size = new Size(396, 22);
            lblLoiTenDangNhap.TabIndex = 30;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(32, 156);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(120, 23);
            lblHoTen.TabIndex = 11;
            lblHoTen.Text = "Họ và tên *";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(32, 180);
            txtHoTen.MaxLength = 50;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Ví dụ: Nguyễn Văn A";
            txtHoTen.Size = new Size(396, 30);
            txtHoTen.TabIndex = 1;
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.Font = new Font("Segoe UI", 9F);
            lblLoiHoTen.ForeColor = Color.FromArgb(192, 0, 0);
            lblLoiHoTen.Location = new Point(32, 212);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(396, 22);
            lblLoiHoTen.TabIndex = 31;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(32, 240);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(120, 23);
            lblMatKhau.TabIndex = 12;
            lblMatKhau.Text = "Mật khẩu *";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(32, 264);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Tối thiểu 8 ký tự";
            txtMatKhau.Size = new Size(396, 30);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.Font = new Font("Segoe UI", 9F);
            lblLoiMatKhau.ForeColor = Color.FromArgb(192, 0, 0);
            lblLoiMatKhau.Location = new Point(32, 296);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(396, 22);
            lblLoiMatKhau.TabIndex = 32;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Location = new Point(32, 324);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(120, 23);
            lblXacNhanMatKhau.TabIndex = 13;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu *";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(32, 348);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PlaceholderText = "Nhập lại mật khẩu";
            txtXacNhanMatKhau.Size = new Size(396, 30);
            txtXacNhanMatKhau.TabIndex = 3;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblLoiXacNhanMatKhau
            // 
            lblLoiXacNhanMatKhau.Font = new Font("Segoe UI", 9F);
            lblLoiXacNhanMatKhau.ForeColor = Color.FromArgb(192, 0, 0);
            lblLoiXacNhanMatKhau.Location = new Point(32, 380);
            lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            lblLoiXacNhanMatKhau.Size = new Size(396, 22);
            lblLoiXacNhanMatKhau.TabIndex = 33;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 408);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(120, 23);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 432);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ten@mien.com";
            txtEmail.Size = new Size(396, 30);
            txtEmail.TabIndex = 4;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.Font = new Font("Segoe UI", 9F);
            lblLoiEmail.ForeColor = Color.FromArgb(192, 0, 0);
            lblLoiEmail.Location = new Point(32, 464);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(396, 22);
            lblLoiEmail.TabIndex = 34;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(31, 111, 120);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 90, 98);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(204, 496);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(116, 36);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(240, 240, 240);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnHuy.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 225, 225);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(328, 496);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 36);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormDangKy
            // 
            AcceptButton = btnDangKy;
            CancelButton = btnHuy;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(460, 560);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblLoiEmail);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblLoiXacNhanMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblLoiHoTen);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblLoiTenDangNhap);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblLoiTenDangNhap;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLoiHoTen;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoiMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblLoiXacNhanMatKhau;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblLoiEmail;
        private Button btnDangKy;
        private Button btnHuy;
    }
}
