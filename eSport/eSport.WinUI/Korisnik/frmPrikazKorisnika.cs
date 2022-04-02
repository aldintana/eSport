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

namespace eSport.WinUI.Korisnik
{
    public partial class frmPrikazKorisnika : Form
    {
        private readonly APIService _serviceKorisnici = new APIService(NazivEntiteta.Korisnik);
        public frmPrikazKorisnika()
        {
            InitializeComponent();
            this.dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void frmPrikazKorisnika_Load(object sender, EventArgs e)
        {
            var searchRequest = new BaseSearchRequest
            {
                TekstPretraga = txtPretraga.Text,
                IncludeList = new string[]
                {
                    NazivEntiteta.KorisnikUlogaUloga
                },
            };
            try
            {
                dgvKorisnici.DataSource = await _serviceKorisnici.Get<List<Model.Korisnik>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
            
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            frmPrikazKorisnika_Load(sender, e);
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem;
            frmDetaljiKorisnika frm = new frmDetaljiKorisnika(korisnik as Model.Korisnik);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvKorisnici.DataSource = null;
                frmPrikazKorisnika_Load(sender, e);
            }
        }
    }
}
