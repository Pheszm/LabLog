namespace LabLog.Panels
{
    partial class LogbookAreaForStaff
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
            this.Timeout = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Ste = new System.Windows.Forms.Label();
            this.Purpose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OthersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 68);
            this.label3.TabIndex = 26;
            this.label3.Text = "STUDENT LOG";
            // 
            // StudentID
            // 
            this.StudentID.BackColor = System.Drawing.Color.White;
            this.StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID.Location = new System.Drawing.Point(143, 113);
            this.StudentID.Margin = new System.Windows.Forms.Padding(4);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(384, 34);
            this.StudentID.TabIndex = 22;
            this.StudentID.Tag = "";
            // 
            // OthersPanel
            // 
            this.OthersPanel.BackColor = System.Drawing.Color.Transparent;
            this.OthersPanel.Controls.Add(this.Reasonn);
            this.OthersPanel.Controls.Add(this.Timeout);
            this.OthersPanel.Controls.Add(this.label4);
            this.OthersPanel.Controls.Add(this.Ste);
            this.OthersPanel.Location = new System.Drawing.Point(6, 223);
            this.OthersPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.OthersPanel.Name = "OthersPanel";
            this.OthersPanel.Size = new System.Drawing.Size(608, 302);
            this.OthersPanel.TabIndex = 25;
            this.OthersPanel.Visible = false;
            // 
            // Reasonn
            // 
            this.Reasonn.BackColor = System.Drawing.Color.White;
            this.Reasonn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Reasonn.Location = new System.Drawing.Point(195, 76);
            this.Reasonn.Margin = new System.Windows.Forms.Padding(4);
            this.Reasonn.Multiline = true;
            this.Reasonn.Name = "Reasonn";
            this.Reasonn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reasonn.Size = new System.Drawing.Size(396, 201);
            this.Reasonn.TabIndex = 16;
            this.Reasonn.Tag = "";
            // 
            // Timeout
            // 
            this.Timeout.CustomFormat = "hh:mm tt";
            this.Timeout.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Timeout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Timeout.Location = new System.Drawing.Point(225, 21);
            this.Timeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Timeout.Name = "Timeout";
            this.Timeout.ShowUpDown = true;
            this.Timeout.Size = new System.Drawing.Size(289, 34);
            this.Timeout.TabIndex = 14;
            this.Timeout.Value = new System.DateTime(2024, 2, 18, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(103, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reason:";
            // 
            // Ste
            // 
            this.Ste.AutoSize = true;
            this.Ste.BackColor = System.Drawing.Color.Transparent;
            this.Ste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Ste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.Ste.Location = new System.Drawing.Point(5, 31);
            this.Ste.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Ste.Name = "Ste";
            this.Ste.Size = new System.Drawing.Size(179, 20);
            this.Ste.TabIndex = 15;
            this.Ste.Text = "Estimated Time-out:";
            // 
            // Purpose
            // 
            this.Purpose.BackColor = System.Drawing.Color.White;
            this.Purpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purpose.FormattingEnabled = true;
            this.Purpose.Items.AddRange(new object[] {
            "Available Subject",
            "Others"});
            this.Purpose.Location = new System.Drawing.Point(143, 172);
            this.Purpose.Margin = new System.Windows.Forms.Padding(4);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(289, 33);
            this.Purpose.TabIndex = 21;
            this.Purpose.SelectedIndexChanged += new System.EventHandler(this.Purpose_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(23, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Purpose:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Student ID:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::LabLog.Properties.Resources.Person_Logo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(171, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Log-In";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LogbookAreaForStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.OthersPanel);
            this.Controls.Add(this.Purpose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogbookAreaForStaff";
            this.Size = new System.Drawing.Size(619, 641);
            this.OthersPanel.ResumeLayout(false);
            this.OthersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Panel OthersPanel;
        private System.Windows.Forms.TextBox Reasonn;
        private System.Windows.Forms.DateTimePicker Timeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Ste;
        private System.Windows.Forms.ComboBox Purpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
