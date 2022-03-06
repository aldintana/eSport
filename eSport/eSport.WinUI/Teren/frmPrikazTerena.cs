using eSport.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmPrikazTerena : Form
    {
        APIService _serviceTereni = new APIService("Teren");
        public frmPrikazTerena()
        {
            InitializeComponent();
            dgvTereni.AutoGenerateColumns = false;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            TerenSearchRequest searchRequest = new TerenSearchRequest
            {
                Naziv = txtPretraga.Text,
                IncludeList = new string[]
                {
                    "Sport"
                }
            };

            dgvTereni.DataSource = await _serviceTereni.Get<List<Model.Teren>>(searchRequest);
        }

        private async void frmPrikazTerena_Load(object sender, EventArgs e)
        {
            var searchRequest = new TerenSearchRequest
            {
                IncludeList = new string[]
                {
                    "Sport"
                }
            };

            dgvTereni.DataSource = await _serviceTereni.Get<List<Model.Teren>>(searchRequest);
        }

        private void dgvTereni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var teren = dgvTereni.SelectedRows[0].DataBoundItem;

            frmDetaljiTerena frm = new frmDetaljiTerena(teren as Teren);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvTereni.DataSource = null;
                frmPrikazTerena_Load(sender, e);
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
