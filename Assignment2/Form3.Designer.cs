namespace Assignment2
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstMalvern = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstWorcester = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBromsgrove = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRedditch = new System.Windows.Forms.ListBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStaffFirstName = new System.Windows.Forms.Label();
            this.lblStaffSurname = new System.Windows.Forms.Label();
            this.lblManagerFirstName = new System.Windows.Forms.Label();
            this.lblManagerSurname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.chkAuth = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 251);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Request";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReason);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblStaffSurname);
            this.groupBox2.Controls.Add(this.lblStaffFirstName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff Detail";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAuth);
            this.groupBox3.Controls.Add(this.lblManagerSurname);
            this.groupBox3.Controls.Add(this.lblManagerFirstName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(7, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manager Detail";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstMalvern);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lstWorcester);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lstBromsgrove);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lstRedditch);
            this.groupBox4.Controls.Add(this.txtDate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(12, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 280);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equipment Detail";
            // 
            // lstMalvern
            // 
            this.lstMalvern.FormattingEnabled = true;
            this.lstMalvern.Location = new System.Drawing.Point(230, 180);
            this.lstMalvern.Name = "lstMalvern";
            this.lstMalvern.Size = new System.Drawing.Size(165, 95);
            this.lstMalvern.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Malvern";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Worcester";
            // 
            // lstWorcester
            // 
            this.lstWorcester.FormattingEnabled = true;
            this.lstWorcester.Location = new System.Drawing.Point(15, 180);
            this.lstWorcester.Name = "lstWorcester";
            this.lstWorcester.Size = new System.Drawing.Size(165, 95);
            this.lstWorcester.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bromsgrove";
            // 
            // lstBromsgrove
            // 
            this.lstBromsgrove.FormattingEnabled = true;
            this.lstBromsgrove.Location = new System.Drawing.Point(230, 60);
            this.lstBromsgrove.Name = "lstBromsgrove";
            this.lstBromsgrove.Size = new System.Drawing.Size(165, 95);
            this.lstBromsgrove.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Redditch";
            // 
            // lstRedditch
            // 
            this.lstRedditch.FormattingEnabled = true;
            this.lstRedditch.Location = new System.Drawing.Point(15, 60);
            this.lstRedditch.Name = "lstRedditch";
            this.lstRedditch.Size = new System.Drawing.Size(165, 95);
            this.lstRedditch.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(157, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(185, 20);
            this.txtDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Updated:";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(178, 555);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Check Out";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Surname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "First Name:";
            // 
            // lblStaffFirstName
            // 
            this.lblStaffFirstName.AutoSize = true;
            this.lblStaffFirstName.Location = new System.Drawing.Point(151, 30);
            this.lblStaffFirstName.Name = "lblStaffFirstName";
            this.lblStaffFirstName.Size = new System.Drawing.Size(76, 13);
            this.lblStaffFirstName.TabIndex = 7;
            this.lblStaffFirstName.Text = "StaffFirstName";
            // 
            // lblStaffSurname
            // 
            this.lblStaffSurname.AutoSize = true;
            this.lblStaffSurname.Location = new System.Drawing.Point(151, 57);
            this.lblStaffSurname.Name = "lblStaffSurname";
            this.lblStaffSurname.Size = new System.Drawing.Size(71, 13);
            this.lblStaffSurname.TabIndex = 8;
            this.lblStaffSurname.Text = "StaffSurname";
            // 
            // lblManagerFirstName
            // 
            this.lblManagerFirstName.AutoSize = true;
            this.lblManagerFirstName.Location = new System.Drawing.Point(150, 30);
            this.lblManagerFirstName.Name = "lblManagerFirstName";
            this.lblManagerFirstName.Size = new System.Drawing.Size(96, 13);
            this.lblManagerFirstName.TabIndex = 7;
            this.lblManagerFirstName.Text = "ManagerFirstName";
            // 
            // lblManagerSurname
            // 
            this.lblManagerSurname.AutoSize = true;
            this.lblManagerSurname.Location = new System.Drawing.Point(150, 57);
            this.lblManagerSurname.Name = "lblManagerSurname";
            this.lblManagerSurname.Size = new System.Drawing.Size(91, 13);
            this.lblManagerSurname.TabIndex = 8;
            this.lblManagerSurname.Text = "ManagerSurname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(154, 83);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(150, 20);
            this.txtReason.TabIndex = 10;
            // 
            // chkAuth
            // 
            this.chkAuth.AutoSize = true;
            this.chkAuth.Location = new System.Drawing.Point(153, 80);
            this.chkAuth.Name = "chkAuth";
            this.chkAuth.Size = new System.Drawing.Size(79, 17);
            this.chkAuth.TabIndex = 9;
            this.chkAuth.Text = "Aurthorised";
            this.chkAuth.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 586);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Equipment Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstMalvern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstWorcester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstBromsgrove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstRedditch;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblManagerSurname;
        private System.Windows.Forms.Label lblManagerFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStaffSurname;
        private System.Windows.Forms.Label lblStaffFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkAuth;
    }
}