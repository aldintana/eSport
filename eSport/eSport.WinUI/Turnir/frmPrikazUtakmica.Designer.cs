namespace eSport.WinUI
{
    partial class frmPrikazUtakmica
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.Domacin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojGolovaDomacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojGolovaGosta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsZavrsena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv turnira:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 35);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(287, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Domacin,
            this.Gost,
            this.BrojGolovaDomacina,
            this.BrojGolovaGosta,
            this.IsZavrsena});
            this.dgvUtakmice.Location = new System.Drawing.Point(12, 70);
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtakmice.Size = new System.Drawing.Size(776, 298);
            this.dgvUtakmice.TabIndex = 3;
            this.dgvUtakmice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtakmice_CellClick);
            // 
            // Domacin
            // 
            this.Domacin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domacin.DataPropertyName = "DomacinNaziv";
            this.Domacin.HeaderText = "Domacin";
            this.Domacin.Name = "Domacin";
            this.Domacin.ReadOnly = true;
            // 
            // Gost
            // 
            this.Gost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gost.DataPropertyName = "GostNaziv";
            this.Gost.HeaderText = "Gost";
            this.Gost.Name = "Gost";
            this.Gost.ReadOnly = true;
            // 
            // BrojGolovaDomacina
            // 
            this.BrojGolovaDomacina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojGolovaDomacina.DataPropertyName = "BrojGolovaDomacina";
            this.BrojGolovaDomacina.HeaderText = "Broj golova domacina";
            this.BrojGolovaDomacina.Name = "BrojGolovaDomacina";
            this.BrojGolovaDomacina.ReadOnly = true;
            // 
            // BrojGolovaGosta
            // 
            this.BrojGolovaGosta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojGolovaGosta.DataPropertyName = "BrojGolovaGosta";
            this.BrojGolovaGosta.HeaderText = "Broj golova gosta";
            this.BrojGolovaGosta.Name = "BrojGolovaGosta";
            this.BrojGolovaGosta.ReadOnly = true;
            // 
            // IsZavrsena
            // 
            this.IsZavrsena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsZavrsena.DataPropertyName = "IsZavrsena";
            this.IsZavrsena.HeaderText = "Zavrsena";
            this.IsZavrsena.Name = "IsZavrsena";
            this.IsZavrsena.ReadOnly = true;
            this.IsZavrsena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsZavrsena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmPrikazUtakmica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvUtakmice);
            this.Name = "frmPrikazUtakmica";
            this.Text = "Utakmice";
            this.Load += new System.EventHandler(this.frmPrikazUtakmica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domacin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gost;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojGolovaDomacina;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojGolovaGosta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsZavrsena;
    }
}