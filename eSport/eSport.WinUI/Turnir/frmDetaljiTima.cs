using eSport.Model;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmDetaljiTima : Form
    {
        APIService _timService = new APIService(NazivEntiteta.Tim);
        private Turnir _turnir;
        private Tim _tim;
        public frmDetaljiTima(Turnir turnir = null, Tim tim = null)
        {
            InitializeComponent();
            _turnir = turnir;
            _tim = tim;
        }

        private void frmDetaljiTima_Load(object sender, System.EventArgs e)
        {
            if (_tim != null)
                txtNaziv.Text = _tim.Naziv;
        }

        private async void btnSacuvaj_Click(object sender, System.EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    TimInsertRequest request = new TimInsertRequest
                    {
                        TurnirId = _turnir.Id,
                        Naziv = txtNaziv.Text
                    };
                    Tim tim = null;
                    if (_tim == null)
                    {
                        tim = await _timService.Insert<Tim>(request);
                    }
                    else
                    {
                        tim = await _timService.Update<Tim>(_tim.Id, request);
                    }
                    MessageBox.Show(Properties.Resources.UspješnaOperacija);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(Properties.Resources.Greška);
                }
            }
        }

        private void txtNaziv_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidacijaObaveznoPolje(errorProvider, txtNaziv, e);
        }
    }
}
