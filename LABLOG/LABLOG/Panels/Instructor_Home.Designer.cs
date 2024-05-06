namespace LABLOG.Panels
{
    partial class Instructor_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.course_list_btn = new System.Windows.Forms.Button();
            this.DownloadReports_btn = new System.Windows.Forms.Button();
            this.SubjectList_btn = new System.Windows.Forms.Button();
            this.StudentList_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(346, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 68);
            this.label3.TabIndex = 26;
            this.label3.Text = "Instructors Menu";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(365, 363);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 65);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hello {Name}!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LABLOG.Properties.Resources.LabLog_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(421, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 153);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.Home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(67)))));
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
            // Instructor_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Instructor_Home";
            this.Size = new System.Drawing.Size(945, 712);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button course_list_btn;
    }
}
