﻿namespace LabLog.Panels
{
    partial class StudentListPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.YearLevelComboBox = new System.Windows.Forms.ComboBox();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportListButton = new System.Windows.Forms.Button();
            this.ImportListButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DownloadReportsButton = new System.Windows.Forms.Button();
            this.SubjectListButton = new System.Windows.Forms.Button();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 3;
            // 
            // YearLevelComboBox
            // 
            this.YearLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearLevelComboBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevelComboBox.FormattingEnabled = true;
            this.YearLevelComboBox.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.YearLevelComboBox.Location = new System.Drawing.Point(254, 159);
            this.YearLevelComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.YearLevelComboBox.Name = "YearLevelComboBox";
            this.YearLevelComboBox.Size = new System.Drawing.Size(115, 28);
            this.YearLevelComboBox.TabIndex = 16;
            this.YearLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.YearLevelComboBox_SelectedIndexChanged);
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Items.AddRange(new object[] {
            "IT",
            "HM",
            "CRIM",
            "RVM-TTP",
            "BEED"});
            this.CourseComboBox.Location = new System.Drawing.Point(254, 198);
            this.CourseComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(115, 28);
            this.CourseComboBox.TabIndex = 15;
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentID,
            this.Course,
            this.Year});
            this.DataGrid.Location = new System.Drawing.Point(394, 127);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.ShowCellToolTips = false;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.Size = new System.Drawing.Size(521, 390);
            this.DataGrid.TabIndex = 14;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 8;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year-Level";
            this.Year.MinimumWidth = 8;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // ExportListButton
            // 
            this.ExportListButton.BackColor = System.Drawing.Color.White;
            this.ExportListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ExportListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportListButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportListButton.ForeColor = System.Drawing.Color.Black;
            this.ExportListButton.Image = global::LabLog.Properties.Resources.file_export;
            this.ExportListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportListButton.Location = new System.Drawing.Point(626, 530);
            this.ExportListButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportListButton.Name = "ExportListButton";
            this.ExportListButton.Size = new System.Drawing.Size(132, 32);
            this.ExportListButton.TabIndex = 28;
            this.ExportListButton.Text = "Export List";
            this.ExportListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportListButton.UseVisualStyleBackColor = false;
            // 
            // ImportListButton
            // 
            this.ImportListButton.BackColor = System.Drawing.Color.White;
            this.ImportListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ImportListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportListButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportListButton.ForeColor = System.Drawing.Color.Black;
            this.ImportListButton.Image = global::LabLog.Properties.Resources.file_import;
            this.ImportListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImportListButton.Location = new System.Drawing.Point(478, 530);
            this.ImportListButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportListButton.Name = "ImportListButton";
            this.ImportListButton.Size = new System.Drawing.Size(132, 32);
            this.ImportListButton.TabIndex = 27;
            this.ImportListButton.Text = "Import List";
            this.ImportListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImportListButton.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.White;
            this.Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Black;
            this.Edit.Image = global::LabLog.Properties.Resources.Edit_Logo;
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.Location = new System.Drawing.Point(269, 437);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 32);
            this.Edit.TabIndex = 26;
            this.Edit.Text = "Edit";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.Image = global::LabLog.Properties.Resources.Remove_Logo;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.Location = new System.Drawing.Point(269, 401);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 32);
            this.RemoveButton.TabIndex = 25;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Image = global::LabLog.Properties.Resources.Add_Logo;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(269, 365);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 32);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LabLog.Properties.Resources.LabLog_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(478, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 103);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DownloadReportsButton
            // 
            this.DownloadReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.DownloadReportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.DownloadReportsButton.FlatAppearance.BorderSize = 0;
            this.DownloadReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadReportsButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DownloadReportsButton.Click += new System.EventHandler(this.DownloadReportsButton_Click);
            // 
            // SubjectListButton
            // 
            this.SubjectListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.SubjectListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.SubjectListButton.FlatAppearance.BorderSize = 0;
            this.SubjectListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectListButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.StudentListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.StudentListButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.StudentListButton.FlatAppearance.BorderSize = 0;
            this.StudentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentListButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.LogoutButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // StudentListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ExportListButton);
            this.Controls.Add(this.ImportListButton);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.YearLevelComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "StudentListPanel";
            this.Size = new System.Drawing.Size(987, 635);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DownloadReportsButton;
        private System.Windows.Forms.Button SubjectListButton;
        private System.Windows.Forms.Button StudentListButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.ComboBox YearLevelComboBox;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ImportListButton;
        private System.Windows.Forms.Button ExportListButton;
    }
}
