
namespace eSport.WinUI
{
    partial class frmDetaljiTermina
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
            this.cmbSport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeren = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPocetak = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbZavrsetak = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipRezervacije = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbIsPotvrdjen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSport
            // 
            this.cmbSport.FormattingEnabled = true;
            this.cmbSport.Location = new System.Drawing.Point(13, 43);
            this.cmbSport.Name = "cmbSport";
            this.cmbSport.Size = new System.Drawing.Size(165, 21);
            this.cmbSport.TabIndex = 0;
            this.cmbSport.SelectedIndexChanged += new System.EventHandler(this.cmbSport_SelectedIndexChanged);
            this.cmbSport.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSport_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teren:";
            // 
            // cmbTeren
            // 
            this.cmbTeren.FormattingEnabled = true;
            this.cmbTeren.Location = new System.Drawing.Point(184, 43);
            this.cmbTeren.Name = "cmbTeren";
            this.cmbTeren.Size = new System.Drawing.Size(165, 21);
            this.cmbTeren.TabIndex = 2;
            this.cmbTeren.SelectedIndexChanged += new System.EventHandler(this.cmbTeren_SelectedIndexChanged);
            this.cmbTeren.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTeren_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijeme početka:";
            // 
            // cmbPocetak
            // 
            this.cmbPocetak.FormattingEnabled = true;
            this.cmbPocetak.Location = new System.Drawing.Point(12, 100);
            this.cmbPocetak.Name = "cmbPocetak";
            this.cmbPocetak.Size = new System.Drawing.Size(165, 21);
            this.cmbPocetak.TabIndex = 4;
            this.cmbPocetak.SelectedIndexChanged += new System.EventHandler(this.cmbPocetak_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme završetka:";
            // 
            // cmbZavrsetak
            // 
            this.cmbZavrsetak.FormattingEnabled = true;
            this.cmbZavrsetak.Location = new System.Drawing.Point(184, 100);
            this.cmbZavrsetak.Name = "cmbZavrsetak";
            this.cmbZavrsetak.Size = new System.Drawing.Size(165, 21);
            this.cmbZavrsetak.TabIndex = 6;
            this.cmbZavrsetak.SelectedIndexChanged += new System.EventHandler(this.cmbZavrsetak_SelectedIndexChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(526, 43);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tip rezervacije:";
            // 
            // cmbTipRezervacije
            // 
            this.cmbTipRezervacije.FormattingEnabled = true;
            this.cmbTipRezervacije.Location = new System.Drawing.Point(355, 43);
            this.cmbTipRezervacije.Name = "cmbTipRezervacije";
            this.cmbTipRezervacije.Size = new System.Drawing.Size(165, 21);
            this.cmbTipRezervacije.TabIndex = 10;
            this.cmbTipRezervacije.SelectedIndexChanged += new System.EventHandler(this.cmbTipRezervacije_SelectedIndexChanged);
            this.cmbTipRezervacije.Validating += new System.ComponentModel.CancelEventHandler(this.cmbTipRezervacije_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cijena (KM):";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(355, 101);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(165, 20);
            this.txtCijena.TabIndex = 13;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(526, 159);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 37);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbIsPotvrdjen
            // 
            this.cbIsPotvrdjen.AutoSize = true;
            this.cbIsPotvrdjen.Location = new System.Drawing.Point(526, 103);
            this.cbIsPotvrdjen.Name = "cbIsPotvrdjen";
            this.cbIsPotvrdjen.Size = new System.Drawing.Size(71, 17);
            this.cbIsPotvrdjen.TabIndex = 15;
            this.cbIsPotvrdjen.Text = "Potvrdjen";
            this.cbIsPotvrdjen.UseVisualStyleBackColor = true;
            // 
            // frmDetaljiTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 213);
            this.Controls.Add(this.cbIsPotvrdjen);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipRezervacije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbZavrsetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTeren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSport);
            this.Name = "frmDetaljiTermina";
            this.Text = "Novi termin";
            this.Load += new System.EventHandler(this.frmDetaljiTermina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPocetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbZavrsetak;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipRezervacije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbIsPotvrdjen;
    }
}