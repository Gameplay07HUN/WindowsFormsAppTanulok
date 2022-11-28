namespace WindowsFormsAppTanulók
{
    partial class FormTanuloDelete
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
            this.labelTanuloDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTanuloDelete
            // 
            this.labelTanuloDelete.AutoSize = true;
            this.labelTanuloDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelTanuloDelete.Location = new System.Drawing.Point(305, 193);
            this.labelTanuloDelete.Name = "labelTanuloDelete";
            this.labelTanuloDelete.Size = new System.Drawing.Size(149, 25);
            this.labelTanuloDelete.TabIndex = 0;
            this.labelTanuloDelete.Text = "Tanulo törlése";
            // 
            // FormTanuloDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTanuloDelete);
            this.Name = "FormTanuloDelete";
            this.Text = "FormTanuloDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTanuloDelete;
    }
}