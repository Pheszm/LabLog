namespace LabLog.Panels
{
    partial class IntroductionPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstructorLogin = new System.Windows.Forms.Button();
            this.StudentLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LabLog.Properties.Resources.LabLog_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(424, 137);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 182);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorLogin
            // 
            this.InstructorLogin.BackColor = System.Drawing.Color.White;
            this.InstructorLogin.FlatAppearance.BorderSize = 0;
            this.InstructorLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.InstructorLogin.ForeColor = System.Drawing.Color.Black;
            this.InstructorLogin.Image = global::LabLog.Properties.Resources.Settings_Logo;
            this.InstructorLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructorLogin.Location = new System.Drawing.Point(607, 568);
            this.InstructorLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstructorLogin.Name = "InstructorLogin";
            this.InstructorLogin.Size = new System.Drawing.Size(134, 39);
            this.InstructorLogin.TabIndex = 3;
            this.InstructorLogin.Text = "MANAGE";
            this.InstructorLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InstructorLogin.UseVisualStyleBackColor = false;
            this.InstructorLogin.Click += new System.EventHandler(this.InstructorLogin_Click);
            // 
            // StudentLogin
            // 
            this.StudentLogin.BackColor = System.Drawing.Color.White;
            this.StudentLogin.FlatAppearance.BorderSize = 0;
            this.StudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLogin.ForeColor = System.Drawing.Color.Black;
            this.StudentLogin.Image = global::LabLog.Properties.Resources.Person_Logo;
            this.StudentLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentLogin.Location = new System.Drawing.Point(614, 505);
            this.StudentLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(118, 39);
            this.StudentLogin.TabIndex = 2;
            this.StudentLogin.Text = "LOG-IN";
            this.StudentLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentLogin.UseVisualStyleBackColor = false;
            this.StudentLogin.Click += new System.EventHandler(this.StudentLogin_Click);
            // 
            // IntroductionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.BackgroundImage = global::LabLog.Properties.Resources.Introduction_Wallaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InstructorLogin);
            this.Controls.Add(this.StudentLogin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IntroductionPanel";
            this.Size = new System.Drawing.Size(1316, 782);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstructorLogin;
        private System.Windows.Forms.Button StudentLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
