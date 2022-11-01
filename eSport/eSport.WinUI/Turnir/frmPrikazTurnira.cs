using eSport.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmPrikazTurnira : Form
    {
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        APIService _turnirService = new APIService(NazivEntiteta.Turnir);
        bool _aktivni;
        public frmPrikazTurnira(bool aktivni = true)
        {
            InitializeComponent();
            dgvTurniri.AutoGenerateColumns = false;
            _aktivni = aktivni;
            if (aktivni)
                gbTurniri.Text = "Aktivni turniri";
            else
                gbTurniri.Text = "Historija turnira";
        }
        private async Task LoadTerene()
        {
            var tereni = await _terenService.Get<List<Teren>>();
            tereni.Insert(0, new Teren());
            cmbTereni.DataSource = tereni;
            cmbTereni.DisplayMember = "Naziv";
            cmbTereni.ValueMember = "Id";
        }

        private async void frmPrikazTurnira_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadTerene();
                TurnirSearchRequest searchRequest = new TurnirSearchRequest
                {
                    IncludeList = new string[] { NazivEntiteta.Teren }
                };
                if (_aktivni)
                    searchRequest.OdDatuma = DateTime.Now;
                else
                    searchRequest.DoDatuma = DateTime.Now;
                dgvTurniri.DataSource = await _turnirService.Get<List<Model.Turnir>>(searchRequest);
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
                TurnirSearchRequest searchRequest = new TurnirSearchRequest
                {
                    IncludeList = new string[] { NazivEntiteta.Teren },
                    TerenId = terenId
                };

                dgvTurniri.DataSource = await _turnirService.Get<List<Model.Turnir>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }

        private void btnNoviTurnir_Click(object sender, EventArgs e)
        {
            frmDetaljiTurnira frmDetaljiTurnira = new frmDetaljiTurnira();
            if (frmDetaljiTurnira.ShowDialog() == DialogResult.OK)
            {
                dgvTurniri.DataSource = null;
                frmPrikazTurnira_Load(sender, e);
            }
        }

        private void dgvTurniri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var turnir = dgvTurniri.SelectedRows[0].DataBoundItem as Turnir;
            frmDetaljiTurnira frmDetaljiTurnira = new frmDetaljiTurnira(turnir);
            if (frmDetaljiTurnira.ShowDialog() == DialogResult.OK)
            {
                dgvTurniri.DataSource = null;
                frmPrikazTurnira_Load(sender, e);
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmOdabirIzvjestaja frmOdabirIzvjestaja = new frmOdabirIzvjestaja(false);
            if (frmOdabirIzvjestaja.ShowDialog() == DialogResult.OK)
            {
                dgvTurniri.DataSource = null;
                frmPrikazTurnira_Load(sender, e);
            }
        }
    }
}
