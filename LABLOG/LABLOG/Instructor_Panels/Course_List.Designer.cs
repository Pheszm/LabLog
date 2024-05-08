namespace LABLOG.Instructor_Panels
{
    partial class Course_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.course_list_btn = new System.Windows.Forms.Button();
            this.DownloadReports_btn = new System.Windows.Forms.Button();
            this.SubjectList_btn = new System.Windows.Forms.Button();
            this.StudentList_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
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
            this.course_list_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
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
            this.course_list_btn.TabIndex = 29;
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
            this.StudentList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DataGridView1);
            this.panel2.Location = new System.Drawing.Point(284, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 450);
            this.panel2.TabIndex = 70;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Title,
            this.Status});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
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
            this.DataGridView1.Size = new System.Drawing.Size(642, 450);
            this.DataGridView1.TabIndex = 64;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_btn.BackColor = System.Drawing.Color.White;
            this.edit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.edit_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_btn.Image = global::LABLOG.Properties.Resources.Settings_Logo;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(793, 622);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(133, 39);
            this.edit_btn.TabIndex = 71;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Visible = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.remove_btn.BackColor = System.Drawing.Color.White;
            this.remove_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.remove_btn.ForeColor = System.Drawing.Color.Black;
            this.remove_btn.Image = global::LABLOG.Properties.Resources.Remove_Logo;
            this.remove_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_btn.Location = new System.Drawing.Point(649, 622);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(133, 39);
            this.remove_btn.TabIndex = 70;
            this.remove_btn.Text = "Remove";
            this.remove_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Visible = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Image = global::LABLOG.Properties.Resources.Add_Logo;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(284, 622);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(133, 39);
            this.add_btn.TabIndex = 69;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(671, 637);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Select a row to Manage";
            // 
            // Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Course_List";
            this.Size = new System.Drawing.Size(945, 712);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button course_list_btn;
        private System.Windows.Forms.Button DownloadReports_btn;
        private System.Windows.Forms.Button SubjectList_btn;
        private System.Windows.Forms.Button StudentList_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
    }
}
