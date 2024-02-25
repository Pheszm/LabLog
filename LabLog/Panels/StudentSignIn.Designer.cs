namespace LabLog.Panels
{
    partial class StudentSignIn
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.Purpose = new System.Windows.Forms.ComboBox();
            this.OthersPanel = new System.Windows.Forms.Panel();
            this.Reasonn = new System.Windows.Forms.TextBox();
            this.Timeout = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Ste = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OthersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 642);
            this.panel1.TabIndex = 0;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.Color.White;
            this.StudentID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(603, 136);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(289, 29);
            this.StudentID.TabIndex = 15;
            this.StudentID.Tag = "";
            // 
            // Purpose
            // 
            this.Purpose.BackColor = System.Drawing.Color.White;
            this.Purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Purpose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purpose.FormattingEnabled = true;
            this.Purpose.Items.AddRange(new object[] {
            "Available Subject",
            "Others"});
            this.Purpose.Location = new System.Drawing.Point(603, 184);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(218, 28);
            this.Purpose.TabIndex = 14;
            this.Purpose.SelectedIndexChanged += new System.EventHandler(this.Purpose_SelectedIndexChanged);
            // 
            // OthersPanel
            // 
            this.OthersPanel.BackColor = System.Drawing.Color.Transparent;
            this.OthersPanel.Controls.Add(this.Reasonn);
            this.OthersPanel.Controls.Add(this.Timeout);
            this.OthersPanel.Controls.Add(this.label4);
            this.OthersPanel.Controls.Add(this.Ste);
            this.OthersPanel.Location = new System.Drawing.Point(431, 225);
            this.OthersPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OthersPanel.Name = "OthersPanel";
            this.OthersPanel.Size = new System.Drawing.Size(487, 245);
            this.OthersPanel.TabIndex = 18;
            this.OthersPanel.Visible = false;
            // 
            // Reasonn
            // 
            this.Reasonn.BackColor = System.Drawing.Color.White;
            this.Reasonn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.Reasonn.Location = new System.Drawing.Point(172, 62);
            this.Reasonn.Multiline = true;
            this.Reasonn.Name = "Reasonn";
            this.Reasonn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reasonn.Size = new System.Drawing.Size(298, 164);
            this.Reasonn.TabIndex = 16;
            this.Reasonn.Tag = "";
            // 
            // Timeout
            // 
            this.Timeout.CustomFormat = "hh:mm tt";
            this.Timeout.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Timeout.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Timeout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Timeout.Location = new System.Drawing.Point(172, 14);
            this.Timeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Timeout.Name = "Timeout";
            this.Timeout.ShowUpDown = true;
            this.Timeout.Size = new System.Drawing.Size(218, 29);
            this.Timeout.TabIndex = 14;
            this.Timeout.Value = new System.DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(92, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reason:";
            // 
            // Ste
            // 
            this.Ste.AutoSize = true;
            this.Ste.BackColor = System.Drawing.Color.Transparent;
            this.Ste.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.Ste.Location = new System.Drawing.Point(4, 14);
            this.Ste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ste.Name = "Ste";
            this.Ste.Size = new System.Drawing.Size(161, 23);
            this.Ste.TabIndex = 15;
            this.Ste.Text = "Estimated Time-out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(517, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Purpose:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(503, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(504, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 55);
            this.label3.TabIndex = 19;
            this.label3.Text = "STUDENT LOG";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::LabLog.Properties.Resources.Person_Logo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(637, 487);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Log-In";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // StudentSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OthersPanel);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentSignIn";
            this.Size = new System.Drawing.Size(987, 635);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OthersPanel.ResumeLayout(false);
            this.OthersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.ComboBox Purpose;
        private System.Windows.Forms.Panel OthersPanel;
        private System.Windows.Forms.TextBox Reasonn;
        private System.Windows.Forms.DateTimePicker Timeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Ste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReturnButton;
    }
}
