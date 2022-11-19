
namespace eSport.WinUI
{
    partial class frmPrikazTurnira
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnNoviTurnir = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTereni = new System.Windows.Forms.ComboBox();
            this.gbTurniri = new System.Windows.Forms.GroupBox();
            this.dgvTurniri = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeKraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerenNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.gbTurniri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurniri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzvjestaj);
            this.groupBox1.Controls.Add(this.btnNoviTurnir);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTereni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga turnira";
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(695, 34);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaj.TabIndex = 5;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // btnNoviTurnir
            // 
            this.btnNoviTurnir.Location = new System.Drawing.Point(614, 34);
            this.btnNoviTurnir.Name = "btnNoviTurnir";
            this.btnNoviTurnir.Size = new System.Drawing.Size(75, 23);
            this.btnNoviTurnir.TabIndex = 3;
            this.btnNoviTurnir.Text = "Novi turnir";
            this.btnNoviTurnir.UseVisualStyleBackColor = true;
            this.btnNoviTurnir.Click += new System.EventHandler(this.btnNoviTurnir_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(533, 34);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teren:";
            // 
            // cmbTereni
            // 
            this.cmbTereni.FormattingEnabled = true;
            this.cmbTereni.Location = new System.Drawing.Point(7, 36);
            this.cmbTereni.Name = "cmbTereni";
            this.cmbTereni.Size = new System.Drawing.Size(190, 21);
            this.cmbTereni.TabIndex = 0;
            // 
            // gbTurniri
            // 
            this.gbTurniri.Controls.Add(this.dgvTurniri);
            this.gbTurniri.Location = new System.Drawing.Point(12, 82);
            this.gbTurniri.Name = "gbTurniri";
            this.gbTurniri.Size = new System.Drawing.Size(776, 356);
            this.gbTurniri.TabIndex = 2;
            this.gbTurniri.TabStop = false;
            this.gbTurniri.Text = "Turniri";
            // 
            // dgvTurniri
            // 
            this.dgvTurniri.AllowUserToAddRows = false;
            this.dgvTurniri.AllowUserToDeleteRows = false;
            this.dgvTurniri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurniri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.DatumPocetka,
            this.DatumKraja,
            this.VrijemePocetka,
            this.VrijemeKraja,
            this.TerenNaziv,
            this.UkupnaCijena,
            this.Akcija});
            this.dgvTurniri.Location = new System.Drawing.Point(7, 20);
            this.dgvTurniri.Name = "dgvTurniri";
            this.dgvTurniri.ReadOnly = true;
            this.dgvTurniri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurniri.Size = new System.Drawing.Size(763, 330);
            this.dgvTurniri.TabIndex = 0;
            this.dgvTurniri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurniri_CellClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum pocetka";
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            // 
            // DatumKraja
            // 
            this.DatumKraja.DataPropertyName = "DatumKraja";
            this.DatumKraja.HeaderText = "Datum kraja";
            this.DatumKraja.Name = "DatumKraja";
            this.DatumKraja.ReadOnly = true;
            // 
            // VrijemePocetka
            // 
            this.VrijemePocetka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrijemePocetka.DataPropertyName = "VrijemePocetka";
            this.VrijemePocetka.HeaderText = "Pocetak";
            this.VrijemePocetka.Name = "VrijemePocetka";
            this.VrijemePocetka.ReadOnly = true;
            // 
            // VrijemeKraja
            // 
            this.VrijemeKraja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrijemeKraja.DataPropertyName = "VrijemeKraja";
            this.VrijemeKraja.HeaderText = "Kraj";
            this.VrijemeKraja.Name = "VrijemeKraja";
            this.VrijemeKraja.ReadOnly = true;
            // 
            // TerenNaziv
            // 
            this.TerenNaziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TerenNaziv.DataPropertyName = "TerenNaziv";
            this.TerenNaziv.HeaderText = "Teren";
            this.TerenNaziv.Name = "TerenNaziv";
            this.TerenNaziv.ReadOnly = true;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // Akcija
            // 
            this.Akcija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Akcija.HeaderText = "Akcija";
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            this.Akcija.Text = "Obriši";
            this.Akcija.UseColumnTextForButtonValue = true;
            // 
            // frmPrikazTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTurniri);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazTurnira";
            this.Text = "Turnir";
            this.Load += new System.EventHandler(this.frmPrikazTurnira_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTurniri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurniri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNoviTurnir;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTereni;
        private System.Windows.Forms.GroupBox gbTurniri;
        private System.Windows.Forms.DataGridView dgvTurniri;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKraja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemePocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeKraja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerenNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}