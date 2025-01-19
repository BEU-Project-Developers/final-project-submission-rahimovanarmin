namespace TaskSchudler
{
    partial class Reminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminders));
            this.ProfileNav = new System.Windows.Forms.Label();
            this.RemindersNav = new System.Windows.Forms.Label();
            this.AllTasksNav = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Logolabel = new System.Windows.Forms.Label();
            this.RemindersPanel = new System.Windows.Forms.Panel();
            this.rəddolburdangetbuttonu = new System.Windows.Forms.Label();
            this.RemindersTable = new System.Windows.Forms.DataGridView();
            this.Remindercountmassage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.RemindersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemindersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileNav
            // 
            this.ProfileNav.AutoSize = true;
            this.ProfileNav.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProfileNav.ForeColor = System.Drawing.Color.White;
            this.ProfileNav.Location = new System.Drawing.Point(87, 298);
            this.ProfileNav.Name = "ProfileNav";
            this.ProfileNav.Size = new System.Drawing.Size(68, 23);
            this.ProfileNav.TabIndex = 17;
            this.ProfileNav.Text = "Profile";
            this.ProfileNav.Click += new System.EventHandler(this.ProfileNav_Click);
            // 
            // RemindersNav
            // 
            this.RemindersNav.AutoSize = true;
            this.RemindersNav.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.RemindersNav.Location = new System.Drawing.Point(83, 262);
            this.RemindersNav.Name = "RemindersNav";
            this.RemindersNav.Size = new System.Drawing.Size(112, 23);
            this.RemindersNav.TabIndex = 16;
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
            this.AllTasksNav.TabIndex = 15;
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
            this.Logo.TabIndex = 14;
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
            this.Logolabel.TabIndex = 13;
            this.Logolabel.Text = "Task Schudler";
            this.Logolabel.Click += new System.EventHandler(this.Logolabel_Click);
            // 
            // RemindersPanel
            // 
            this.RemindersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.RemindersPanel.Controls.Add(this.rəddolburdangetbuttonu);
            this.RemindersPanel.Controls.Add(this.RemindersTable);
            this.RemindersPanel.Controls.Add(this.Remindercountmassage);
            this.RemindersPanel.Location = new System.Drawing.Point(260, 0);
            this.RemindersPanel.Name = "RemindersPanel";
            this.RemindersPanel.Size = new System.Drawing.Size(851, 714);
            this.RemindersPanel.TabIndex = 12;
            this.RemindersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AllTasksPanel_Paint);
            // 
            // rəddolburdangetbuttonu
            // 
            this.rəddolburdangetbuttonu.AutoSize = true;
            this.rəddolburdangetbuttonu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rəddolburdangetbuttonu.ForeColor = System.Drawing.Color.White;
            this.rəddolburdangetbuttonu.Location = new System.Drawing.Point(815, 9);
            this.rəddolburdangetbuttonu.Name = "rəddolburdangetbuttonu";
            this.rəddolburdangetbuttonu.Size = new System.Drawing.Size(24, 23);
            this.rəddolburdangetbuttonu.TabIndex = 27;
            this.rəddolburdangetbuttonu.Text = "X";
            this.rəddolburdangetbuttonu.Click += new System.EventHandler(this.rəddolburdangetbuttonu_Click);
            // 
            // RemindersTable
            // 
            this.RemindersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.RemindersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemindersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemindersTable.Location = new System.Drawing.Point(35, 156);
            this.RemindersTable.Name = "RemindersTable";
            this.RemindersTable.RowHeadersWidth = 51;
            this.RemindersTable.RowTemplate.Height = 24;
            this.RemindersTable.Size = new System.Drawing.Size(788, 558);
            this.RemindersTable.TabIndex = 26;
            this.RemindersTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RemindersTable_CellFormatting);
            // 
            // Remindercountmassage
            // 
            this.Remindercountmassage.AutoSize = true;
            this.Remindercountmassage.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.Remindercountmassage.ForeColor = System.Drawing.Color.White;
            this.Remindercountmassage.Location = new System.Drawing.Point(28, 93);
            this.Remindercountmassage.Name = "Remindercountmassage";
            this.Remindercountmassage.Size = new System.Drawing.Size(569, 37);
            this.Remindercountmassage.TabIndex = 25;
            this.Remindercountmassage.Text = "You have [count] reminders for today.";
            // 
            // Reminders
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
            this.Controls.Add(this.RemindersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.Load += new System.EventHandler(this.Reminders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.RemindersPanel.ResumeLayout(false);
            this.RemindersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemindersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfileNav;
        private System.Windows.Forms.Label RemindersNav;
        private System.Windows.Forms.Label AllTasksNav;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Panel RemindersPanel;
        private System.Windows.Forms.Label Remindercountmassage;
        private System.Windows.Forms.DataGridView RemindersTable;
        private System.Windows.Forms.Label rəddolburdangetbuttonu;
    }
}