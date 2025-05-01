namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSchoolYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGuardiansContactNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGuardiansRelation = new System.Windows.Forms.TextBox();
            this.txtGuardiansName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNoSiblings = new System.Windows.Forms.TextBox();
            this.txtMothersName = new System.Windows.Forms.TextBox();
            this.txtFathersName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gradiantPanel2 = new GradiantPanel();
            this.gradiantPanel1 = new GradiantPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.gradiantPanel2.SuspendLayout();
            this.gradiantPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MiddleName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFirstName.Location = new System.Drawing.Point(124, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAge.Location = new System.Drawing.Point(124, 107);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(58, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtLastName.Location = new System.Drawing.Point(124, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMiddleName.Location = new System.Drawing.Point(124, 49);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cbGender.Location = new System.Drawing.Point(363, 22);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 0;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Citizenship";
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCitizenship.Location = new System.Drawing.Point(384, 49);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.Size = new System.Drawing.Size(100, 20);
            this.txtCitizenship.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "BirthDate";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "SchoolYear";
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtSchoolYear.Location = new System.Drawing.Point(384, 107);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.Size = new System.Drawing.Size(100, 20);
            this.txtSchoolYear.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 21;
            // 
            // txtGuardiansContactNo
            // 
            this.txtGuardiansContactNo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtGuardiansContactNo.Location = new System.Drawing.Point(430, 85);
            this.txtGuardiansContactNo.Name = "txtGuardiansContactNo";
            this.txtGuardiansContactNo.Size = new System.Drawing.Size(181, 20);
            this.txtGuardiansContactNo.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(295, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Guardian\'s Contact No";
            // 
            // txtGuardiansRelation
            // 
            this.txtGuardiansRelation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtGuardiansRelation.Location = new System.Drawing.Point(430, 55);
            this.txtGuardiansRelation.Name = "txtGuardiansRelation";
            this.txtGuardiansRelation.Size = new System.Drawing.Size(181, 20);
            this.txtGuardiansRelation.TabIndex = 34;
            // 
            // txtGuardiansName
            // 
            this.txtGuardiansName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtGuardiansName.Location = new System.Drawing.Point(430, 25);
            this.txtGuardiansName.Name = "txtGuardiansName";
            this.txtGuardiansName.Size = new System.Drawing.Size(181, 20);
            this.txtGuardiansName.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(295, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Guardian\'s Relation";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(295, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Guardian\'s Name";
            // 
            // txtNoSiblings
            // 
            this.txtNoSiblings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNoSiblings.Location = new System.Drawing.Point(140, 82);
            this.txtNoSiblings.Name = "txtNoSiblings";
            this.txtNoSiblings.Size = new System.Drawing.Size(100, 20);
            this.txtNoSiblings.TabIndex = 30;
            // 
            // txtMothersName
            // 
            this.txtMothersName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMothersName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtMothersName.Location = new System.Drawing.Point(140, 55);
            this.txtMothersName.Name = "txtMothersName";
            this.txtMothersName.Size = new System.Drawing.Size(100, 20);
            this.txtMothersName.TabIndex = 29;
            // 
            // txtFathersName
            // 
            this.txtFathersName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFathersName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFathersName.Location = new System.Drawing.Point(140, 25);
            this.txtFathersName.Name = "txtFathersName";
            this.txtFathersName.Size = new System.Drawing.Size(100, 20);
            this.txtFathersName.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "No of Siblings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mothers\'s Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Father\'s Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Location = new System.Drawing.Point(330, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // gradiantPanel2
            // 
            this.gradiantPanel2.ColorBottom = System.Drawing.SystemColors.ActiveCaption;
            this.gradiantPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gradiantPanel2.Controls.Add(this.txtMiddleName);
            this.gradiantPanel2.Controls.Add(this.label6);
            this.gradiantPanel2.Controls.Add(this.txtFirstName);
            this.gradiantPanel2.Controls.Add(this.txtCitizenship);
            this.gradiantPanel2.Controls.Add(this.label1);
            this.gradiantPanel2.Controls.Add(this.label5);
            this.gradiantPanel2.Controls.Add(this.label7);
            this.gradiantPanel2.Controls.Add(this.label2);
            this.gradiantPanel2.Controls.Add(this.cbGender);
            this.gradiantPanel2.Controls.Add(this.dateTimePicker1);
            this.gradiantPanel2.Controls.Add(this.label3);
            this.gradiantPanel2.Controls.Add(this.label4);
            this.gradiantPanel2.Controls.Add(this.label8);
            this.gradiantPanel2.Controls.Add(this.txtAge);
            this.gradiantPanel2.Controls.Add(this.txtSchoolYear);
            this.gradiantPanel2.Controls.Add(this.txtLastName);
            this.gradiantPanel2.Location = new System.Drawing.Point(58, 56);
            this.gradiantPanel2.Name = "gradiantPanel2";
            this.gradiantPanel2.Size = new System.Drawing.Size(627, 164);
            this.gradiantPanel2.TabIndex = 42;
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.ColorBottom = System.Drawing.SystemColors.ActiveCaption;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gradiantPanel1.Controls.Add(this.txtGuardiansContactNo);
            this.gradiantPanel1.Controls.Add(this.label16);
            this.gradiantPanel1.Controls.Add(this.label18);
            this.gradiantPanel1.Controls.Add(this.label13);
            this.gradiantPanel1.Controls.Add(this.txtGuardiansRelation);
            this.gradiantPanel1.Controls.Add(this.label12);
            this.gradiantPanel1.Controls.Add(this.txtGuardiansName);
            this.gradiantPanel1.Controls.Add(this.label14);
            this.gradiantPanel1.Controls.Add(this.txtFathersName);
            this.gradiantPanel1.Controls.Add(this.label15);
            this.gradiantPanel1.Controls.Add(this.txtMothersName);
            this.gradiantPanel1.Controls.Add(this.txtNoSiblings);
            this.gradiantPanel1.Location = new System.Drawing.Point(58, 242);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(627, 150);
            this.gradiantPanel1.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 28);
            this.label9.TabIndex = 44;
            this.label9.Text = "Pre Registration Form";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 518);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gradiantPanel1);
            this.Controls.Add(this.gradiantPanel2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label11);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gradiantPanel2.ResumeLayout(false);
            this.gradiantPanel2.PerformLayout();
            this.gradiantPanel1.ResumeLayout(false);
            this.gradiantPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCitizenship;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSchoolYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNoSiblings;
        private System.Windows.Forms.TextBox txtMothersName;
        private System.Windows.Forms.TextBox txtFathersName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGuardiansContactNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGuardiansRelation;
        private System.Windows.Forms.TextBox txtGuardiansName;
        private System.Windows.Forms.Button btnSubmit;
        private GradiantPanel gradiantPanel2;
        private GradiantPanel gradiantPanel1;
        private System.Windows.Forms.Label label9;
    }
}