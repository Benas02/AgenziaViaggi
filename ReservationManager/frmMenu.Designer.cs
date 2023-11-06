namespace ReservationManager
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.anagrafiche = new System.Windows.Forms.ToolStripSplitButton();
            this.prenotazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anagrafiche});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // anagrafiche
            // 
            this.anagrafiche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.anagrafiche.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prenotazioniToolStripMenuItem,
            this.clientiToolStripMenuItem});
            this.anagrafiche.Image = ((System.Drawing.Image)(resources.GetObject("anagrafiche.Image")));
            this.anagrafiche.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anagrafiche.Name = "anagrafiche";
            this.anagrafiche.Size = new System.Drawing.Size(108, 24);
            this.anagrafiche.Text = "Anagrafiche";
            // 
            // prenotazioniToolStripMenuItem
            // 
            this.prenotazioniToolStripMenuItem.Name = "prenotazioniToolStripMenuItem";
            this.prenotazioniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prenotazioniToolStripMenuItem.Text = "Prenotazioni";
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton anagrafiche;
        private System.Windows.Forms.ToolStripMenuItem prenotazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
    }
}