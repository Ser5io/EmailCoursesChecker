namespace Email_Courses_Checker
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.btnGetCourses = new System.Windows.Forms.Button();
            this.tbClassNumbers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaxEmails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(145, 36);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(256, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(145, 99);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(256, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // tbResponse
            // 
            this.tbResponse.BackColor = System.Drawing.SystemColors.Window;
            this.tbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponse.Location = new System.Drawing.Point(54, 206);
            this.tbResponse.Multiline = true;
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.ReadOnly = true;
            this.tbResponse.Size = new System.Drawing.Size(828, 372);
            this.tbResponse.TabIndex = 4;
            // 
            // btnGetCourses
            // 
            this.btnGetCourses.Location = new System.Drawing.Point(382, 157);
            this.btnGetCourses.Name = "btnGetCourses";
            this.btnGetCourses.Size = new System.Drawing.Size(193, 23);
            this.btnGetCourses.TabIndex = 5;
            this.btnGetCourses.Text = "Get Courses";
            this.btnGetCourses.UseVisualStyleBackColor = true;
            this.btnGetCourses.Click += new System.EventHandler(this.btnGetCourses_Click);
            // 
            // tbClassNumbers
            // 
            this.tbClassNumbers.Location = new System.Drawing.Point(636, 36);
            this.tbClassNumbers.Name = "tbClassNumbers";
            this.tbClassNumbers.Size = new System.Drawing.Size(246, 20);
            this.tbClassNumbers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classes Numbers\r\n(seperated by commas)";
            // 
            // tbMaxEmails
            // 
            this.tbMaxEmails.Location = new System.Drawing.Point(636, 99);
            this.tbMaxEmails.Name = "tbMaxEmails";
            this.tbMaxEmails.Size = new System.Drawing.Size(246, 20);
            this.tbMaxEmails.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max Emails to Search\r\n(From newest to oldest)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaxEmails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbClassNumbers);
            this.Controls.Add(this.btnGetCourses);
            this.Controls.Add(this.tbResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Name = "Form1";
            this.Text = "Email Course Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Button btnGetCourses;
        private System.Windows.Forms.TextBox tbClassNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxEmails;
        private System.Windows.Forms.Label label4;
    }
}

