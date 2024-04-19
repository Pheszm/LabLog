namespace LabLog.Panels
{
    partial class LogbookAreaForStudent
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
            this.label3 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.OthersPanel = new System.Windows.Forms.Panel();
            this.Reasonn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Purpose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WhosLogin = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OthersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(513, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 55);
            this.label3.TabIndex = 33;
            this.label3.Text = "STUDENT LOG";
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.Color.White;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(571, 186);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(289, 29);
            this.StudentID.TabIndex = 29;
            this.StudentID.Tag = "";
            // 
            // OthersPanel
            // 
            this.OthersPanel.BackColor = System.Drawing.Color.Transparent;
            this.OthersPanel.Controls.Add(this.Reasonn);
            this.OthersPanel.Controls.Add(this.label4);
            this.OthersPanel.Location = new System.Drawing.Point(468, 275);
            this.OthersPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OthersPanel.Name = "OthersPanel";
            this.OthersPanel.Size = new System.Drawing.Size(456, 203);
            this.OthersPanel.TabIndex = 32;
            this.OthersPanel.Visible = false;
            // 
            // Reasonn
            // 
            this.Reasonn.BackColor = System.Drawing.Color.White;
            this.Reasonn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Reasonn.Location = new System.Drawing.Point(103, 16);
            this.Reasonn.Multiline = true;
            this.Reasonn.Name = "Reasonn";
            this.Reasonn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reasonn.Size = new System.Drawing.Size(298, 164);
            this.Reasonn.TabIndex = 16;
            this.Reasonn.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reason:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Image = global::LabLog.Properties.Resources.Person_Logo;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(644, 488);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(86, 39);
            this.LoginButton.TabIndex = 34;
            this.LoginButton.Text = "Log-In";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Purpose
            // 
            this.Purpose.BackColor = System.Drawing.Color.White;
            this.Purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purpose.FormattingEnabled = true;
            this.Purpose.Items.AddRange(new object[] {
            "Others"});
            this.Purpose.Location = new System.Drawing.Point(571, 234);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(218, 28);
            this.Purpose.TabIndex = 28;
            this.Purpose.SelectedIndexChanged += new System.EventHandler(this.Purpose_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(481, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Purpose:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(467, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Student ID:";
            // 
            // WhosLogin
            // 
            this.WhosLogin.BackColor = System.Drawing.Color.White;
            this.WhosLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhosLogin.FormattingEnabled = true;
            this.WhosLogin.Items.AddRange(new object[] {
            "Staff",
            "Student"});
            this.WhosLogin.Location = new System.Drawing.Point(422, 35);
            this.WhosLogin.Name = "WhosLogin";
            this.WhosLogin.Size = new System.Drawing.Size(106, 28);
            this.WhosLogin.TabIndex = 35;
            this.WhosLogin.SelectedIndexChanged += new System.EventHandler(this.WhosLogin_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 642);
            this.panel1.TabIndex = 36;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Image = global::LabLog.Properties.Resources.Return_Logo_White;
            this.ReturnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnButton.Location = new System.Drawing.Point(18, 16);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(86, 32);
            this.ReturnButton.TabIndex = 21;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LabLog.Properties.Resources.LabLog_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 148);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // LogbookAreaForStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WhosLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.OthersPanel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogbookAreaForStudent";
            this.Size = new System.Drawing.Size(987, 635);
            this.OthersPanel.ResumeLayout(false);
            this.OthersPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Panel OthersPanel;
        private System.Windows.Forms.TextBox Reasonn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ComboBox Purpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WhosLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
