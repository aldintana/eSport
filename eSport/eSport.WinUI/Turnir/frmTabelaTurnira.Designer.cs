namespace eSport.WinUI
{
    partial class frmTabelaTurnira
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
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPobjeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNerijesenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPoraza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDatihGolova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrimljenihGolova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojBodova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziUtakmice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.AllowUserToDeleteRows = false;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.BrojPobjeda,
            this.BrojNerijesenih,
            this.BrojPoraza,
            this.BrojDatihGolova,
            this.BrojPrimljenihGolova,
            this.BrojBodova});
            this.dgvTimovi.Location = new System.Drawing.Point(12, 58);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.ReadOnly = true;
            this.dgvTimovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimovi.Size = new System.Drawing.Size(776, 298);
            this.dgvTimovi.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrojPobjeda
            // 
            this.BrojPobjeda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPobjeda.DataPropertyName = "BrojPobjeda";
            this.BrojPobjeda.HeaderText = "Pobjede";
            this.BrojPobjeda.Name = "BrojPobjeda";
            this.BrojPobjeda.ReadOnly = true;
            // 
            // BrojNerijesenih
            // 
            this.BrojNerijesenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojNerijesenih.DataPropertyName = "BrojNerijesenih";
            this.BrojNerijesenih.HeaderText = "Nerijesene";
            this.BrojNerijesenih.Name = "BrojNerijesenih";
            this.BrojNerijesenih.ReadOnly = true;
            // 
            // BrojPoraza
            // 
            this.BrojPoraza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPoraza.DataPropertyName = "BrojPoraza";
            this.BrojPoraza.HeaderText = "Porazi";
            this.BrojPoraza.Name = "BrojPoraza";
            this.BrojPoraza.ReadOnly = true;
            // 
            // BrojDatihGolova
            // 
            this.BrojDatihGolova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojDatihGolova.DataPropertyName = "BrojDatihGolova";
            this.BrojDatihGolova.HeaderText = "Broj datih golova";
            this.BrojDatihGolova.Name = "BrojDatihGolova";
            this.BrojDatihGolova.ReadOnly = true;
            // 
            // BrojPrimljenihGolova
            // 
            this.BrojPrimljenihGolova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPrimljenihGolova.DataPropertyName = "BrojPrimljenihGolova";
            this.BrojPrimljenihGolova.HeaderText = "Broj primljenih golova";
            this.BrojPrimljenihGolova.Name = "BrojPrimljenihGolova";
            this.BrojPrimljenihGolova.ReadOnly = true;
            // 
            // BrojBodova
            // 
            this.BrojBodova.DataPropertyName = "BrojBodova";
            this.BrojBodova.HeaderText = "Broj bodova";
            this.BrojBodova.Name = "BrojBodova";
            this.BrojBodova.ReadOnly = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(287, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv turnira:";
            // 
            // btnPrikaziUtakmice
            // 
            this.btnPrikaziUtakmice.Location = new System.Drawing.Point(588, 29);
            this.btnPrikaziUtakmice.Name = "btnPrikaziUtakmice";
            this.btnPrikaziUtakmice.Size = new System.Drawing.Size(200, 23);
            this.btnPrikaziUtakmice.TabIndex = 3;
            this.btnPrikaziUtakmice.Text = "Utakmice";
            this.btnPrikaziUtakmice.UseVisualStyleBackColor = true;
            this.btnPrikaziUtakmice.Click += new System.EventHandler(this.btnPrikaziUtakmice_Click);
            // 
            // frmTabelaTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.btnPrikaziUtakmice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvTimovi);
            this.Name = "frmTabelaTurnira";
            this.Text = "Tabela";
            this.Load += new System.EventHandler(this.frmTablicaTurnira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPobjeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNerijesenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPoraza;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDatihGolova;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrimljenihGolova;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojBodova;
        private System.Windows.Forms.Button btnPrikaziUtakmice;
    }
}