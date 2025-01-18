namespace TaskSchudler
{
    partial class All_Tasks
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
            System.Windows.Forms.Label TaskTitle;
            System.Windows.Forms.Label ReminderDate;
            System.Windows.Forms.Label DueDAte;
            System.Windows.Forms.Label Inportance;
            System.Windows.Forms.Label Status;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Tasks));
            this.AllTasksPanel = new System.Windows.Forms.Panel();
            this.EscapeButton = new System.Windows.Forms.Label();
            this.AlltasksTable = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.StatusCombo = new System.Windows.Forms.ComboBox();
            this.ImportanceCombo = new System.Windows.Forms.ComboBox();
            this.DueDateInput = new System.Windows.Forms.DateTimePicker();
            this.RemiderDateInput = new System.Windows.Forms.DateTimePicker();
            this.taskTitleInput = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Logolabel = new System.Windows.Forms.Label();
            this.AllTasksNav = new System.Windows.Forms.Label();
            this.RemindersNav = new System.Windows.Forms.Label();
            this.ProfileNav = new System.Windows.Forms.Label();
            TaskTitle = new System.Windows.Forms.Label();
            ReminderDate = new System.Windows.Forms.Label();
            DueDAte = new System.Windows.Forms.Label();
            Inportance = new System.Windows.Forms.Label();
            Status = new System.Windows.Forms.Label();
            this.AllTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlltasksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskTitle
            // 
            TaskTitle.AutoSize = true;
            TaskTitle.Font = new System.Drawing.Font("Century Gothic", 12F);
            TaskTitle.ForeColor = System.Drawing.Color.White;
            TaskTitle.Location = new System.Drawing.Point(23, 63);
            TaskTitle.Name = "TaskTitle";
            TaskTitle.Size = new System.Drawing.Size(97, 23);
            TaskTitle.TabIndex = 12;
            TaskTitle.Text = "Task Title:";
            // 
            // ReminderDate
            // 
            ReminderDate.AutoSize = true;
            ReminderDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            ReminderDate.ForeColor = System.Drawing.Color.White;
            ReminderDate.Location = new System.Drawing.Point(563, 63);
            ReminderDate.Name = "ReminderDate";
            ReminderDate.Size = new System.Drawing.Size(162, 23);
            ReminderDate.TabIndex = 15;
            ReminderDate.Text = "Reminder Date:";
            // 
            // DueDAte
            // 
            DueDAte.AutoSize = true;
            DueDAte.Font = new System.Drawing.Font("Century Gothic", 12F);
            DueDAte.ForeColor = System.Drawing.Color.White;
            DueDAte.Location = new System.Drawing.Point(563, 156);
            DueDAte.Name = "DueDAte";
            DueDAte.Size = new System.Drawing.Size(110, 23);
            DueDAte.TabIndex = 17;
            DueDAte.Text = "Due Date:";
            // 
            // Inportance
            // 
            Inportance.AutoSize = true;
            Inportance.Font = new System.Drawing.Font("Century Gothic", 12F);
            Inportance.ForeColor = System.Drawing.Color.White;
            Inportance.Location = new System.Drawing.Point(23, 156);
            Inportance.Name = "Inportance";
            Inportance.Size = new System.Drawing.Size(131, 23);
            Inportance.TabIndex = 18;
            Inportance.Text = "Importance:";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new System.Drawing.Font("Century Gothic", 12F);
            Status.ForeColor = System.Drawing.Color.White;
            Status.Location = new System.Drawing.Point(282, 156);
            Status.Name = "Status";
            Status.Size = new System.Drawing.Size(73, 23);
            Status.TabIndex = 20;
            Status.Text = "Status:";
            // 
            // AllTasksPanel
            // 
            this.AllTasksPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.AllTasksPanel.Controls.Add(this.EscapeButton);
            this.AllTasksPanel.Controls.Add(this.AlltasksTable);
            this.AllTasksPanel.Controls.Add(this.DeleteButton);
            this.AllTasksPanel.Controls.Add(this.Edit);
            this.AllTasksPanel.Controls.Add(this.AddButton);
            this.AllTasksPanel.Controls.Add(this.StatusCombo);
            this.AllTasksPanel.Controls.Add(Status);
            this.AllTasksPanel.Controls.Add(this.ImportanceCombo);
            this.AllTasksPanel.Controls.Add(Inportance);
            this.AllTasksPanel.Controls.Add(DueDAte);
            this.AllTasksPanel.Controls.Add(this.DueDateInput);
            this.AllTasksPanel.Controls.Add(ReminderDate);
            this.AllTasksPanel.Controls.Add(this.RemiderDateInput);
            this.AllTasksPanel.Controls.Add(this.taskTitleInput);
            this.AllTasksPanel.Controls.Add(TaskTitle);
            this.AllTasksPanel.Location = new System.Drawing.Point(260, 0);
            this.AllTasksPanel.Name = "AllTasksPanel";
            this.AllTasksPanel.Size = new System.Drawing.Size(851, 714);
            this.AllTasksPanel.TabIndex = 0;
            this.AllTasksPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AllTasksPanel_Paint);
            // 
            // EscapeButton
            // 
            this.EscapeButton.AutoSize = true;
            this.EscapeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.EscapeButton.ForeColor = System.Drawing.Color.White;
            this.EscapeButton.Location = new System.Drawing.Point(815, 9);
            this.EscapeButton.Name = "EscapeButton";
            this.EscapeButton.Size = new System.Drawing.Size(24, 23);
            this.EscapeButton.TabIndex = 26;
            this.EscapeButton.Text = "X";
            this.EscapeButton.Click += new System.EventHandler(this.EscapeButton_Click);
            // 
            // AlltasksTable
            // 
            this.AlltasksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlltasksTable.Location = new System.Drawing.Point(0, 317);
            this.AlltasksTable.Name = "AlltasksTable";
            this.AlltasksTable.RowHeadersWidth = 51;
            this.AlltasksTable.RowTemplate.Height = 24;
            this.AlltasksTable.Size = new System.Drawing.Size(851, 397);
            this.AlltasksTable.TabIndex = 25;
            this.AlltasksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AlltasksTable_CellClick);
            this.AlltasksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.AlltasksTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AlltasksTable_CellFormatting);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(77)))), ((int)(((byte)(7)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(534, 253);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 40);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(77)))), ((int)(((byte)(7)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(370, 253);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(128, 40);
            this.Edit.TabIndex = 23;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(77)))), ((int)(((byte)(7)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(194, 253);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 40);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StatusCombo
            // 
            this.StatusCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.Items.AddRange(new object[] {
            "Completed",
            "Incompleted",
            "Pending"});
            this.StatusCombo.Location = new System.Drawing.Point(286, 188);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(161, 31);
            this.StatusCombo.TabIndex = 21;
            // 
            // ImportanceCombo
            // 
            this.ImportanceCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ImportanceCombo.FormattingEnabled = true;
            this.ImportanceCombo.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.ImportanceCombo.Location = new System.Drawing.Point(27, 191);
            this.ImportanceCombo.Name = "ImportanceCombo";
            this.ImportanceCombo.Size = new System.Drawing.Size(161, 31);
            this.ImportanceCombo.TabIndex = 19;
            // 
            // DueDateInput
            // 
            this.DueDateInput.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.DueDateInput.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DueDateInput.Location = new System.Drawing.Point(567, 191);
            this.DueDateInput.Name = "DueDateInput";
            this.DueDateInput.Size = new System.Drawing.Size(200, 28);
            this.DueDateInput.TabIndex = 16;
            // 
            // RemiderDateInput
            // 
            this.RemiderDateInput.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.RemiderDateInput.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RemiderDateInput.Location = new System.Drawing.Point(567, 99);
            this.RemiderDateInput.Name = "RemiderDateInput";
            this.RemiderDateInput.Size = new System.Drawing.Size(200, 28);
            this.RemiderDateInput.TabIndex = 14;
            // 
            // taskTitleInput
            // 
            this.taskTitleInput.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.taskTitleInput.Location = new System.Drawing.Point(27, 89);
            this.taskTitleInput.Multiline = true;
            this.taskTitleInput.Name = "taskTitleInput";
            this.taskTitleInput.Size = new System.Drawing.Size(397, 38);
            this.taskTitleInput.TabIndex = 13;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(91, 63);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // Logolabel
            // 
            this.Logolabel.AutoSize = true;
            this.Logolabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.Logolabel.ForeColor = System.Drawing.Color.White;
            this.Logolabel.Location = new System.Drawing.Point(45, 156);
            this.Logolabel.Name = "Logolabel";
            this.Logolabel.Size = new System.Drawing.Size(179, 29);
            this.Logolabel.TabIndex = 7;
            this.Logolabel.Text = "Task Schudler";
            // 
            // AllTasksNav
            // 
            this.AllTasksNav.AutoSize = true;
            this.AllTasksNav.BackColor = System.Drawing.Color.Transparent;
            this.AllTasksNav.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTasksNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.AllTasksNav.Location = new System.Drawing.Point(83, 225);
            this.AllTasksNav.Name = "AllTasksNav";
            this.AllTasksNav.Size = new System.Drawing.Size(90, 23);
            this.AllTasksNav.TabIndex = 9;
            this.AllTasksNav.Text = "All tasks";
            // 
            // RemindersNav
            // 
            this.RemindersNav.AutoSize = true;
            this.RemindersNav.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.RemindersNav.ForeColor = System.Drawing.Color.White;
            this.RemindersNav.Location = new System.Drawing.Point(83, 262);
            this.RemindersNav.Name = "RemindersNav";
            this.RemindersNav.Size = new System.Drawing.Size(110, 23);
            this.RemindersNav.TabIndex = 10;
            this.RemindersNav.Text = "Reminders";
            this.RemindersNav.Click += new System.EventHandler(this.RemindersNav_Click);
            // 
            // ProfileNav
            // 
            this.ProfileNav.AutoSize = true;
            this.ProfileNav.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ProfileNav.ForeColor = System.Drawing.Color.White;
            this.ProfileNav.Location = new System.Drawing.Point(83, 298);
            this.ProfileNav.Name = "ProfileNav";
            this.ProfileNav.Size = new System.Drawing.Size(68, 23);
            this.ProfileNav.TabIndex = 11;
            this.ProfileNav.Text = "Profile";
            this.ProfileNav.Click += new System.EventHandler(this.ProfileNav_Click);
            // 
            // All_Tasks
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
            this.Controls.Add(this.AllTasksPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "All_Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Tasks";
            this.AllTasksPanel.ResumeLayout(false);
            this.AllTasksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlltasksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AllTasksPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Label AllTasksNav;
        private System.Windows.Forms.Label RemindersNav;
        private System.Windows.Forms.Label ProfileNav;
        private System.Windows.Forms.TextBox taskTitleInput;
        private System.Windows.Forms.ComboBox ImportanceCombo;
        private System.Windows.Forms.DateTimePicker DueDateInput;
        private System.Windows.Forms.DateTimePicker RemiderDateInput;
        private System.Windows.Forms.DataGridView AlltasksTable;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox StatusCombo;
        private System.Windows.Forms.Label EscapeButton;


    }
}