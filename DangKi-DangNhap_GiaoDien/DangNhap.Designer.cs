namespace DangKi
{
    partial class DangNhap
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
            dk_taotaikhoan = new Label();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // dk_taotaikhoan
            // 
            dk_taotaikhoan.AutoSize = true;
            dk_taotaikhoan.BorderStyle = BorderStyle.FixedSingle;
            dk_taotaikhoan.Font = new Font("Segoe UI", 20F);
            dk_taotaikhoan.Location = new Point(270, 56);
            dk_taotaikhoan.Name = "dk_taotaikhoan";
            dk_taotaikhoan.Size = new Size(215, 48);
            dk_taotaikhoan.TabIndex = 2;
            dk_taotaikhoan.Text = "ĐĂNG NHẬP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 146);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 226);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(167, 129);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 37);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(167, 209);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(150, 37);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(160, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(157, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Ghi nhớ đăng nhập";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(186, 320);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(167, 366);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 9;
            button2.Text = "Quên mật khẩu";
            button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(167, 410);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Tạo tài khoản mới";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dk_taotaikhoan);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dk_taotaikhoan;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}