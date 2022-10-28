using System;
using eSport.Model;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmDetaljiUtakmice : Form
    {
        private Utakmica _utakmica;
        private APIService _utakmicaService = new APIService(NazivEntiteta.Utakmica);
        public frmDetaljiUtakmice(Utakmica utakmica)
        {
            InitializeComponent();
            _utakmica = utakmica;
        }

        private void frmDetaljiUtakmice_Load(object sender, EventArgs e)
        {
            if(_utakmica != null)
            {
                txtDomacin.Text = _utakmica.DomacinNaziv;
                txtGost.Text = _utakmica.GostNaziv;
                nmDomacin.Value = _utakmica.BrojGolovaDomacina;
                nmGost.Value = _utakmica.BrojGolovaGosta;
                cbIsZavrsena.Checked = _utakmica.IsZavrsena;
                dtpDatum.Value = _utakmica.VrijemeUtakmice;
                if(_utakmica.IsZavrsena)
                {
                    txtDomacin.Enabled = false;
                    txtGost.Enabled = false;
                    nmDomacin.Enabled = false;
                    nmGost.Enabled = false;
                    cbIsZavrsena.Enabled = false;
                    dtpDatum.Enabled = false;
                    btnSacuvaj.Visible = false;
                }
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                UtakmicaInsertRequest request = new UtakmicaInsertRequest
                {
                    BrojGolovaDomacina = (int)nmDomacin.Value,
                    BrojGolovaGosta = (int)nmGost.Value,
                    IsZavrsena = cbIsZavrsena.Checked,
                    DomacinId = _utakmica.DomacinId,
                    GostId = _utakmica.GostId,
                    TurnirId = _utakmica.TurnirId,
                    VrijemeUtakmice = dtpDatum.Value
                };
                Utakmica utakmica = null;
                utakmica = await _utakmicaService.Update<Utakmica>(_utakmica.Id, request);
                MessageBox.Show(Properties.Resources.UspješnaOperacija);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }
    }
}
