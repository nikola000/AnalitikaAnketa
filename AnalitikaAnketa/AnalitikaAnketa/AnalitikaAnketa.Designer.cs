
namespace AnalitikaAnketa
{
    partial class AnalitikaAnketa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdministrator = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiGroupOfTags = new System.Windows.Forms.ToolStripMenuItem();
            this.podesavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.tsmiAdministrator,
            this.podesavanjaToolStripMenuItem,
            this.tsmiGroupOfTags,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Logovanje";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(147, 20);
            this.ToolStripMenuItem2.Text = "Import podataka Ankete";
            // 
            // tsmiAdministrator
            // 
            this.tsmiAdministrator.Name = "tsmiAdministrator";
            this.tsmiAdministrator.Size = new System.Drawing.Size(64, 20);
            this.tsmiAdministrator.Text = "Korisnici";
            this.tsmiAdministrator.Visible = false;
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tagsToolStripMenuItem.Text = "Tagovi";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podesavanjaToolStripMenuItem.Name = "podesavanjaToolStripMenuItem";
            this.podesavanjaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.podesavanjaToolStripMenuItem.Text = "Podešavanja";
            // 
            // toolStripStatusLabelLogin
            // 
            this.toolStripStatusLabelLogin.Name = "toolStripStatusLabelLogin";
            this.toolStripStatusLabelLogin.Size = new System.Drawing.Size(0, 17);
            // 
            // tsmiGroupOfTags
            // 
            this.tsmiGroupOfTags.Name = "tsmiGroupOfTags";
            this.tsmiGroupOfTags.Size = new System.Drawing.Size(90, 20);
            this.tsmiGroupOfTags.Text = "Grupe tagova";
            // 
            // AnalitikaAnketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnalitikaAnketa";
            this.Text = "Analitika anketa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdministrator;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupOfTags;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podesavanjaToolStripMenuItem;
    }
}

