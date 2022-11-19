
namespace eSport.WinUI
{
    partial class frmDetaljiTurnira
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
            this.cbIsPotvrdjen = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipRezervacije = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbZavrsetak = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPocetak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeren = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumKraja = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.txtSport = new System.Windows.Forms.TextBox();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIsPotvrdjen
            // 
            this.cbIsPotvrdjen.AutoSize = true;
            this.cbIsPotvrdjen.Location = new System.Drawing.Point(442, 199);
            this.cbIsPotvrdjen.Name = "cbIsPotvrdjen";
            this.cbIsPotvrdjen.Size = new System.Drawing.Size(71, 17);
            this.cbIsPotvrdjen.TabIndex = 31;
            this.cbIsPotvrdjen.Text = "Potvrdjen";
            this.cbIsPotvrdjen.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(519, 188);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(165, 37);
            this.btnSacuvaj.TabIndex = 30;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(519, 94);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(165, 20);
            this.txtCijena.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cijena (KM):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tip rezervacije:";
            // 
            // cmbTipRezervacije
            // 
            this.cmbTipRezervacije.FormattingEnabled = true;
            this.cmbTipRezervacije.Location = new System.Drawing.Point(348, 93);
            this.cmbTipRezervacije.Name = "cmbTipRezervacije";
            this.cmbTipRezervacije.Size = new System.Drawing.Size(165, 21);
            this.cmbTipRezervacije.TabIndex = 26;
            this.cmbTipRezervacije.SelectedIndexChanged += new System.EventHandler(this.cmbTipRezervacije_SelectedIndexChanged);
            this.cmbTipRezervacije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipRezervacije_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Datum početka:";
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(6, 149);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(165, 20);
            this.dtpDatumPocetka.TabIndex = 24;
            this.dtpDatumPocetka.ValueChanged += new System.EventHandler(this.dtpDatumPocetka_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vrijeme kraja:";
            // 
            // cmbZavrsetak
            // 
            this.cmbZavrsetak.FormattingEnabled = true;
            this.cmbZavrsetak.Location = new System.Drawing.Point(519, 148);
            this.cmbZavrsetak.Name = "cmbZavrsetak";
            this.cmbZavrsetak.Size = new System.Drawing.Size(165, 21);
            this.cmbZavrsetak.TabIndex = 22;
            this.cmbZavrsetak.SelectedIndexChanged += new System.EventHandler(this.cmbZavrsetak_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vrijeme početka:";
            // 
            // cmbPocetak
            // 
            this.cmbPocetak.FormattingEnabled = true;
            this.cmbPocetak.Location = new System.Drawing.Point(348, 148);
            this.cmbPocetak.Name = "cmbPocetak";
            this.cmbPocetak.Size = new System.Drawing.Size(165, 21);
            this.cmbPocetak.TabIndex = 20;
            this.cmbPocetak.SelectedIndexChanged += new System.EventHandler(this.cmbPocetak_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Teren:";
            // 
            // cmbTeren
            // 
            this.cmbTeren.FormattingEnabled = true;
            this.cmbTeren.Location = new System.Drawing.Point(177, 93);
            this.cmbTeren.Name = "cmbTeren";
            this.cmbTeren.Size = new System.Drawing.Size(165, 21);
            this.cmbTeren.TabIndex = 18;
            this.cmbTeren.SelectedIndexChanged += new System.EventHandler(this.cmbTeren_SelectedIndexChanged);
            this.cmbTeren.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTeren_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sport:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Datum kraja:";
            // 
            // dtpDatumKraja
            // 
            this.dtpDatumKraja.Location = new System.Drawing.Point(177, 149);
            this.dtpDatumKraja.Name = "dtpDatumKraja";
            this.dtpDatumKraja.Size = new System.Drawing.Size(165, 20);
            this.dtpDatumKraja.TabIndex = 32;
            this.dtpDatumKraja.ValueChanged += new System.EventHandler(this.dtpDatumKraja_ValueChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(6, 45);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(336, 20);
            this.txtNaziv.TabIndex = 34;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Naziv:";
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Location = new System.Drawing.Point(348, 43);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(165, 23);
            this.btnDodajTim.TabIndex = 36;
            this.btnDodajTim.Text = "Dodaj tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(519, 42);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(165, 23);
            this.btnGenerisi.TabIndex = 37;
            this.btnGenerisi.Text = "Generiši turnir";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(269, 188);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(165, 37);
            this.btnTabela.TabIndex = 38;
            this.btnTabela.Text = "Prikaži tabelu";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // txtSport
            // 
            this.txtSport.Location = new System.Drawing.Point(6, 93);
            this.txtSport.Name = "txtSport";
            this.txtSport.ReadOnly = true;
            this.txtSport.Size = new System.Drawing.Size(165, 20);
            this.txtSport.TabIndex = 40;
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(6, 196);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(235, 20);
            this.txtKorisnik.TabIndex = 41;
            this.txtKorisnik.Visible = false;
            // 
            // frmDetaljiTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 237);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.txtSport);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDatumKraja);
            this.Controls.Add(this.cbIsPotvrdjen);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipRezervacije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbZavrsetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTeren);
            this.Controls.Add(this.label1);
            this.Name = "frmDetaljiTurnira";
            this.Text = "Novi turnir";
            this.Load += new System.EventHandler(this.frmDetaljiTurnira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsPotvrdjen;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipRezervacije;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbZavrsetak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPocetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumKraja;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.TextBox txtSport;
        private System.Windows.Forms.TextBox txtKorisnik;
    }
}