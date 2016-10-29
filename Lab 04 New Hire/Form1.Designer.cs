namespace Lab_04_New_Hire
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
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblOpt1 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSallaryTeacher = new System.Windows.Forms.TextBox();
            this.txtRankTeacher = new System.Windows.Forms.TextBox();
            this.txtMajorStudent = new System.Windows.Forms.TextBox();
            this.txtDepartmentAdministration = new System.Windows.Forms.TextBox();
            this.txtGpaStudent = new System.Windows.Forms.TextBox();
            this.txtHourlyRateAdministration = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(13, 52);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(128, 52);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 23);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(244, 52);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 109);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID: ";
            this.lblId.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 150);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 187);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Visible = false;
            // 
            // lblOpt1
            // 
            this.lblOpt1.AutoSize = true;
            this.lblOpt1.Location = new System.Drawing.Point(12, 224);
            this.lblOpt1.Name = "lblOpt1";
            this.lblOpt1.Size = new System.Drawing.Size(47, 13);
            this.lblOpt1.TabIndex = 6;
            this.lblOpt1.Text = "Option 1";
            this.lblOpt1.Visible = false;
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Location = new System.Drawing.Point(12, 263);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(47, 13);
            this.lblOption2.TabIndex = 7;
            this.lblOption2.Text = "Option 2";
            this.lblOption2.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 109);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(221, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(98, 143);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(221, 20);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(98, 180);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(221, 20);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.Visible = false;
            // 
            // txtSallaryTeacher
            // 
            this.txtSallaryTeacher.Location = new System.Drawing.Point(98, 256);
            this.txtSallaryTeacher.Name = "txtSallaryTeacher";
            this.txtSallaryTeacher.Size = new System.Drawing.Size(221, 20);
            this.txtSallaryTeacher.TabIndex = 11;
            this.txtSallaryTeacher.Visible = false;
            // 
            // txtRankTeacher
            // 
            this.txtRankTeacher.Location = new System.Drawing.Point(98, 217);
            this.txtRankTeacher.Name = "txtRankTeacher";
            this.txtRankTeacher.Size = new System.Drawing.Size(221, 20);
            this.txtRankTeacher.TabIndex = 12;
            this.txtRankTeacher.Visible = false;
            // 
            // txtMajorStudent
            // 
            this.txtMajorStudent.Location = new System.Drawing.Point(98, 217);
            this.txtMajorStudent.Name = "txtMajorStudent";
            this.txtMajorStudent.Size = new System.Drawing.Size(221, 20);
            this.txtMajorStudent.TabIndex = 13;
            this.txtMajorStudent.Visible = false;
            // 
            // txtDepartmentAdministration
            // 
            this.txtDepartmentAdministration.Location = new System.Drawing.Point(98, 217);
            this.txtDepartmentAdministration.Name = "txtDepartmentAdministration";
            this.txtDepartmentAdministration.Size = new System.Drawing.Size(221, 20);
            this.txtDepartmentAdministration.TabIndex = 14;
            this.txtDepartmentAdministration.Visible = false;
            // 
            // txtGpaStudent
            // 
            this.txtGpaStudent.Location = new System.Drawing.Point(98, 256);
            this.txtGpaStudent.Name = "txtGpaStudent";
            this.txtGpaStudent.Size = new System.Drawing.Size(221, 20);
            this.txtGpaStudent.TabIndex = 15;
            this.txtGpaStudent.Visible = false;
            // 
            // txtHourlyRateAdministration
            // 
            this.txtHourlyRateAdministration.Location = new System.Drawing.Point(98, 256);
            this.txtHourlyRateAdministration.Name = "txtHourlyRateAdministration";
            this.txtHourlyRateAdministration.Size = new System.Drawing.Size(221, 20);
            this.txtHourlyRateAdministration.TabIndex = 16;
            this.txtHourlyRateAdministration.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(304, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHourlyRateAdministration);
            this.Controls.Add(this.txtGpaStudent);
            this.Controls.Add(this.txtDepartmentAdministration);
            this.Controls.Add(this.txtMajorStudent);
            this.Controls.Add(this.txtRankTeacher);
            this.Controls.Add(this.txtSallaryTeacher);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.lblOpt1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnTeacher);
            this.Name = "Form1";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblOpt1;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSallaryTeacher;
        private System.Windows.Forms.TextBox txtRankTeacher;
        private System.Windows.Forms.TextBox txtMajorStudent;
        private System.Windows.Forms.TextBox txtDepartmentAdministration;
        private System.Windows.Forms.TextBox txtGpaStudent;
        private System.Windows.Forms.TextBox txtHourlyRateAdministration;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

