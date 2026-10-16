namespace QuanLyNguoiDung
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            txtEmail = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            lblLoiTenDangNhap = new Label();
            lblLoiMatKhau = new Label();
            lblLoiXacNhanMatKhau = new Label();
            lblLoiEmail = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 121);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 215);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 2;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 307);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(219, 28);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "3 - 20 ký tự";
            txtTenDangNhap.Size = new Size(351, 31);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(219, 115);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "tối thiểu 8 ký tự";
            txtMatKhau.Size = new Size(351, 31);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(219, 209);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PlaceholderText = "Nhập lại mật khẩu";
            txtXacNhanMatKhau.Size = new Size(351, 31);
            txtXacNhanMatKhau.TabIndex = 6;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 301);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ten@mien.com";
            txtEmail.Size = new Size(351, 31);
            txtEmail.TabIndex = 7;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(462, 381);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 34);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(639, 381);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblLoiTenDangNhap
            // 
            lblLoiTenDangNhap.AutoSize = true;
            lblLoiTenDangNhap.Location = new Point(219, 73);
            lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            lblLoiTenDangNhap.Size = new Size(0, 25);
            lblLoiTenDangNhap.TabIndex = 4;
            // 
            // lblLoiMatKhau
            // 
            lblLoiMatKhau.AutoSize = true;
            lblLoiMatKhau.Location = new Point(219, 160);
            lblLoiMatKhau.Name = "lblLoiMatKhau";
            lblLoiMatKhau.Size = new Size(0, 25);
            lblLoiMatKhau.TabIndex = 5;
            // 
            // lblLoiXacNhanMatKhau
            // 
            lblLoiXacNhanMatKhau.AutoSize = true;
            lblLoiXacNhanMatKhau.Location = new Point(219, 260);
            lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            lblLoiXacNhanMatKhau.Size = new Size(0, 25);
            lblLoiXacNhanMatKhau.TabIndex = 6;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.AutoSize = true;
            lblLoiEmail.Location = new Point(219, 347);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(0, 25);
            lblLoiEmail.TabIndex = 7;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoiEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblLoiXacNhanMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLoiMatKhau);
            Controls.Add(btnHuy);
            Controls.Add(lblLoiTenDangNhap);
            Controls.Add(btnDangKy);
            Controls.Add(txtEmail);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Name = "FormDangKy";
            Text = "FormDangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtEmail;
        private Button btnDangKy;
        private Button btnHuy;
        private Label lblLoiTenDangNhap;
        private Label lblLoiMatKhau;
        private Label lblLoiXacNhanMatKhau;
        private Label lblLoiEmail;
    }
}