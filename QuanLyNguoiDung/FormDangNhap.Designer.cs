namespace QuanLyNguoiDung
{
    partial class FormDangNhap
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
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblLoi = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            lnkDangKy = new LinkLabel();
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
            pnlTieuDe.Size = new Size(420, 56);
            pnlTieuDe.TabIndex = 9;
            //
            // lblTieuDe
            //
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(28, 13);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(120, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Đăng nhập";
            //
            // lblTenDangNhap
            //
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(32, 76);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(104, 23);
            lblTenDangNhap.TabIndex = 5;
            lblTenDangNhap.Text = "Tên đăng nhập";
            //
            // txtTenDangNhap
            //
            txtTenDangNhap.Location = new Point(32, 100);
            txtTenDangNhap.MaxLength = 20;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập";
            txtTenDangNhap.Size = new Size(356, 30);
            txtTenDangNhap.TabIndex = 0;
            //
            // lblMatKhau
            //
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(32, 140);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 23);
            lblMatKhau.TabIndex = 6;
            lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            txtMatKhau.Location = new Point(32, 164);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu";
            txtMatKhau.Size = new Size(356, 30);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            //
            // lblLoi
            //
            lblLoi.Font = new Font("Segoe UI", 9F);
            lblLoi.ForeColor = Color.FromArgb(192, 0, 0);
            lblLoi.Location = new Point(32, 200);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(356, 40);
            lblLoi.TabIndex = 7;
            //
            // btnDangNhap
            //
            btnDangNhap.BackColor = Color.FromArgb(31, 111, 120);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 90, 98);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(168, 246);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(108, 36);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            //
            // btnThoat
            //
            btnThoat.BackColor = Color.FromArgb(240, 240, 240);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 225, 225);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(284, 246);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(104, 36);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            //
            // lnkDangKy
            //
            lnkDangKy.ActiveLinkColor = Color.FromArgb(24, 90, 98);
            lnkDangKy.LinkArea = new LinkArea(19, 7);
            lnkDangKy.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkDangKy.LinkColor = Color.FromArgb(31, 111, 120);
            lnkDangKy.Location = new Point(32, 298);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(356, 28);
            lnkDangKy.TabIndex = 4;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Chưa có tài khoản? Đăng ký";
            lnkDangKy.TextAlign = ContentAlignment.MiddleCenter;
            lnkDangKy.UseCompatibleTextRendering = true;
            lnkDangKy.LinkClicked += lnkDangKy_LinkClicked;
            //
            // FormDangNhap
            //
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(420, 340);
            Controls.Add(lnkDangKy);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(lblLoi);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
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
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoi;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel lnkDangKy;
    }
}
