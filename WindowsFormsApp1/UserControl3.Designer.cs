namespace WindowsFormsApp1
{
    partial class UserControl3
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
            this.gradiantPanel1 = new GradiantPanel();
            this.SuspendLayout();
            // 
            // gradiantPanel1
            // 
            this.gradiantPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.gradiantPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradiantPanel1.Location = new System.Drawing.Point(107, 57);
            this.gradiantPanel1.Name = "gradiantPanel1";
            this.gradiantPanel1.Size = new System.Drawing.Size(200, 100);
            this.gradiantPanel1.TabIndex = 0;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradiantPanel1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(679, 298);
            this.ResumeLayout(false);

        }

        #endregion

        private GradiantPanel gradiantPanel1;
    }
}
