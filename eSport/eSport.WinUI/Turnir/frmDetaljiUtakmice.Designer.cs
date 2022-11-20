
namespace eSport.WinUI
{
    partial class frmDetaljiUtakmice
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nmDomacin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmGost = new System.Windows.Forms.NumericUpDown();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtDomacin = new System.Windows.Forms.TextBox();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.cbIsZavrsena = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmDomacin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domaćin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gost:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(10, 30);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(342, 20);
            this.dtpDatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum:";
            // 
            // nmDomacin
            // 
            this.nmDomacin.Location = new System.Drawing.Point(10, 115);
            this.nmDomacin.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmDomacin.Name = "nmDomacin";
            this.nmDomacin.Size = new System.Drawing.Size(163, 20);
            this.nmDomacin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rezultat";
            // 
            // nmGost
            // 
            this.nmGost.Location = new System.Drawing.Point(190, 115);
            this.nmGost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmGost.Name = "nmGost";
            this.nmGost.Size = new System.Drawing.Size(163, 20);
            this.nmGost.TabIndex = 13;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(277, 154);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtDomacin
            // 
            this.txtDomacin.Location = new System.Drawing.Point(10, 73);
            this.txtDomacin.Name = "txtDomacin";
            this.txtDomacin.ReadOnly = true;
            this.txtDomacin.Size = new System.Drawing.Size(163, 20);
            this.txtDomacin.TabIndex = 17;
            // 
            // txtGost
            // 
            this.txtGost.Location = new System.Drawing.Point(189, 73);
            this.txtGost.Name = "txtGost";
            this.txtGost.ReadOnly = true;
            this.txtGost.Size = new System.Drawing.Size(163, 20);
            this.txtGost.TabIndex = 18;
            // 
            // cbIsZavrsena
            // 
            this.cbIsZavrsena.AutoSize = true;
            this.cbIsZavrsena.Location = new System.Drawing.Point(193, 158);
            this.cbIsZavrsena.Name = "cbIsZavrsena";
            this.cbIsZavrsena.Size = new System.Drawing.Size(71, 17);
            this.cbIsZavrsena.TabIndex = 19;
            this.cbIsZavrsena.Text = "Završena";
            this.cbIsZavrsena.UseVisualStyleBackColor = true;
            // 
            // frmDetaljiUtakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 190);
            this.Controls.Add(this.cbIsZavrsena);
            this.Controls.Add(this.txtGost);
            this.Controls.Add(this.txtDomacin);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.nmGost);
            this.Controls.Add(this.nmDomacin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDetaljiUtakmice";
            this.Text = "Nova utakmica";
            this.Load += new System.EventHandler(this.frmDetaljiUtakmice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmDomacin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmDomacin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmGost;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtDomacin;
        private System.Windows.Forms.TextBox txtGost;
        private System.Windows.Forms.CheckBox cbIsZavrsena;
    }
}