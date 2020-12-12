namespace Assignment2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoMalvern = new System.Windows.Forms.RadioButton();
            this.rdoWorcester = new System.Windows.Forms.RadioButton();
            this.rdoBromsgrove = new System.Windows.Forms.RadioButton();
            this.rdoRedditch = new System.Windows.Forms.RadioButton();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAvailable);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtFeatures);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEquipment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Equipment";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(285, 71);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(106, 17);
            this.chkAvailable.TabIndex = 6;
            this.chkAvailable.Text = "Available for Hire";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMalvern);
            this.groupBox2.Controls.Add(this.rdoWorcester);
            this.groupBox2.Controls.Add(this.rdoBromsgrove);
            this.groupBox2.Controls.Add(this.rdoRedditch);
            this.groupBox2.Location = new System.Drawing.Point(7, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Site";
            // 
            // rdoMalvern
            // 
            this.rdoMalvern.AutoSize = true;
            this.rdoMalvern.Location = new System.Drawing.Point(150, 44);
            this.rdoMalvern.Name = "rdoMalvern";
            this.rdoMalvern.Size = new System.Drawing.Size(63, 17);
            this.rdoMalvern.TabIndex = 3;
            this.rdoMalvern.TabStop = true;
            this.rdoMalvern.Text = "Malvern";
            this.rdoMalvern.UseVisualStyleBackColor = true;
            // 
            // rdoWorcester
            // 
            this.rdoWorcester.AutoSize = true;
            this.rdoWorcester.Location = new System.Drawing.Point(150, 20);
            this.rdoWorcester.Name = "rdoWorcester";
            this.rdoWorcester.Size = new System.Drawing.Size(74, 17);
            this.rdoWorcester.TabIndex = 2;
            this.rdoWorcester.TabStop = true;
            this.rdoWorcester.Text = "Worcester";
            this.rdoWorcester.UseVisualStyleBackColor = true;
            // 
            // rdoBromsgrove
            // 
            this.rdoBromsgrove.AutoSize = true;
            this.rdoBromsgrove.Location = new System.Drawing.Point(7, 44);
            this.rdoBromsgrove.Name = "rdoBromsgrove";
            this.rdoBromsgrove.Size = new System.Drawing.Size(81, 17);
            this.rdoBromsgrove.TabIndex = 1;
            this.rdoBromsgrove.TabStop = true;
            this.rdoBromsgrove.Text = "Bromsgrove";
            this.rdoBromsgrove.UseVisualStyleBackColor = true;
            // 
            // rdoRedditch
            // 
            this.rdoRedditch.AutoSize = true;
            this.rdoRedditch.Location = new System.Drawing.Point(7, 20);
            this.rdoRedditch.Name = "rdoRedditch";
            this.rdoRedditch.Size = new System.Drawing.Size(68, 17);
            this.rdoRedditch.TabIndex = 0;
            this.rdoRedditch.TabStop = true;
            this.rdoRedditch.Text = "Redditch";
            this.rdoRedditch.UseVisualStyleBackColor = true;
            // 
            // txtFeatures
            // 
            this.txtFeatures.Location = new System.Drawing.Point(123, 44);
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.Size = new System.Drawing.Size(185, 20);
            this.txtFeatures.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Features:";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(123, 17);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(185, 20);
            this.txtEquipment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstMalvern);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lstWorcester);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstBromsgrove);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lstRedditch);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 280);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipment Detail";
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
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(298, 436);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 2;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Availability";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 471);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Equipment Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoMalvern;
        private System.Windows.Forms.RadioButton rdoWorcester;
        private System.Windows.Forms.RadioButton rdoBromsgrove;
        private System.Windows.Forms.RadioButton rdoRedditch;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnUpdate;
    }
}

