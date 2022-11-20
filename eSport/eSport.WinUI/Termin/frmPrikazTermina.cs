using System;
using eSport.Model;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace eSport.WinUI
{
    public partial class frmPrikazTermina : Form
    {
        APIService _terminService = new APIService(NazivEntiteta.Termin);
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        bool _aktivni;
        public frmPrikazTermina(bool aktivni = true)
        {
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
            _aktivni = aktivni;
            if (aktivni)
                gbTermini.Text = "Aktivni termini";
            else
                gbTermini.Text = "Historija termina";
        }

        private async Task LoadTerene()
        {
            var tereni = await _terenService.Get<List<Teren>>();
            tereni.Insert(0, new Teren());
            cmbTereni.DataSource = tereni;
            cmbTereni.DisplayMember = "Naziv";
            cmbTereni.ValueMember = "Id";
        }

        private async void frmPrikazTermina_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadTerene();
                TerminSearchRequest searchRequest = new TerminSearchRequest
                {
                    IncludeList = new string[] { NazivEntiteta.Teren, NazivEntiteta.Korisnik }
                };
                if (_aktivni)
                    searchRequest.OdDatuma = DateTime.Now;
                else
                    searchRequest.DoDatuma = DateTime.Now;
                dgvTermini.DataSource = await _terminService.Get<List<Model.Termin>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            } 
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                var teren = cmbTereni.SelectedItem as Teren;
                int? terenId = teren?.Id;
                if (terenId == 0)
                    terenId = null;
                TerminSearchRequest searchRequest = new TerminSearchRequest
                {
                    IncludeList = new string[] { NazivEntiteta.Teren, NazivEntiteta.Korisnik },
                    OdDatuma = DateTime.Now,
                    TerenId = terenId
                };

                dgvTermini.DataSource = await _terminService.Get<List<Model.Termin>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            frmDetaljiTermina frmDetaljiTermina = new frmDetaljiTermina();
            if (frmDetaljiTermina.ShowDialog() == DialogResult.OK)
            {
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);
            }
        }

        private async void dgvTermini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var termin = dgvTermini.SelectedRows[0].DataBoundItem as Termin;
            if(e.ColumnIndex != 5)
            {
                frmDetaljiTermina frmDetaljiTermina = new frmDetaljiTermina(termin);
                if (frmDetaljiTermina.ShowDialog() == DialogResult.OK)
                {
                    dgvTermini.DataSource = null;
                    frmPrikazTermina_Load(sender, e);
                }
            }
            else
            {
                await _terminService.Delete<Model.Termin>(termin.Id);
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmOdabirIzvjestaja frmOdabirIzvjestaja = new frmOdabirIzvjestaja(true);
            if (frmOdabirIzvjestaja.ShowDialog() == DialogResult.OK)
            {
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);
            }
        }
    }
}
