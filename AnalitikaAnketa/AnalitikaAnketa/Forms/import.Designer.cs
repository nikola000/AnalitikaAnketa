
namespace AnalitikaAnketa.Forms
{
    partial class import
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
            this.txtIzborFajla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtIzborFajla
            // 
            this.txtIzborFajla.BackColor = System.Drawing.Color.White;
            this.txtIzborFajla.Location = new System.Drawing.Point(133, 210);
            this.txtIzborFajla.Multiline = true;
            this.txtIzborFajla.Name = "txtIzborFajla";
            this.txtIzborFajla.ReadOnly = true;
            this.txtIzborFajla.Size = new System.Drawing.Size(433, 64);
            this.txtIzborFajla.TabIndex = 0;
            this.txtIzborFajla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(286, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izbor fajla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFD_FileOk);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIzborFajla);
            this.Name = "import";
            this.Text = "import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIzborFajla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}