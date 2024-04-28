namespace LabLog.Panels
{
    partial class DownloadReportsPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownloadReportsButton = new System.Windows.Forms.Button();
            this.SubjectListButton = new System.Windows.Forms.Button();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DailyDownloadBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.IPadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNametable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurposeTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOutTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExactDateTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimePicker.CustomFormat = "dd/MM/yy";
            this.EndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(630, 127);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(103, 23);
            this.EndTimePicker.TabIndex = 29;
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.EndTimePicker_ValueChanged);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimePicker.CustomFormat = "dd/MM/yy";
            this.StartTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(465, 127);
            this.StartTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(103, 23);
            this.StartTimePicker.TabIndex = 28;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(595, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(421, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(551, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Range";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.DownloadReportsButton);
            this.panel1.Controls.Add(this.SubjectListButton);
            this.panel1.Controls.Add(this.StudentListButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 642);
            this.panel1.TabIndex = 31;
            // 
            // DownloadReportsButton
            // 
            this.DownloadReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.DownloadReportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.DownloadReportsButton.FlatAppearance.BorderSize = 0;
            this.DownloadReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DownloadReportsButton.ForeColor = System.Drawing.Color.White;
            this.DownloadReportsButton.Image = global::LabLog.Properties.Resources.Download_Logo;
            this.DownloadReportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadReportsButton.Location = new System.Drawing.Point(2, 268);
            this.DownloadReportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.DownloadReportsButton.Name = "DownloadReportsButton";
            this.DownloadReportsButton.Size = new System.Drawing.Size(195, 39);
            this.DownloadReportsButton.TabIndex = 25;
            this.DownloadReportsButton.Text = "Download Reports";
            this.DownloadReportsButton.UseVisualStyleBackColor = false;
            // 
            // SubjectListButton
            // 
            this.SubjectListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.SubjectListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.SubjectListButton.FlatAppearance.BorderSize = 0;
            this.SubjectListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SubjectListButton.ForeColor = System.Drawing.Color.White;
            this.SubjectListButton.Image = global::LabLog.Properties.Resources.Subject_Logo;
            this.SubjectListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectListButton.Location = new System.Drawing.Point(2, 229);
            this.SubjectListButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectListButton.Name = "SubjectListButton";
            this.SubjectListButton.Size = new System.Drawing.Size(195, 39);
            this.SubjectListButton.TabIndex = 24;
            this.SubjectListButton.Text = "Subject List";
            this.SubjectListButton.UseVisualStyleBackColor = false;
            this.SubjectListButton.Click += new System.EventHandler(this.SubjectListButton_Click);
            // 
            // StudentListButton
            // 
            this.StudentListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.StudentListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.StudentListButton.FlatAppearance.BorderSize = 0;
            this.StudentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.StudentListButton.ForeColor = System.Drawing.Color.White;
            this.StudentListButton.Image = global::LabLog.Properties.Resources.StudentsLogo;
            this.StudentListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentListButton.Location = new System.Drawing.Point(2, 190);
            this.StudentListButton.Margin = new System.Windows.Forms.Padding(2);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(195, 39);
            this.StudentListButton.TabIndex = 23;
            this.StudentListButton.Text = "Student List";
            this.StudentListButton.UseVisualStyleBackColor = false;
            this.StudentListButton.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::LabLog.Properties.Resources.Home_Logo;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(2, 151);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(195, 39);
            this.HomeButton.TabIndex = 22;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::LabLog.Properties.Resources.Logout_Icon__White;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(18, 16);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(101, 32);
            this.LogoutButton.TabIndex = 21;
            this.LogoutButton.Text = "Log-out";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DailyDownloadBtn
            // 
            this.DailyDownloadBtn.BackColor = System.Drawing.Color.White;
            this.DailyDownloadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.DailyDownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailyDownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DailyDownloadBtn.ForeColor = System.Drawing.Color.Black;
            this.DailyDownloadBtn.Image = global::LabLog.Properties.Resources.Download_Logo_Black;
            this.DailyDownloadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DailyDownloadBtn.Location = new System.Drawing.Point(536, 573);
            this.DailyDownloadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DailyDownloadBtn.Name = "DailyDownloadBtn";
            this.DailyDownloadBtn.Size = new System.Drawing.Size(110, 32);
            this.DailyDownloadBtn.TabIndex = 32;
            this.DailyDownloadBtn.Text = "Export";
            this.DailyDownloadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DailyDownloadBtn.UseVisualStyleBackColor = false;
            this.DailyDownloadBtn.Click += new System.EventHandler(this.DailyDownloadBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::LabLog.Properties.Resources.LabLog_Header;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(508, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 60);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPadd,
            this.FullNametable,
            this.IDtable,
            this.PurposeTable,
            this.ReasonTable,
            this.TimeInTable,
            this.TimeOutTable,
            this.ExactDateTable});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.Silver;
            this.DataGrid.Location = new System.Drawing.Point(214, 158);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.ShowCellToolTips = false;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.Size = new System.Drawing.Size(754, 396);
            this.DataGrid.TabIndex = 34;
            // 
            // IPadd
            // 
            this.IPadd.HeaderText = "IP Address";
            this.IPadd.Name = "IPadd";
            this.IPadd.ReadOnly = true;
            // 
            // FullNametable
            // 
            this.FullNametable.HeaderText = "Full Name";
            this.FullNametable.MinimumWidth = 6;
            this.FullNametable.Name = "FullNametable";
            this.FullNametable.ReadOnly = true;
            // 
            // IDtable
            // 
            this.IDtable.HeaderText = "ID";
            this.IDtable.MinimumWidth = 6;
            this.IDtable.Name = "IDtable";
            this.IDtable.ReadOnly = true;
            // 
            // PurposeTable
            // 
            this.PurposeTable.HeaderText = "Purpose";
            this.PurposeTable.Name = "PurposeTable";
            this.PurposeTable.ReadOnly = true;
            // 
            // ReasonTable
            // 
            this.ReasonTable.HeaderText = "Reason";
            this.ReasonTable.Name = "ReasonTable";
            this.ReasonTable.ReadOnly = true;
            // 
            // TimeInTable
            // 
            this.TimeInTable.HeaderText = "TimeIn";
            this.TimeInTable.Name = "TimeInTable";
            this.TimeInTable.ReadOnly = true;
            // 
            // TimeOutTable
            // 
            this.TimeOutTable.HeaderText = "TimeOut";
            this.TimeOutTable.Name = "TimeOutTable";
            this.TimeOutTable.ReadOnly = true;
            // 
            // ExactDateTable
            // 
            this.ExactDateTable.HeaderText = "ExactDate";
            this.ExactDateTable.Name = "ExactDateTable";
            this.ExactDateTable.ReadOnly = true;
            // 
            // DownloadReportsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DailyDownloadBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DownloadReportsPanel";
            this.Size = new System.Drawing.Size(987, 635);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DownloadReportsButton;
        private System.Windows.Forms.Button SubjectListButton;
        private System.Windows.Forms.Button StudentListButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DailyDownloadBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNametable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurposeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOutTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExactDateTable;
    }
}
