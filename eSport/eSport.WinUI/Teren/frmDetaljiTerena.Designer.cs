namespace eSport.WinUI
{
    partial class frmDetaljiTerena
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericSatna = new System.Windows.Forms.NumericUpDown();
            this.numericDnevna = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSatna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDnevna)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 39);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(322, 20);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // cmbSport
            // 
            this.cmbSport.FormattingEnabled = true;
            this.cmbSport.Location = new System.Drawing.Point(13, 92);
            this.cmbSport.Name = "cmbSport";
            this.cmbSport.Size = new System.Drawing.Size(323, 21);
            this.cmbSport.TabIndex = 2;
            this.cmbSport.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSport_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sport";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(260, 228);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cijena 1h:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cijena 1d:";
            // 
            // numericSatna
            // 
            this.numericSatna.Location = new System.Drawing.Point(13, 154);
            this.numericSatna.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericSatna.Name = "numericSatna";
            this.numericSatna.Size = new System.Drawing.Size(128, 20);
            this.numericSatna.TabIndex = 9;
            // 
            // numericDnevna
            // 
            this.numericDnevna.Location = new System.Drawing.Point(208, 154);
            this.numericDnevna.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericDnevna.Name = "numericDnevna";
            this.numericDnevna.Size = new System.Drawing.Size(128, 20);
            this.numericDnevna.TabIndex = 10;
            // 
            // frmDetaljiTerena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 263);
            this.Controls.Add(this.numericDnevna);
            this.Controls.Add(this.numericSatna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmDetaljiTerena";
            this.Text = "Teren";
            this.Load += new System.EventHandler(this.frmDetaljiTerena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSatna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDnevna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericDnevna;
        private System.Windows.Forms.NumericUpDown numericSatna;
    }
}