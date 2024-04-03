namespace DangKi
{
    partial class Main
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
            button1 = new Button();
            sideBarPanel = new Panel();
            btnAnalysis = new Button();
            btnSalary = new Button();
            btnSchedule = new Button();
            containerPanel = new Panel();
            sideBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(418, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // sideBarPanel
            // 
            sideBarPanel.Controls.Add(btnAnalysis);
            sideBarPanel.Controls.Add(btnSalary);
            sideBarPanel.Controls.Add(btnSchedule);
            sideBarPanel.Location = new Point(0, 0);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new Size(120, 581);
            sideBarPanel.TabIndex = 1;
            // 
            // btnAnalysis
            // 
            btnAnalysis.BackColor = SystemColors.Control;
            btnAnalysis.Cursor = Cursors.Hand;
            btnAnalysis.Location = new Point(3, 178);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Size = new Size(117, 40);
            btnAnalysis.TabIndex = 2;
            btnAnalysis.Text = "Analysis";
            btnAnalysis.UseVisualStyleBackColor = false;
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // btnSalary
            // 
            btnSalary.BackColor = SystemColors.Control;
            btnSalary.Cursor = Cursors.Hand;
            btnSalary.Location = new Point(3, 103);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(117, 40);
            btnSalary.TabIndex = 1;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += button3_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Cursor = Cursors.Hand;
            btnSchedule.Location = new Point(3, 30);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(117, 40);
            btnSchedule.TabIndex = 0;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // containerPanel
            // 
            containerPanel.Location = new Point(126, 0);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(882, 545);
            containerPanel.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 543);
            Controls.Add(containerPanel);
            Controls.Add(sideBarPanel);
            Controls.Add(button1);
            Name = "Main";
            Text = "Main";
            sideBarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel sideBarPanel;
        private Button btnSalary;
        private Button btnSchedule;
        private Button btnAnalysis;
        private Panel containerPanel;
    }
}