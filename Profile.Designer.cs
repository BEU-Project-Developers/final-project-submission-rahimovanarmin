﻿namespace TaskSchudler
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.ProfileNav = new System.Windows.Forms.Label();
            this.RemindersNav = new System.Windows.Forms.Label();
            this.AllTasksNav = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Logolabel = new System.Windows.Forms.Label();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.EscapeButtonu = new System.Windows.Forms.Label();
            this.Next7daystasks = new System.Windows.Forms.Label();
            this.ProfileTable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UncompletedTasks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Countofcompleted = new System.Windows.Forms.Label();
            this.CompletedTasks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfileNav
            // 
            this.ProfileNav.AutoSize = true;
            this.ProfileNav.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ProfileNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ProfileNav.Location = new System.Drawing.Point(83, 298);
            this.ProfileNav.Name = "ProfileNav";
            this.ProfileNav.Size = new System.Drawing.Size(69, 23);
            this.ProfileNav.TabIndex = 23;
            this.ProfileNav.Text = "Profile";
            this.ProfileNav.Click += new System.EventHandler(this.ProfileNav_Click);
            // 
            // RemindersNav
            // 
            this.RemindersNav.AutoSize = true;
            this.RemindersNav.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.RemindersNav.ForeColor = System.Drawing.Color.White;
            this.RemindersNav.Location = new System.Drawing.Point(83, 262);
            this.RemindersNav.Name = "RemindersNav";
            this.RemindersNav.Size = new System.Drawing.Size(110, 23);
            this.RemindersNav.TabIndex = 22;
            this.RemindersNav.Text = "Reminders";
            this.RemindersNav.Click += new System.EventHandler(this.RemindersNav_Click);
            // 
            // AllTasksNav
            // 
            this.AllTasksNav.AutoSize = true;
            this.AllTasksNav.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AllTasksNav.ForeColor = System.Drawing.Color.White;
            this.AllTasksNav.Location = new System.Drawing.Point(83, 225);
            this.AllTasksNav.Name = "AllTasksNav";
            this.AllTasksNav.Size = new System.Drawing.Size(88, 23);
            this.AllTasksNav.TabIndex = 21;
            this.AllTasksNav.Text = "All tasks";
            this.AllTasksNav.Click += new System.EventHandler(this.AllTasksNav_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(91, 63);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 20;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Logolabel
            // 
            this.Logolabel.AutoSize = true;
            this.Logolabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.Logolabel.ForeColor = System.Drawing.Color.White;
            this.Logolabel.Location = new System.Drawing.Point(45, 156);
            this.Logolabel.Name = "Logolabel";
            this.Logolabel.Size = new System.Drawing.Size(179, 29);
            this.Logolabel.TabIndex = 19;
            this.Logolabel.Text = "Task Schudler";
            this.Logolabel.Click += new System.EventHandler(this.Logolabel_Click);
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.ProfilePanel.Controls.Add(this.label2);
            this.ProfilePanel.Controls.Add(this.EscapeButtonu);
            this.ProfilePanel.Controls.Add(this.Next7daystasks);
            this.ProfilePanel.Controls.Add(this.ProfileTable);
            this.ProfilePanel.Controls.Add(this.panel3);
            this.ProfilePanel.Controls.Add(this.panel2);
            this.ProfilePanel.Location = new System.Drawing.Point(260, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(851, 714);
            this.ProfilePanel.TabIndex = 18;
            this.ProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RemindersPanel_Paint);
            // 
            // EscapeButtonu
            // 
            this.EscapeButtonu.AutoSize = true;
            this.EscapeButtonu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.EscapeButtonu.ForeColor = System.Drawing.Color.White;
            this.EscapeButtonu.Location = new System.Drawing.Point(815, 9);
            this.EscapeButtonu.Name = "EscapeButtonu";
            this.EscapeButtonu.Size = new System.Drawing.Size(24, 23);
            this.EscapeButtonu.TabIndex = 25;
            this.EscapeButtonu.Text = "X";
            this.EscapeButtonu.Click += new System.EventHandler(this.EscapeButtonu_Click);
            // 
            // Next7daystasks
            // 
            this.Next7daystasks.AutoSize = true;
            this.Next7daystasks.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Next7daystasks.ForeColor = System.Drawing.Color.White;
            this.Next7daystasks.Location = new System.Drawing.Point(53, 328);
            this.Next7daystasks.Name = "Next7daystasks";
            this.Next7daystasks.Size = new System.Drawing.Size(183, 23);
            this.Next7daystasks.TabIndex = 24;
            this.Next7daystasks.Text = "Next 7 days tasks:";
            // 
            // ProfileTable
            // 
            this.ProfileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfileTable.Location = new System.Drawing.Point(57, 354);
            this.ProfileTable.Name = "ProfileTable";
            this.ProfileTable.RowHeadersWidth = 51;
            this.ProfileTable.RowTemplate.Height = 24;
            this.ProfileTable.Size = new System.Drawing.Size(725, 357);
            this.ProfileTable.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.UncompletedTasks);
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(465, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 172);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "[Count]";
            // 
            // UncompletedTasks
            // 
            this.UncompletedTasks.AutoSize = true;
            this.UncompletedTasks.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.UncompletedTasks.ForeColor = System.Drawing.Color.Black;
            this.UncompletedTasks.Location = new System.Drawing.Point(49, 31);
            this.UncompletedTasks.Name = "UncompletedTasks";
            this.UncompletedTasks.Size = new System.Drawing.Size(232, 30);
            this.UncompletedTasks.TabIndex = 25;
            this.UncompletedTasks.Text = "Unompleted tasks:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Countofcompleted);
            this.panel2.Controls.Add(this.CompletedTasks);
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(63, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 172);
            this.panel2.TabIndex = 1;
            // 
            // Countofcompleted
            // 
            this.Countofcompleted.AutoSize = true;
            this.Countofcompleted.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.Countofcompleted.ForeColor = System.Drawing.Color.Black;
            this.Countofcompleted.Location = new System.Drawing.Point(90, 86);
            this.Countofcompleted.Name = "Countofcompleted";
            this.Countofcompleted.Size = new System.Drawing.Size(144, 40);
            this.Countofcompleted.TabIndex = 25;
            this.Countofcompleted.Text = "[Count]";
            // 
            // CompletedTasks
            // 
            this.CompletedTasks.AutoSize = true;
            this.CompletedTasks.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.CompletedTasks.ForeColor = System.Drawing.Color.Black;
            this.CompletedTasks.Location = new System.Drawing.Point(55, 31);
            this.CompletedTasks.Name = "CompletedTasks";
            this.CompletedTasks.Size = new System.Drawing.Size(221, 30);
            this.CompletedTasks.TabIndex = 24;
            this.CompletedTasks.Text = "Completed tasks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Note:The DataGrid is for showing Tasks for 7 days Table ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(77)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(1111, 714);
            this.Controls.Add(this.ProfileNav);
            this.Controls.Add(this.RemindersNav);
            this.Controls.Add(this.AllTasksNav);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Logolabel);
            this.Controls.Add(this.ProfilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfileNav;
        private System.Windows.Forms.Label RemindersNav;
        private System.Windows.Forms.Label AllTasksNav;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Label Next7daystasks;
        private System.Windows.Forms.DataGridView ProfileTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UncompletedTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Countofcompleted;
        private System.Windows.Forms.Label CompletedTasks;
        private System.Windows.Forms.Label EscapeButtonu;
        private System.Windows.Forms.Label label2;
    }
}