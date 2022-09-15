using eSport.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmDetaljiTerena : Form
    {
        APIService terenService = new APIService(NazivEntiteta.Teren);
        APIService sportService = new APIService(NazivEntiteta.Sport);
        APIService cjenovnikService = new APIService(NazivEntiteta.Cjenovnik);
        APIService tipRezervacijeService = new APIService(NazivEntiteta.TipRezervacije);
        private List<TipRezervacije> tipoviRezervacije;
        private Teren _teren;
        private Cjenovnik _satniCjenovnik;
        private Cjenovnik _dnevniCjenovnik;
        public frmDetaljiTerena(Teren teren = null)
        {
            InitializeComponent();
            _teren = teren;
        }

        private async void frmDetaljiTerena_Load(object sender, EventArgs e)
        {
            await LoadSportove();
            tipoviRezervacije = await tipRezervacijeService.Get<List<Model.TipRezervacije>>(null);
            if (_teren != null)
            {
                txtNaziv.Text = _teren.Naziv;
                cmbSport.SelectedIndex = _teren.SportId;
                var cjenovnici = await cjenovnikService.Get<List<Model.Cjenovnik>>(new CjenovnikSearchRequest() { TerenId = _teren.Id, IncludeList = new[] { "TipRezervacije" } });
                _satniCjenovnik = cjenovnici.FirstOrDefault(x => !x.TipRezervacije.IsDnevna);
                _dnevniCjenovnik = cjenovnici.FirstOrDefault(x => x.TipRezervacije.IsDnevna);
                numericSatna.Value = _satniCjenovnik != null ? _satniCjenovnik.Cijena : 0;
                numericDnevna.Value = _dnevniCjenovnik != null ? _dnevniCjenovnik.Cijena : 0;
            }
        }

        private async Task LoadSportove()
        {
            var sportovi = await sportService.Get<List<Sport>>();
            sportovi.Insert(0, new Sport());
            cmbSport.DataSource = sportovi;
            cmbSport.DisplayMember = "Naziv";
            cmbSport.ValueMember = "Id";
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                try
                {
                    var sport = cmbSport.SelectedItem as Sport;
                    TerenInsertRequest request = new TerenInsertRequest
                    {
                        Naziv = txtNaziv.Text,
                        SportId = sport.Id
                    };
                    CjenovnikInsertRequest satniCjenovnik = new CjenovnikInsertRequest
                    {
                        Cijena = Convert.ToInt32(numericSatna.Text),
                        TipRezervacijeId = tipoviRezervacije.FirstOrDefault(x=>!x.IsDnevna).Id
                    };
                    CjenovnikInsertRequest dnevniCjenovnik = new CjenovnikInsertRequest
                    {
                        Cijena = Convert.ToInt32(numericDnevna.Text),
                        TipRezervacijeId = tipoviRezervacije.FirstOrDefault(x=>x.IsDnevna).Id
                    };
                    if (_teren == null)
                    {
                        var teren = await terenService.Insert<Teren>(request);
                        satniCjenovnik.TerenId = teren.Id;
                        dnevniCjenovnik.TerenId = teren.Id;
                        await cjenovnikService.Insert<Cjenovnik>(satniCjenovnik);
                        await cjenovnikService.Insert<Cjenovnik>(dnevniCjenovnik);
                    }
                    else
                    {
                        var teren = await terenService.Update<Teren>(_teren.Id, request);
                        satniCjenovnik.TerenId = _teren.Id;
                        dnevniCjenovnik.TerenId = _teren.Id;
                        await cjenovnikService.Update<Cjenovnik>(_satniCjenovnik.Id, satniCjenovnik);
                        await cjenovnikService.Update<Cjenovnik>(_dnevniCjenovnik.Id, dnevniCjenovnik);
                    }
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

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidacijaObaveznoPolje(errorProvider, txtNaziv, e);
        }

        private void cmbSport_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbSport, e);
        }

    }
}
