namespace eSport.WinUI
{
    partial class frmPocetna
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tereniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turniriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aktivniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tereniToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.turniriToolStripMenuItem,
            this.korisniciToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tereniToolStripMenuItem
            // 
            this.tereniToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tereniToolStripMenuItem.Name = "tereniToolStripMenuItem";
            this.tereniToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tereniToolStripMenuItem.Text = "Tereni";
            this.tereniToolStripMenuItem.Click += new System.EventHandler(this.tereniToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktivniToolStripMenuItem,
            this.historijaToolStripMenuItem});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // aktivniToolStripMenuItem
            // 
            this.aktivniToolStripMenuItem.Name = "aktivniToolStripMenuItem";
            this.aktivniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aktivniToolStripMenuItem.Text = "Aktivni";
            this.aktivniToolStripMenuItem.Click += new System.EventHandler(this.aktivniToolStripMenuItem_Click);
            // 
            // historijaToolStripMenuItem
            // 
            this.historijaToolStripMenuItem.Name = "historijaToolStripMenuItem";
            this.historijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historijaToolStripMenuItem.Text = "Historija";
            this.historijaToolStripMenuItem.Click += new System.EventHandler(this.historijaToolStripMenuItem_Click);
            // 
            // turniriToolStripMenuItem
            // 
            this.turniriToolStripMenuItem.Checked = true;
            this.turniriToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.turniriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktivniToolStripMenuItem1,
            this.historijaToolStripMenuItem1});
            this.turniriToolStripMenuItem.Name = "turniriToolStripMenuItem";
            this.turniriToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.turniriToolStripMenuItem.Text = "Turniri";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // aktivniToolStripMenuItem1
            // 
            this.aktivniToolStripMenuItem1.Name = "aktivniToolStripMenuItem1";
            this.aktivniToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aktivniToolStripMenuItem1.Text = "Aktivni";
            this.aktivniToolStripMenuItem1.Click += new System.EventHandler(this.aktivniToolStripMenuItem1_Click);
            // 
            // historijaToolStripMenuItem1
            // 
            this.historijaToolStripMenuItem1.Name = "historijaToolStripMenuItem1";
            this.historijaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.historijaToolStripMenuItem1.Text = "Historija";
            this.historijaToolStripMenuItem1.Click += new System.EventHandler(this.historijaToolStripMenuItem1_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPocetna";
            this.Text = "Početna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tereniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turniriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historijaToolStripMenuItem1;
    }
}



