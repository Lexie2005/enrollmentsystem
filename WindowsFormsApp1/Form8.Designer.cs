﻿namespace WindowsFormsApp1
{
    partial class Form8
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
            this.gradiantPanel2 = new GradiantPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradiantPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradiantPanel2
            // 
            this.gradiantPanel2.ColorBottom = System.Drawing.SystemColors.ActiveCaption;
            this.gradiantPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gradiantPanel2.Controls.Add(this.label1);
            this.gradiantPanel2.Location = new System.Drawing.Point(-4, -3);
            this.gradiantPanel2.Name = "gradiantPanel2";
            this.gradiantPanel2.Size = new System.Drawing.Size(473, 217);
            this.gradiantPanel2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congatulations! You Are Now \r\nOfficially Enrolled in St. Aguilar Academy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 212);
            this.Controls.Add(this.gradiantPanel2);
            this.Name = "Form8";
            this.Text = "Form8";
            this.gradiantPanel2.ResumeLayout(false);
            this.gradiantPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel2;
        private System.Windows.Forms.Label label1;
    }
}