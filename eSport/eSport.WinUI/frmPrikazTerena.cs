using eSport.Model.Requests;
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
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            TerenSearchRequest searchRequest = new TerenSearchRequest
            {
                Naziv = txtPretraga.Text
            };

            dgvTereni.DataSource = await _serviceTereni.Get<List<Model.Teren>>(searchRequest);
        }

        private async void frmPrikazTerena_Load(object sender, EventArgs e)
        {
            dgvTereni.DataSource = await _serviceTereni.Get<List<Model.Teren>>(null);
        }
    }
}
