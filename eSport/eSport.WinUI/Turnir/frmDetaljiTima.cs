using eSport.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmDetaljiTima : Form
    {
        APIService _timService = new APIService(NazivEntiteta.Tim);
        private Turnir _turnir;
        private Tim _tim;
        private TimSearchRequest searchRequest;
        public frmDetaljiTima(Turnir turnir = null, Tim tim = null)
        {
            InitializeComponent();
            dgvTimovi.AutoGenerateColumns = false;
            _turnir = turnir;
            _tim = tim;
            searchRequest = new TimSearchRequest()
            {
                TurnirId = _turnir?.Id,
            };
        }

        private async void frmDetaljiTima_Load(object sender, System.EventArgs e)
        {
            if (_tim != null)
                txtNaziv.Text = _tim.Naziv;
            dgvTimovi.DataSource = await _timService.Get<List<Tim>>(searchRequest);
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
                    dgvTimovi.DataSource = await _timService.Get<List<Tim>>(searchRequest);
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
