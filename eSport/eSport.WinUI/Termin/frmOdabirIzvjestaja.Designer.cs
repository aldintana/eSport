namespace eSport.WinUI
{
    partial class frmOdabirIzvjestaja
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
            this.cmbSport = new System.Windows.Forms.ComboBox();
            this.cmbTeren = new System.Windows.Forms.ComboBox();
            this.dtpOdDatuma = new System.Windows.Forms.DateTimePicker();
            this.dtpDoDatuma = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSport
            // 
            this.cmbSport.FormattingEnabled = true;
            this.cmbSport.Location = new System.Drawing.Point(13, 33);
            this.cmbSport.Name = "cmbSport";
            this.cmbSport.Size = new System.Drawing.Size(200, 21);
            this.cmbSport.TabIndex = 0;
            this.cmbSport.SelectedIndexChanged += new System.EventHandler(this.cmbSport_SelectedIndexChanged);
            // 
            // cmbTeren
            // 
            this.cmbTeren.FormattingEnabled = true;
            this.cmbTeren.Location = new System.Drawing.Point(219, 33);
            this.cmbTeren.Name = "cmbTeren";
            this.cmbTeren.Size = new System.Drawing.Size(200, 21);
            this.cmbTeren.TabIndex = 1;
            // 
            // dtpOdDatuma
            // 
            this.dtpOdDatuma.Location = new System.Drawing.Point(13, 82);
            this.dtpOdDatuma.Name = "dtpOdDatuma";
            this.dtpOdDatuma.Size = new System.Drawing.Size(200, 20);
            this.dtpOdDatuma.TabIndex = 2;
            // 
            // dtpDoDatuma
            // 
            this.dtpDoDatuma.Location = new System.Drawing.Point(219, 82);
            this.dtpDoDatuma.Name = "dtpDoDatuma";
            this.dtpDoDatuma.Size = new System.Drawing.Size(200, 20);
            this.dtpDoDatuma.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sport:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teren:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Od datuma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do datuma:";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(310, 125);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(108, 23);
            this.btnGenerisi.TabIndex = 8;
            this.btnGenerisi.Text = "Generiši izvještaj";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // frmOdabirIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 173);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDoDatuma);
            this.Controls.Add(this.dtpOdDatuma);
            this.Controls.Add(this.cmbTeren);
            this.Controls.Add(this.cmbSport);
            this.Name = "frmOdabirIzvjestaja";
            this.Text = "Izvještaj";
            this.Load += new System.EventHandler(this.frmOdabirIzvjestaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSport;
        private System.Windows.Forms.ComboBox cmbTeren;
        private System.Windows.Forms.DateTimePicker dtpOdDatuma;
        private System.Windows.Forms.DateTimePicker dtpDoDatuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerisi;
    }
}