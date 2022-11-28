namespace WindowsFormsAppTanulók
{
    partial class FormTanuloInsert
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
            this.labelTanuloInsert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTanuloInsert
            // 
            this.labelTanuloInsert.AutoSize = true;
            this.labelTanuloInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelTanuloInsert.Location = new System.Drawing.Point(279, 189);
            this.labelTanuloInsert.Name = "labelTanuloInsert";
            this.labelTanuloInsert.Size = new System.Drawing.Size(162, 25);
            this.labelTanuloInsert.TabIndex = 0;
            this.labelTanuloInsert.Text = "Új tanuló adatai";
            // 
            // FormTanuloInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTanuloInsert);
            this.Name = "FormTanuloInsert";
            this.Text = "FormTanuloInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTanuloInsert;
    }
}