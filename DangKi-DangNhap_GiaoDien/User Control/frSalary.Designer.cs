namespace DangKi.User_Control
{
    partial class frSalary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lb1 = new Label();
            lbTotalTime = new Label();
            panel1 = new Panel();
            cbMonth = new ComboBox();
            label2 = new Label();
            lbSalary = new Label();
            dtDetailSalary = new DataGridView();
            clSubject = new DataGridViewTextBoxColumn();
            clSalary = new DataGridViewTextBoxColumn();
            clTime = new DataGridViewTextBoxColumn();
            clDayStudy = new DataGridViewTextBoxColumn();
            clStart = new DataGridViewTextBoxColumn();
            clEnd = new DataGridViewTextBoxColumn();
            clTotalSalary = new DataGridViewTextBoxColumn();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtDetailSalary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(45, 155, 240);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 57);
            label1.TabIndex = 0;
            label1.Text = "Salary";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            lb1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb1.Location = new Point(86, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(224, 57);
            lb1.TabIndex = 1;
            lb1.Text = "Tổng thời gian dạy trong tháng:";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTotalTime
            // 
            lbTotalTime.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbTotalTime.Location = new Point(462, 0);
            lbTotalTime.Name = "lbTotalTime";
            lbTotalTime.Size = new Size(162, 57);
            lbTotalTime.TabIndex = 2;
            lbTotalTime.Text = "0 giờ / tháng";
            lbTotalTime.TextAlign = ContentAlignment.MiddleLeft;
            lbTotalTime.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 2);
            panel1.TabIndex = 3;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cbMonth.Location = new Point(316, 19);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(121, 23);
            cbMonth.TabIndex = 1;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(86, 82);
            label2.Name = "label2";
            label2.Size = new Size(181, 57);
            label2.TabIndex = 4;
            label2.Text = "Tổng lương trong tháng:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // lbSalary
            // 
            lbSalary.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbSalary.Location = new Point(316, 82);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(204, 57);
            lbSalary.TabIndex = 5;
            lbSalary.Text = "0 / tháng";
            lbSalary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtDetailSalary
            // 
            dtDetailSalary.Columns.AddRange(new DataGridViewColumn[] { clSubject, clSalary, clTime, clDayStudy, clStart, clEnd, clTotalSalary });
            dtDetailSalary.Location = new Point(-3, 229);
            dtDetailSalary.Name = "dtDetailSalary";
            dtDetailSalary.Size = new Size(882, 316);
            dtDetailSalary.TabIndex = 6;
            dtDetailSalary.CellContentClick += dtDetailSalary_CellContentClick;
            // 
            // clSubject
            // 
            clSubject.HeaderText = "Môn";
            clSubject.Name = "clSubject";
            // 
            // clSalary
            // 
            clSalary.HeaderText = "Lương";
            clSalary.Name = "clSalary";
            // 
            // clTime
            // 
            clTime.HeaderText = "Số giờ dạy";
            clTime.Name = "clTime";
            // 
            // clDayStudy
            // 
            clDayStudy.HeaderText = "Ngày dạy";
            clDayStudy.Name = "clDayStudy";
            // 
            // clStart
            // 
            clStart.HeaderText = "Giờ bắt đầu ca";
            clStart.Name = "clStart";
            // 
            // clEnd
            // 
            clEnd.HeaderText = "Giờ kết thúc ca";
            clEnd.Name = "clEnd";
            // 
            // clTotalSalary
            // 
            clTotalSalary.HeaderText = "Tổng tiền ";
            clTotalSalary.Name = "clTotalSalary";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(289, 159);
            label3.Name = "label3";
            label3.Size = new Size(335, 41);
            label3.TabIndex = 7;
            label3.Text = "Chi tiết thu nhập trong tháng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // frSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(label3);
            Controls.Add(dtDetailSalary);
            Controls.Add(lbSalary);
            Controls.Add(label2);
            Controls.Add(cbMonth);
            Controls.Add(panel1);
            Controls.Add(lbTotalTime);
            Controls.Add(lb1);
            Controls.Add(label1);
            Name = "frSalary";
            Size = new Size(882, 545);
            ((System.ComponentModel.ISupportInitialize)dtDetailSalary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lb1;
        private Label lbTotalTime;
        private Panel panel1;
        private ComboBox cbMonth;
        private Label label2;
        private Label lbSalary;
        private DataGridView dtDetailSalary;
        private Label label3;
        private DataGridViewTextBoxColumn clSubject;
        private DataGridViewTextBoxColumn clSalary;
        private DataGridViewTextBoxColumn clTime;
        private DataGridViewTextBoxColumn clDayStudy;
        private DataGridViewTextBoxColumn clStart;
        private DataGridViewTextBoxColumn clEnd;
        private DataGridViewTextBoxColumn clTotalSalary;
    }
}
