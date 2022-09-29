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
        public frmPrikazTurnira()
        {
            InitializeComponent();
            dgvTurniri.AutoGenerateColumns = false;
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
    }
}
