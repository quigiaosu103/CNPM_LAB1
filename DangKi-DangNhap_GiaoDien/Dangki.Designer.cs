namespace DangKi
{
    partial class Dangki
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
            txtEmail = new RichTextBox();
            dk_taotaikhoan = new Label();
            dk_diachiemail = new Label();
            label1 = new Label();
            lPass1 = new Label();
            dk_nhaplaimatkhau = new Label();
            txtPass2 = new RichTextBox();
            txtPass = new RichTextBox();
            dk_dieukhoan = new CheckBox();
            btnCreate = new Button();
            txtCode = new RichTextBox();
            label2 = new Label();
            btnCode = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(134, 33);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "";
            txtEmail.TextChanged += richTextBox1_TextChanged;
            // 
            // dk_taotaikhoan
            // 
            dk_taotaikhoan.AutoSize = true;
            dk_taotaikhoan.BorderStyle = BorderStyle.FixedSingle;
            dk_taotaikhoan.Font = new Font("Segoe UI", 20F);
            dk_taotaikhoan.Location = new Point(267, 36);
            dk_taotaikhoan.Name = "dk_taotaikhoan";
            dk_taotaikhoan.Size = new Size(270, 48);
            dk_taotaikhoan.TabIndex = 1;
            dk_taotaikhoan.Text = "TẠO TÀI KHOẢN";
            dk_taotaikhoan.Click += label1_Click;
            // 
            // dk_diachiemail
            // 
            dk_diachiemail.AutoSize = true;
            dk_diachiemail.Location = new Point(45, 136);
            dk_diachiemail.Name = "dk_diachiemail";
            dk_diachiemail.Size = new Size(96, 20);
            dk_diachiemail.TabIndex = 2;
            dk_diachiemail.Text = "Địa chỉ Email";
            dk_diachiemail.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 190);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            label1.Click += label1_Click_2;
            // 
            // lPass1
            // 
            lPass1.AutoSize = true;
            lPass1.Location = new Point(71, 193);
            lPass1.Name = "lPass1";
            lPass1.Size = new Size(70, 20);
            lPass1.TabIndex = 4;
            lPass1.Text = "Mật khẩu";
            // 
            // dk_nhaplaimatkhau
            // 
            dk_nhaplaimatkhau.AutoSize = true;
            dk_nhaplaimatkhau.Location = new Point(11, 242);
            dk_nhaplaimatkhau.Name = "dk_nhaplaimatkhau";
            dk_nhaplaimatkhau.Size = new Size(130, 20);
            dk_nhaplaimatkhau.TabIndex = 5;
            dk_nhaplaimatkhau.Text = "Nhập lại mật khẩu";
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(160, 242);
            txtPass2.Name = "txtPass2";
            txtPass2.Size = new Size(134, 31);
            txtPass2.TabIndex = 7;
            txtPass2.Text = "";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(160, 190);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(134, 31);
            txtPass.TabIndex = 8;
            txtPass.Text = "";
            // 
            // dk_dieukhoan
            // 
            dk_dieukhoan.AutoSize = true;
            dk_dieukhoan.Location = new Point(84, 347);
            dk_dieukhoan.Name = "dk_dieukhoan";
            dk_dieukhoan.Size = new Size(210, 24);
            dk_dieukhoan.TabIndex = 9;
            dk_dieukhoan.Text = "Đồng ý với mọi điều khoản";
            dk_dieukhoan.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(144, 398);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Tạo tài khoản";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button1_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(160, 296);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(134, 29);
            txtCode.TabIndex = 6;
            txtCode.Text = "";
            txtCode.TextChanged += txtCode_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 299);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 11;
            label2.Text = "Mã Xác Thục";
            // 
            // btnCode
            // 
            btnCode.Location = new Point(318, 295);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(150, 29);
            btnCode.TabIndex = 12;
            btnCode.Text = "Gửi";
            btnCode.UseVisualStyleBackColor = true;
            btnCode.Click += btnCode_Click;
            // 
            // Dangki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCode);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(dk_dieukhoan);
            Controls.Add(txtPass);
            Controls.Add(txtPass2);
            Controls.Add(txtCode);
            Controls.Add(dk_nhaplaimatkhau);
            Controls.Add(lPass1);
            Controls.Add(label1);
            Controls.Add(dk_diachiemail);
            Controls.Add(dk_taotaikhoan);
            Controls.Add(txtEmail);
            Name = "Dangki";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtEmail;
        private Label dk_taotaikhoan;
        private Label dk_diachiemail;
        private Label label1;
        private Label lPass1;
        private Label dk_nhaplaimatkhau;
        private RichTextBox txtPass2;
        private RichTextBox txtPass;
        private CheckBox dk_dieukhoan;
        private Button btnCreate;
        private RichTextBox txtCode;
        private Label label2;
        private Button btnCode;
    }
}
