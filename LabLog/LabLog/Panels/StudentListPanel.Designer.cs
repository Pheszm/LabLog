namespace LabLog.Panels
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownloadReportsButton = new System.Windows.Forms.Button();
            this.SubjectListButton = new System.Windows.Forms.Button();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.YearLevelComboBox = new System.Windows.Forms.ComboBox();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.StuNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuCourseTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuYearLevelTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuGenderTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.ResetFilterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
            // DownloadReportsButton
            // 
            this.DownloadReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
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
            this.DownloadReportsButton.Click += new System.EventHandler(this.DownloadReportsButton_Click);
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
            this.StudentListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
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
            // YearLevelComboBox
            // 
            this.YearLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearLevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLevelComboBox.FormattingEnabled = true;
            this.YearLevelComboBox.Items.AddRange(new object[] {
            "none",
            "1",
            "2",
            "3",
            "4"});
            this.YearLevelComboBox.Location = new System.Drawing.Point(250, 118);
            this.YearLevelComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.YearLevelComboBox.Name = "YearLevelComboBox";
            this.YearLevelComboBox.Size = new System.Drawing.Size(115, 26);
            this.YearLevelComboBox.TabIndex = 16;
            this.YearLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.YearLevelComboBox_SelectedIndexChanged);
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Items.AddRange(new object[] {
            "none"});
            this.CourseComboBox.Location = new System.Drawing.Point(461, 118);
            this.CourseComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(115, 26);
            this.CourseComboBox.TabIndex = 15;
            this.CourseComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseComboBox_SelectedIndexChanged);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Image = global::LabLog.Properties.Resources.Edit_Logo;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(768, 566);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 32);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "Edit";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.Image = global::LabLog.Properties.Resources.Remove_Logo;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.Location = new System.Drawing.Point(660, 566);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 32);
            this.RemoveButton.TabIndex = 25;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Visible = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Image = global::LabLog.Properties.Resources.Add_Logo;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(329, 566);
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
            this.pictureBox1.Location = new System.Drawing.Point(508, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 60);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuNameTable,
            this.StuIDTable,
            this.StuCourseTable,
            this.StuYearLevelTable,
            this.StuGenderTable});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.Silver;
            this.DataGridView1.Location = new System.Drawing.Point(215, 158);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.ShowCellToolTips = false;
            this.DataGridView1.ShowEditingIcon = false;
            this.DataGridView1.Size = new System.Drawing.Size(754, 396);
            this.DataGridView1.TabIndex = 29;
            // 
            // StuNameTable
            // 
            this.StuNameTable.HeaderText = "Name";
            this.StuNameTable.MinimumWidth = 6;
            this.StuNameTable.Name = "StuNameTable";
            this.StuNameTable.ReadOnly = true;
            // 
            // StuIDTable
            // 
            this.StuIDTable.HeaderText = "StudentID";
            this.StuIDTable.MinimumWidth = 6;
            this.StuIDTable.Name = "StuIDTable";
            this.StuIDTable.ReadOnly = true;
            // 
            // StuCourseTable
            // 
            this.StuCourseTable.HeaderText = "Course";
            this.StuCourseTable.MinimumWidth = 6;
            this.StuCourseTable.Name = "StuCourseTable";
            this.StuCourseTable.ReadOnly = true;
            // 
            // StuYearLevelTable
            // 
            this.StuYearLevelTable.HeaderText = "Year-Level";
            this.StuYearLevelTable.MinimumWidth = 6;
            this.StuYearLevelTable.Name = "StuYearLevelTable";
            this.StuYearLevelTable.ReadOnly = true;
            // 
            // StuGenderTable
            // 
            this.StuGenderTable.HeaderText = "Sex";
            this.StuGenderTable.MinimumWidth = 6;
            this.StuGenderTable.Name = "StuGenderTable";
            this.StuGenderTable.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(458, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select Course:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(248, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(680, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Select Gender:";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "none",
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(683, 118);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(115, 26);
            this.GenderComboBox.TabIndex = 32;
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
            // 
            // ResetFilterButton
            // 
            this.ResetFilterButton.BackColor = System.Drawing.Color.White;
            this.ResetFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ResetFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFilterButton.ForeColor = System.Drawing.Color.Black;
            this.ResetFilterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetFilterButton.Location = new System.Drawing.Point(868, 119);
            this.ResetFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetFilterButton.Name = "ResetFilterButton";
            this.ResetFilterButton.Size = new System.Drawing.Size(86, 23);
            this.ResetFilterButton.TabIndex = 34;
            this.ResetFilterButton.Text = "Reset Filter";
            this.ResetFilterButton.UseVisualStyleBackColor = false;
            this.ResetFilterButton.Visible = false;
            this.ResetFilterButton.Click += new System.EventHandler(this.ResetFilterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(672, 573);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Select a row to Manage";
            // 
            // StudentListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResetFilterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.YearLevelComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "StudentListPanel";
            this.Size = new System.Drawing.Size(987, 635);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Button ResetFilterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNameTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuIDTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuCourseTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuYearLevelTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuGenderTable;
        private System.Windows.Forms.Label label4;
    }
}
