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
            richTextBox1 = new RichTextBox();
            dk_taotaikhoan = new Label();
            dk_diachiemail = new Label();
            label1 = new Label();
            dk_matkhau = new Label();
            dk_nhaplaimatkhau = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            dk_dieukhoan = new CheckBox();
            taotaikhoan = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(160, 136);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(134, 33);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
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
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click_2;
            // 
            // dk_matkhau
            // 
            dk_matkhau.AutoSize = true;
            dk_matkhau.Location = new Point(69, 245);
            dk_matkhau.Name = "dk_matkhau";
            dk_matkhau.Size = new Size(70, 20);
            dk_matkhau.TabIndex = 4;
            dk_matkhau.Text = "Mật khẩu";
            // 
            // dk_nhaplaimatkhau
            // 
            dk_nhaplaimatkhau.AutoSize = true;
            dk_nhaplaimatkhau.Location = new Point(9, 296);
            dk_nhaplaimatkhau.Name = "dk_nhaplaimatkhau";
            dk_nhaplaimatkhau.Size = new Size(130, 20);
            dk_nhaplaimatkhau.TabIndex = 5;
            dk_nhaplaimatkhau.Text = "Nhập lại mật khẩu";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(160, 296);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(134, 29);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(160, 242);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(134, 31);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(160, 190);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(134, 31);
            richTextBox4.TabIndex = 8;
            richTextBox4.Text = "";
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
            // taotaikhoan
            // 
            taotaikhoan.Location = new Point(144, 398);
            taotaikhoan.Name = "taotaikhoan";
            taotaikhoan.Size = new Size(150, 29);
            taotaikhoan.TabIndex = 10;
            taotaikhoan.Text = "Tạo tài khoản";
            taotaikhoan.UseVisualStyleBackColor = true;
            taotaikhoan.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(taotaikhoan);
            Controls.Add(dk_dieukhoan);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(dk_nhaplaimatkhau);
            Controls.Add(dk_matkhau);
            Controls.Add(label1);
            Controls.Add(dk_diachiemail);
            Controls.Add(dk_taotaikhoan);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label dk_taotaikhoan;
        private Label dk_diachiemail;
        private Label label1;
        private Label dk_matkhau;
        private Label dk_nhaplaimatkhau;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private CheckBox dk_dieukhoan;
        private Button taotaikhoan;
    }
}
