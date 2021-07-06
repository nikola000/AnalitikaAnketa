
namespace AnalitikaAnketa.Forms
{
    partial class Import
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.bUcitaj = new System.Windows.Forms.Button();
            this.txtIzborFajla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izbor fajla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // bUcitaj
            // 
            this.bUcitaj.Location = new System.Drawing.Point(582, 39);
            this.bUcitaj.Name = "bUcitaj";
            this.bUcitaj.Size = new System.Drawing.Size(117, 23);
            this.bUcitaj.TabIndex = 2;
            this.bUcitaj.Text = "Ucitaj";
            this.bUcitaj.UseVisualStyleBackColor = true;
            this.bUcitaj.Click += new System.EventHandler(this.bUcitaj_Click);
            // 
            // txtIzborFajla
            // 
            this.txtIzborFajla.Location = new System.Drawing.Point(34, 39);
            this.txtIzborFajla.Name = "txtIzborFajla";
            this.txtIzborFajla.Size = new System.Drawing.Size(419, 23);
            this.txtIzborFajla.TabIndex = 3;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 372);
            this.Controls.Add(this.txtIzborFajla);
            this.Controls.Add(this.bUcitaj);
            this.Controls.Add(this.button1);
            this.Name = "Import";
            this.Text = "import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button bUcitaj;
        private System.Windows.Forms.TextBox txtIzborFajla;
    }
}