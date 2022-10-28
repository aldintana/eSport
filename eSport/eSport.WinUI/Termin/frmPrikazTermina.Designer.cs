
namespace eSport.WinUI
{
    partial class frmPrikazTermina
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
            this.btnNoviTermin = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTereni = new System.Windows.Forms.ComboBox();
            this.gbTermini = new System.Windows.Forms.GroupBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerenNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbTermini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoviTermin);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTereni);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga termina";
            // 
            // btnNoviTermin
            // 
            this.btnNoviTermin.Location = new System.Drawing.Point(695, 34);
            this.btnNoviTermin.Name = "btnNoviTermin";
            this.btnNoviTermin.Size = new System.Drawing.Size(75, 23);
            this.btnNoviTermin.TabIndex = 3;
            this.btnNoviTermin.Text = "Novi termin";
            this.btnNoviTermin.UseVisualStyleBackColor = true;
            this.btnNoviTermin.Click += new System.EventHandler(this.btnNoviTermin_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(614, 34);
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
            // gbTermini
            // 
            this.gbTermini.Controls.Add(this.dgvTermini);
            this.gbTermini.Location = new System.Drawing.Point(12, 82);
            this.gbTermini.Name = "gbTermini";
            this.gbTermini.Size = new System.Drawing.Size(776, 356);
            this.gbTermini.TabIndex = 1;
            this.gbTermini.TabStop = false;
            this.gbTermini.Text = "Termini";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Pocetak,
            this.Kraj,
            this.TerenNaziv,
            this.UkupnaCijena});
            this.dgvTermini.Location = new System.Drawing.Point(7, 20);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(763, 330);
            this.dgvTermini.TabIndex = 0;
            this.dgvTermini.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellClick);
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Pocetak
            // 
            this.Pocetak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pocetak.DataPropertyName = "Pocetak";
            this.Pocetak.HeaderText = "Pocetak";
            this.Pocetak.Name = "Pocetak";
            this.Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            this.Kraj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kraj.DataPropertyName = "Kraj";
            this.Kraj.HeaderText = "Kraj";
            this.Kraj.Name = "Kraj";
            this.Kraj.ReadOnly = true;
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
            // frmPrikazTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTermini);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazTermina";
            this.Text = "Prikaz termina";
            this.Load += new System.EventHandler(this.frmPrikazTermina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTermini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbTermini;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerenNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.ComboBox cmbTereni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnNoviTermin;
    }
}