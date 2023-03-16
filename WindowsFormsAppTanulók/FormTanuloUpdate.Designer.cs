namespace WindowsFormsAppTanulók
{
    partial class FormTanuloUpdate
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
            this.labelTanuloUpdate = new System.Windows.Forms.Label();
            this.listBoxGyumolcsok = new System.Windows.Forms.ListBox();
            this.groupBoxKivalasztottGyumolcs = new System.Windows.Forms.GroupBox();
            this.buttonModosítas = new System.Windows.Forms.Button();
            this.numericUpDownEgysegar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.textBoxGyumolcsnev = new System.Windows.Forms.TextBox();
            this.textBoxAzonosito = new System.Windows.Forms.TextBox();
            this.labelEgysegar = new System.Windows.Forms.Label();
            this.labelMennyiseg = new System.Windows.Forms.Label();
            this.labelGyumolcsnev = new System.Windows.Forms.Label();
            this.labelAzonosito = new System.Windows.Forms.Label();
            this.groupBoxKivalasztottGyumolcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTanuloUpdate
            // 
            this.labelTanuloUpdate.AutoSize = true;
            this.labelTanuloUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelTanuloUpdate.Location = new System.Drawing.Point(252, 9);
            this.labelTanuloUpdate.Name = "labelTanuloUpdate";
            this.labelTanuloUpdate.Size = new System.Drawing.Size(312, 25);
            this.labelTanuloUpdate.TabIndex = 0;
            this.labelTanuloUpdate.Text = "Tanuló adatainak a módosítása";
            // 
            // listBoxGyumolcsok
            // 
            this.listBoxGyumolcsok.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxGyumolcsok.FormattingEnabled = true;
            this.listBoxGyumolcsok.Location = new System.Drawing.Point(585, 0);
            this.listBoxGyumolcsok.Name = "listBoxGyumolcsok";
            this.listBoxGyumolcsok.Size = new System.Drawing.Size(215, 450);
            this.listBoxGyumolcsok.TabIndex = 1;
            this.listBoxGyumolcsok.SelectedIndexChanged += new System.EventHandler(this.listBoxGyumolcsok_SelectedIndexChanged);
            // 
            // groupBoxKivalasztottGyumolcs
            // 
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.buttonModosítas);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.numericUpDownEgysegar);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.numericUpDownMennyiseg);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.textBoxGyumolcsnev);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.textBoxAzonosito);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelEgysegar);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelMennyiseg);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelGyumolcsnev);
            this.groupBoxKivalasztottGyumolcs.Controls.Add(this.labelAzonosito);
            this.groupBoxKivalasztottGyumolcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKivalasztottGyumolcs.Location = new System.Drawing.Point(1, 37);
            this.groupBoxKivalasztottGyumolcs.Name = "groupBoxKivalasztottGyumolcs";
            this.groupBoxKivalasztottGyumolcs.Size = new System.Drawing.Size(578, 413);
            this.groupBoxKivalasztottGyumolcs.TabIndex = 2;
            this.groupBoxKivalasztottGyumolcs.TabStop = false;
            this.groupBoxKivalasztottGyumolcs.Text = "Kiválasztott gyümölcs";
            // 
            // buttonModosítas
            // 
            this.buttonModosítas.Location = new System.Drawing.Point(34, 211);
            this.buttonModosítas.Name = "buttonModosítas";
            this.buttonModosítas.Size = new System.Drawing.Size(181, 35);
            this.buttonModosítas.TabIndex = 11;
            this.buttonModosítas.Text = "Módosítás";
            this.buttonModosítas.UseVisualStyleBackColor = true;
            this.buttonModosítas.Click += new System.EventHandler(this.buttonModosítas_Click);
            // 
            // numericUpDownEgysegar
            // 
            this.numericUpDownEgysegar.DecimalPlaces = 2;
            this.numericUpDownEgysegar.Location = new System.Drawing.Point(125, 156);
            this.numericUpDownEgysegar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownEgysegar.Name = "numericUpDownEgysegar";
            this.numericUpDownEgysegar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEgysegar.TabIndex = 9;
            this.numericUpDownEgysegar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownMennyiseg
            // 
            this.numericUpDownMennyiseg.DecimalPlaces = 2;
            this.numericUpDownMennyiseg.Location = new System.Drawing.Point(125, 116);
            this.numericUpDownMennyiseg.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownMennyiseg.Name = "numericUpDownMennyiseg";
            this.numericUpDownMennyiseg.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMennyiseg.TabIndex = 8;
            this.numericUpDownMennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGyumolcsnev
            // 
            this.textBoxGyumolcsnev.Location = new System.Drawing.Point(125, 66);
            this.textBoxGyumolcsnev.Name = "textBoxGyumolcsnev";
            this.textBoxGyumolcsnev.Size = new System.Drawing.Size(120, 26);
            this.textBoxGyumolcsnev.TabIndex = 5;
            this.textBoxGyumolcsnev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAzonosito
            // 
            this.textBoxAzonosito.Location = new System.Drawing.Point(125, 25);
            this.textBoxAzonosito.Name = "textBoxAzonosito";
            this.textBoxAzonosito.ReadOnly = true;
            this.textBoxAzonosito.Size = new System.Drawing.Size(120, 26);
            this.textBoxAzonosito.TabIndex = 4;
            this.textBoxAzonosito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelEgysegar
            // 
            this.labelEgysegar.AutoSize = true;
            this.labelEgysegar.Location = new System.Drawing.Point(39, 158);
            this.labelEgysegar.Name = "labelEgysegar";
            this.labelEgysegar.Size = new System.Drawing.Size(80, 20);
            this.labelEgysegar.TabIndex = 3;
            this.labelEgysegar.Text = "Egységár:";
            // 
            // labelMennyiseg
            // 
            this.labelMennyiseg.AutoSize = true;
            this.labelMennyiseg.Location = new System.Drawing.Point(30, 118);
            this.labelMennyiseg.Name = "labelMennyiseg";
            this.labelMennyiseg.Size = new System.Drawing.Size(89, 20);
            this.labelMennyiseg.TabIndex = 2;
            this.labelMennyiseg.Text = "Mennyiség:";
            // 
            // labelGyumolcsnev
            // 
            this.labelGyumolcsnev.AutoSize = true;
            this.labelGyumolcsnev.Location = new System.Drawing.Point(11, 66);
            this.labelGyumolcsnev.Name = "labelGyumolcsnev";
            this.labelGyumolcsnev.Size = new System.Drawing.Size(108, 20);
            this.labelGyumolcsnev.TabIndex = 1;
            this.labelGyumolcsnev.Text = "Gyümölcsnév:";
            // 
            // labelAzonosito
            // 
            this.labelAzonosito.AutoSize = true;
            this.labelAzonosito.Location = new System.Drawing.Point(35, 25);
            this.labelAzonosito.Name = "labelAzonosito";
            this.labelAzonosito.Size = new System.Drawing.Size(84, 20);
            this.labelAzonosito.TabIndex = 0;
            this.labelAzonosito.Text = "Azonosító:";
            // 
            // FormTanuloUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKivalasztottGyumolcs);
            this.Controls.Add(this.listBoxGyumolcsok);
            this.Controls.Add(this.labelTanuloUpdate);
            this.Name = "FormTanuloUpdate";
            this.Text = "FormTanuloUpdate";
            this.Load += new System.EventHandler(this.FormTanuloUpdate_Load);
            this.groupBoxKivalasztottGyumolcs.ResumeLayout(false);
            this.groupBoxKivalasztottGyumolcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTanuloUpdate;
        private System.Windows.Forms.GroupBox groupBoxKivalasztottGyumolcs;
        private System.Windows.Forms.Label labelEgysegar;
        private System.Windows.Forms.Label labelMennyiseg;
        private System.Windows.Forms.Label labelGyumolcsnev;
        private System.Windows.Forms.Label labelAzonosito;
        private System.Windows.Forms.Button buttonModosítas;
        public System.Windows.Forms.NumericUpDown numericUpDownEgysegar;
        public System.Windows.Forms.NumericUpDown numericUpDownMennyiseg;
        public System.Windows.Forms.TextBox textBoxGyumolcsnev;
        public System.Windows.Forms.TextBox textBoxAzonosito;
        public System.Windows.Forms.ListBox listBoxGyumolcsok;
    }
}