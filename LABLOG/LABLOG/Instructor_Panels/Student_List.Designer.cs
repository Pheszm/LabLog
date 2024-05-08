namespace LABLOG.Instructor_Panels
{
    partial class Student_List
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.course_list_btn = new System.Windows.Forms.Button();
            this.DownloadReports_btn = new System.Windows.Forms.Button();
            this.SubjectList_btn = new System.Windows.Forms.Button();
            this.StudentList_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.Yearcbox = new System.Windows.Forms.ComboBox();
            this.Gendercbox = new System.Windows.Forms.ComboBox();
            this.Coursecbx = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.StuNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuCourseTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuYearLevelTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuGenderTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.course_list_btn);
            this.panel1.Controls.Add(this.DownloadReports_btn);
            this.panel1.Controls.Add(this.SubjectList_btn);
            this.panel1.Controls.Add(this.StudentList_btn);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 712);
            this.panel1.TabIndex = 5;
            // 
            // course_list_btn
            // 
            this.course_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.course_list_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.course_list_btn.FlatAppearance.BorderSize = 0;
            this.course_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.course_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.course_list_btn.ForeColor = System.Drawing.Color.White;
            this.course_list_btn.Image = global::LABLOG.Properties.Resources.Subject_Logo;
            this.course_list_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.course_list_btn.Location = new System.Drawing.Point(3, 415);
            this.course_list_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.course_list_btn.Name = "course_list_btn";
            this.course_list_btn.Size = new System.Drawing.Size(260, 48);
            this.course_list_btn.TabIndex = 26;
            this.course_list_btn.Text = "Course List";
            this.course_list_btn.UseVisualStyleBackColor = false;
            this.course_list_btn.Click += new System.EventHandler(this.course_list_btn_Click);
            // 
            // DownloadReports_btn
            // 
            this.DownloadReports_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.DownloadReports_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.DownloadReports_btn.FlatAppearance.BorderSize = 0;
            this.DownloadReports_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadReports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.DownloadReports_btn.ForeColor = System.Drawing.Color.White;
            this.DownloadReports_btn.Image = global::LABLOG.Properties.Resources.Download_Logo;
            this.DownloadReports_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadReports_btn.Location = new System.Drawing.Point(3, 467);
            this.DownloadReports_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownloadReports_btn.Name = "DownloadReports_btn";
            this.DownloadReports_btn.Size = new System.Drawing.Size(260, 48);
            this.DownloadReports_btn.TabIndex = 25;
            this.DownloadReports_btn.Text = "Download Reports";
            this.DownloadReports_btn.UseVisualStyleBackColor = false;
            this.DownloadReports_btn.Click += new System.EventHandler(this.DownloadReports_btn_Click);
            // 
            // SubjectList_btn
            // 
            this.SubjectList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.SubjectList_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.SubjectList_btn.FlatAppearance.BorderSize = 0;
            this.SubjectList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SubjectList_btn.ForeColor = System.Drawing.Color.White;
            this.SubjectList_btn.Image = global::LABLOG.Properties.Resources.Subject_Logo;
            this.SubjectList_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectList_btn.Location = new System.Drawing.Point(3, 363);
            this.SubjectList_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectList_btn.Name = "SubjectList_btn";
            this.SubjectList_btn.Size = new System.Drawing.Size(260, 48);
            this.SubjectList_btn.TabIndex = 24;
            this.SubjectList_btn.Text = "Subject List";
            this.SubjectList_btn.UseVisualStyleBackColor = false;
            this.SubjectList_btn.Click += new System.EventHandler(this.SubjectList_btn_Click);
            // 
            // StudentList_btn
            // 
            this.StudentList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
            this.StudentList_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.StudentList_btn.FlatAppearance.BorderSize = 0;
            this.StudentList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.StudentList_btn.ForeColor = System.Drawing.Color.White;
            this.StudentList_btn.Image = global::LABLOG.Properties.Resources.StudentsLogo;
            this.StudentList_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentList_btn.Location = new System.Drawing.Point(3, 315);
            this.StudentList_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentList_btn.Name = "StudentList_btn";
            this.StudentList_btn.Size = new System.Drawing.Size(260, 48);
            this.StudentList_btn.TabIndex = 23;
            this.StudentList_btn.Text = "Student List";
            this.StudentList_btn.UseVisualStyleBackColor = false;
            this.StudentList_btn.Click += new System.EventHandler(this.StudentList_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.Home_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.Home_btn.FlatAppearance.BorderSize = 0;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Home_btn.ForeColor = System.Drawing.Color.White;
            this.Home_btn.Image = global::LABLOG.Properties.Resources.Home_Logo;
            this.Home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_btn.Location = new System.Drawing.Point(3, 267);
            this.Home_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(260, 48);
            this.Home_btn.TabIndex = 22;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = false;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::LABLOG.Properties.Resources.Logout_Icon__White;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(24, 20);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(135, 39);
            this.LogoutButton.TabIndex = 21;
            this.LogoutButton.Text = "Log-out";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(28, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Select Year:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(175, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Select Gender:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(340, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Select Course:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_btn
            // 
            this.reset_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset_btn.BackColor = System.Drawing.Color.White;
            this.reset_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Location = new System.Drawing.Point(492, 41);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(138, 26);
            this.reset_btn.TabIndex = 41;
            this.reset_btn.Text = "Reset Filter";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Visible = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Yearcbox
            // 
            this.Yearcbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yearcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Yearcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearcbox.FormattingEnabled = true;
            this.Yearcbox.Items.AddRange(new object[] {
            "none",
            "1",
            "2",
            "3",
            "4"});
            this.Yearcbox.Location = new System.Drawing.Point(5, 38);
            this.Yearcbox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Yearcbox.Name = "Yearcbox";
            this.Yearcbox.Size = new System.Drawing.Size(147, 32);
            this.Yearcbox.TabIndex = 36;
            this.Yearcbox.SelectedIndexChanged += new System.EventHandler(this.Yearcbox_SelectedIndexChanged);
            // 
            // Gendercbox
            // 
            this.Gendercbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gendercbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gendercbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendercbox.FormattingEnabled = true;
            this.Gendercbox.Items.AddRange(new object[] {
            "none",
            "Male",
            "Female"});
            this.Gendercbox.Location = new System.Drawing.Point(163, 38);
            this.Gendercbox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Gendercbox.Name = "Gendercbox";
            this.Gendercbox.Size = new System.Drawing.Size(147, 32);
            this.Gendercbox.TabIndex = 39;
            this.Gendercbox.SelectedIndexChanged += new System.EventHandler(this.Gendercbox_SelectedIndexChanged);
            // 
            // Coursecbx
            // 
            this.Coursecbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coursecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coursecbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursecbx.FormattingEnabled = true;
            this.Coursecbx.Items.AddRange(new object[] {
            "none"});
            this.Coursecbx.Location = new System.Drawing.Point(325, 38);
            this.Coursecbx.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Coursecbx.Name = "Coursecbx";
            this.Coursecbx.Size = new System.Drawing.Size(152, 32);
            this.Coursecbx.TabIndex = 35;
            this.Coursecbx.SelectedIndexChanged += new System.EventHandler(this.Coursecbx_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.99187F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25203F));
            this.tableLayoutPanel2.Controls.Add(this.Coursecbx, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Gendercbox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Yearcbox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.reset_btn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(286, 119);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 71);
            this.tableLayoutPanel2.TabIndex = 60;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuNameTable,
            this.StuIDTable,
            this.StuCourseTable,
            this.StuYearLevelTable,
            this.StuGenderTable,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.Silver;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.ShowCellToolTips = false;
            this.DataGridView1.ShowEditingIcon = false;
            this.DataGridView1.Size = new System.Drawing.Size(636, 416);
            this.DataGridView1.TabIndex = 30;
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
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DataGridView1);
            this.panel2.Location = new System.Drawing.Point(286, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 416);
            this.panel2.TabIndex = 62;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.BackColor = System.Drawing.Color.White;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Image = global::LABLOG.Properties.Resources.Settings_Logo;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(775, 647);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(133, 39);
            this.EditButton.TabIndex = 65;
            this.EditButton.Text = "Edit";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.RemoveButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveButton.Image = global::LABLOG.Properties.Resources.Remove_Logo;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.Location = new System.Drawing.Point(631, 647);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(133, 39);
            this.RemoveButton.TabIndex = 64;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_btn.BackColor = System.Drawing.Color.White;
            this.Add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.Image = global::LABLOG.Properties.Resources.Add_Logo;
            this.Add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_btn.Location = new System.Drawing.Point(307, 647);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(133, 39);
            this.Add_btn.TabIndex = 63;
            this.Add_btn.Text = "Add";
            this.Add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::LABLOG.Properties.Resources.LabLog_Header;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(503, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 86);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(655, 662);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Select a row to Manage";
            // 
            // Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "Student_List";
            this.Size = new System.Drawing.Size(945, 712);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DownloadReports_btn;
        private System.Windows.Forms.Button SubjectList_btn;
        private System.Windows.Forms.Button StudentList_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.ComboBox Yearcbox;
        private System.Windows.Forms.ComboBox Gendercbox;
        private System.Windows.Forms.ComboBox Coursecbx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNameTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuIDTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuCourseTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuYearLevelTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuGenderTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button course_list_btn;
        private System.Windows.Forms.Label label1;
    }
}
