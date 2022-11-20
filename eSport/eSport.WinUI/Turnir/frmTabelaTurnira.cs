using System;
using eSport.Model;
using System.Windows.Forms;
using System.Collections.Generic;

namespace eSport.WinUI
{
    public partial class frmTabelaTurnira : Form
    {
        APIService _timService = new APIService(NazivEntiteta.Tim);
        Turnir _turnir = null;
        public frmTabelaTurnira(Turnir turnir = null)
        {
            InitializeComponent();
            dgvTimovi.AutoGenerateColumns = false;
            _turnir = turnir;
            if(_turnir != null)
            {
                txtNaziv.Text = _turnir.Naziv;
            }
        }

        private async void frmTablicaTurnira_Load(object sender, System.EventArgs e)
        {
            try
            {
                var searchRequest = new TimSearchRequest
                {
                    TurnirId = _turnir.Id,
                };
                dgvTimovi.DataSource = await _timService.Get<List<Model.Tim>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }

        private void btnPrikaziUtakmice_Click(object sender, EventArgs e)
        {
            frmPrikazUtakmica frmPrikazUtakmica = new frmPrikazUtakmica(_turnir);
            if (frmPrikazUtakmica.ShowDialog() == DialogResult.Cancel)
            {
                dgvTimovi.DataSource = null;
                frmTablicaTurnira_Load(sender, e);
            }
        }
    }
}
