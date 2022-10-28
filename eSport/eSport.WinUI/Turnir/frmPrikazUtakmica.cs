using System;
using eSport.Model;
using System.Windows.Forms;
using System.Collections.Generic;

namespace eSport.WinUI
{
    public partial class frmPrikazUtakmica : Form
    {
        APIService _utakmicaService = new APIService(NazivEntiteta.Utakmica);
        Turnir _turnir = null;
        public frmPrikazUtakmica(Turnir turnir = null)
        {
            InitializeComponent();
            dgvUtakmice.AutoGenerateColumns = false;
            _turnir = turnir;
            if (_turnir != null)
            {
                txtNaziv.Text = _turnir.Naziv;
            }
        }

        private async void frmPrikazUtakmica_Load(object sender, System.EventArgs e)
        {
            try
            {
                var searchRequest = new UtakmicaSearchRequest
                {
                    TurnirId = _turnir.Id,
                    IncludeList = new string[]
                    {
                        "Domacin", "Gost"
                    }
                };
                dgvUtakmice.DataSource = await _utakmicaService.Get<List<Model.Utakmica>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }

        private void dgvUtakmice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var utakmica = dgvUtakmice.SelectedRows[0].DataBoundItem as Utakmica;
            frmDetaljiUtakmice frmDetaljiUtakmice = new frmDetaljiUtakmice(utakmica);
            if(frmDetaljiUtakmice.ShowDialog()==DialogResult.OK)
            {
                dgvUtakmice.DataSource = null;
                frmPrikazUtakmica_Load(sender, e);
            }
        }
    }
}
