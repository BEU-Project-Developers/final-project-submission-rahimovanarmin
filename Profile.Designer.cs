namespace TaskSchudler
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
            this.IncompletedPanel = new System.Windows.Forms.Panel();
            this.CountofIncompleted = new System.Windows.Forms.Label();
            this.UncompletedTasks = new System.Windows.Forms.Label();
            this.CompletedPanel = new System.Windows.Forms.Panel();
            this.Countofcompleted = new System.Windows.Forms.Label();
            this.CompletedTasks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileTable)).BeginInit();
            this.IncompletedPanel.SuspendLayout();
            this.CompletedPanel.SuspendLayout();
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
            this.ProfilePanel.Controls.Add(this.EscapeButtonu);
            this.ProfilePanel.Controls.Add(this.Next7daystasks);
            this.ProfilePanel.Controls.Add(this.ProfileTable);
            this.ProfilePanel.Controls.Add(this.IncompletedPanel);
            this.ProfilePanel.Controls.Add(this.CompletedPanel);
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
            this.ProfileTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProfileTable_CellFormatting);
            // 
            // IncompletedPanel
            // 
            this.IncompletedPanel.BackColor = System.Drawing.Color.White;
            this.IncompletedPanel.Controls.Add(this.CountofIncompleted);
            this.IncompletedPanel.Controls.Add(this.UncompletedTasks);
            this.IncompletedPanel.ForeColor = System.Drawing.Color.Coral;
            this.IncompletedPanel.Location = new System.Drawing.Point(465, 113);
            this.IncompletedPanel.Name = "IncompletedPanel";
            this.IncompletedPanel.Size = new System.Drawing.Size(317, 172);
            this.IncompletedPanel.TabIndex = 2;
            // 
            // CountofIncompleted
            // 
            this.CountofIncompleted.AutoSize = true;
            this.CountofIncompleted.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.CountofIncompleted.ForeColor = System.Drawing.Color.Black;
            this.CountofIncompleted.Location = new System.Drawing.Point(57, 74);
            this.CountofIncompleted.Name = "CountofIncompleted";
            this.CountofIncompleted.Size = new System.Drawing.Size(214, 61);
            this.CountofIncompleted.TabIndex = 26;
            this.CountofIncompleted.Text = "[Count]";
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
            // CompletedPanel
            // 
            this.CompletedPanel.BackColor = System.Drawing.Color.White;
            this.CompletedPanel.Controls.Add(this.Countofcompleted);
            this.CompletedPanel.Controls.Add(this.CompletedTasks);
            this.CompletedPanel.ForeColor = System.Drawing.Color.Coral;
            this.CompletedPanel.Location = new System.Drawing.Point(63, 113);
            this.CompletedPanel.Name = "CompletedPanel";
            this.CompletedPanel.Size = new System.Drawing.Size(317, 172);
            this.CompletedPanel.TabIndex = 1;
            // 
            // Countofcompleted
            // 
            this.Countofcompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Countofcompleted.AutoSize = true;
            this.Countofcompleted.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.Countofcompleted.ForeColor = System.Drawing.Color.Black;
            this.Countofcompleted.Location = new System.Drawing.Point(62, 74);
            this.Countofcompleted.Name = "Countofcompleted";
            this.Countofcompleted.Size = new System.Drawing.Size(214, 61);
            this.Countofcompleted.TabIndex = 25;
            this.Countofcompleted.Text = "[Count]";
            this.Countofcompleted.Click += new System.EventHandler(this.Countofcompleted_Click);
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
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ProfilePanel.ResumeLayout(false);
            this.ProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileTable)).EndInit();
            this.IncompletedPanel.ResumeLayout(false);
            this.IncompletedPanel.PerformLayout();
            this.CompletedPanel.ResumeLayout(false);
            this.CompletedPanel.PerformLayout();
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
        private System.Windows.Forms.Panel IncompletedPanel;
        private System.Windows.Forms.Label CountofIncompleted;
        private System.Windows.Forms.Label UncompletedTasks;
        private System.Windows.Forms.Panel CompletedPanel;
        private System.Windows.Forms.Label Countofcompleted;
        private System.Windows.Forms.Label CompletedTasks;
        private System.Windows.Forms.Label EscapeButtonu;
    }
}