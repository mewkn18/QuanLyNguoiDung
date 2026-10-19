namespace QuanLyNguoiDung
{
    partial class FormChinh
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
            lblXinChao = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblLanDangNhapCuoi = new Label();
            btnDangXuat = new Button();
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
            lblTieuDe.Text = "Trang chính";
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblXinChao.ForeColor = Color.FromArgb(31, 111, 120);
            lblXinChao.Location = new Point(32, 76);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(200, 30);
            lblXinChao.TabIndex = 10;
            lblXinChao.Text = "Xin chào, Nguyễn Văn A";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.ForeColor = Color.FromArgb(64, 64, 64);
            lblTenDangNhap.Location = new Point(32, 124);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(200, 23);
            lblTenDangNhap.TabIndex = 11;
            lblTenDangNhap.Text = "Tên đăng nhập:  nguyenvana";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(32, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(200, 23);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:  a@example.com";
            // 
            // lblLanDangNhapCuoi
            // 
            lblLanDangNhapCuoi.AutoSize = true;
            lblLanDangNhapCuoi.ForeColor = Color.FromArgb(64, 64, 64);
            lblLanDangNhapCuoi.Location = new Point(32, 192);
            lblLanDangNhapCuoi.Name = "lblLanDangNhapCuoi";
            lblLanDangNhapCuoi.Size = new Size(200, 23);
            lblLanDangNhapCuoi.TabIndex = 13;
            lblLanDangNhapCuoi.Text = "Lần đăng nhập gần nhất:  21/09/2026 09:15";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(240, 240, 240);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 225, 225);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Location = new Point(268, 250);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(120, 36);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // FormChinh
            // 
            CancelButton = btnDangXuat;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(420, 314);
            Controls.Add(btnDangXuat);
            Controls.Add(lblLanDangNhapCuoi);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblXinChao);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chính";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblLanDangNhapCuoi;
        private Button btnDangXuat;
    }
}
