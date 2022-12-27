using System;
using eSport.Model;
using System.Windows.Forms;
using eSport.WinUI.Properties;
using System.Collections.Generic;

namespace eSport.WinUI
{
    public partial class frmPrikazTerena : Form
    {
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        public frmPrikazTerena()
        {
            InitializeComponent();
            dgvTereni.AutoGenerateColumns = false;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            TerenSearchRequest searchRequest = new TerenSearchRequest
            {
                TekstPretraga = txtPretraga.Text,
                IncludeList = new string[]
                {
                    NazivEntiteta.Sport
                }
            };

            dgvTereni.DataSource = await _terenService.Get<List<Model.Teren>>(searchRequest);
        }

        private async void frmPrikazTerena_Load(object sender, EventArgs e)
        {
            try
            {
                var searchRequest = new TerenSearchRequest
                {
                    IncludeList = new string[]
                    {
                        NazivEntiteta.Sport
                    }
                };

                dgvTereni.DataSource = await _terenService.Get<List<Model.Teren>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
            
        }

        private async void dgvTereni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var teren = dgvTereni.SelectedRows[0].DataBoundItem as Teren;

            if (e.ColumnIndex != 2)
            {
                frmDetaljiTerena frm = new frmDetaljiTerena(teren);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvTereni.DataSource = null;
                    frmPrikazTerena_Load(sender, e);
                }
            }
            else
            {
                var obrisaniTeren = await _terenService.Delete<Model.Teren>(teren.Id);
                if(obrisaniTeren != null)
                {
                    dgvTereni.DataSource = null;
                    frmPrikazTerena_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(Resources.GreškaUBrisanjuTerena);
                }
            }
        }

        private void btnDodajTeren_Click(object sender, EventArgs e)
        {
            frmDetaljiTerena frm = new frmDetaljiTerena();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvTereni.DataSource = null;
                frmPrikazTerena_Load(sender, e);
            }
        }
    }
}
