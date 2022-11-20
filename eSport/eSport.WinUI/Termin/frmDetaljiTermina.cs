using eSport.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmDetaljiTermina : Form
    {
        private List<int> pocetak = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
        private List<int> zavrsetak = new List<int> {10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        APIService _sportService = new APIService(NazivEntiteta.Sport);
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        APIService _cjenovnikService = new APIService(NazivEntiteta.Cjenovnik);
        APIService _terminService = new APIService(NazivEntiteta.Termin);
        private Termin _termin;
        public frmDetaljiTermina(Termin termin = null)
        {
            InitializeComponent();
            _termin = termin;
        }

        private async void frmDetaljiTermina_Load(object sender, EventArgs e)
        {
            await LoadSportove();
            cmbPocetak.DataSource = pocetak;
            cmbZavrsetak.DataSource = zavrsetak;
            if(_termin != null)
            {
                await LoadTerene(_termin.TerenId);
                cmbPocetak.SelectedItem = _termin.Pocetak.Hour;
                cmbZavrsetak.SelectedItem = _termin.Kraj.Hour;
                dtpDatum.Value = _termin.Datum;
                cmbSport.SelectedValue = _termin.Teren.SportId;
                cbIsPotvrdjen.Checked = _termin.IsPotvrdjen;
                if(_termin.Korisnik != null)
                {
                    txtKorisnik.Visible = true;
                    txtKorisnik.Text = $"Korisnik: {_termin.Korisnik.ImeIPrezime}";
                }
                if (cbIsPotvrdjen.Checked)
                    cbIsPotvrdjen.Enabled = false;
            }
        }

        private async Task LoadSportove()
        {
            var sportovi = await _sportService.Get<List<Sport>>();
            sportovi.Insert(0, new Sport());
            cmbSport.DataSource = sportovi;
            cmbSport.DisplayMember = "Naziv";
            cmbSport.ValueMember = "Id";
        }

        private async Task LoadTerene(int? sportId = null, int? terenId = null)
        {
            TerenSearchRequest searchRequest = new TerenSearchRequest
            {
                SportId = sportId
            };
            var tereni = await _terenService.Get<List<Teren>>(searchRequest);
            cmbTeren.DataSource = tereni;
            if (tereni != null && tereni.Count == 0)
            {
                cmbTeren.DataSource = null;
                cmbTeren.SelectedItem = null;
                cmbTeren.ResetText();
            }
            cmbTeren.DisplayMember = "Naziv";
            cmbTeren.ValueMember = "Id";
            if (terenId != null)
                cmbTeren.SelectedValue = terenId;
        }

        private async Task LoadCjenovnik(int? terenId = null, int? cjenovnikId = null)
        {
            CjenovnikSearchRequest searchRequest = new CjenovnikSearchRequest
            {
                TerenId = terenId,
                IncludeList = new string[] { "TipRezervacije" }
            };
            var cjenovnici = await _cjenovnikService.Get<List<Cjenovnik>>(searchRequest);
            cmbTipRezervacije.DataSource = cjenovnici;
            if (cjenovnici != null && cjenovnici.Count == 0)
            {
                cmbTipRezervacije.DataSource = null;
                cmbTipRezervacije.SelectedItem = null;
                cmbTipRezervacije.ResetText();
            }
            cmbTipRezervacije.DisplayMember = "Naziv";
            cmbTipRezervacije.ValueMember = "Id";
            if (cjenovnikId != null)
                cmbTipRezervacije.SelectedValue = cjenovnikId;
        }

        private async void cmbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var sport = comboBox.SelectedItem as Sport;
            if(sport != null)
            {
                if (_termin?.Teren?.SportId != sport.Id)
                    await LoadTerene(sport.Id);
                else
                    await LoadTerene(sport.Id, _termin.Teren.Id);
            }
        }

        private async void cmbTeren_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var teren = comboBox.SelectedItem as Teren;
            if (teren != null)
            {
                if (_termin?.TerenId != teren.Id)
                    await LoadCjenovnik(teren.Id);
                else
                    await LoadCjenovnik(teren.Id, _termin.CjenovnikId);
            }
        }

        private void cmbPocetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var start = comboBox.SelectedItem as int?;
            if(start != null)
            {
                var index = zavrsetak.IndexOf(start.GetValueOrDefault());
                var noviZavrsetak = zavrsetak.Skip(index + 1);
                cmbZavrsetak.DataSource = noviZavrsetak.ToList();
                IzracunajCijenu();
            }
        }

        private void cmbTipRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzracunajCijenu();
        }

        private void cmbZavrsetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzracunajCijenu();
        }

        private void IzracunajCijenu()
        {
            var cjenovnik = cmbTipRezervacije.SelectedItem as Cjenovnik;
            var pocetna = cmbPocetak.SelectedItem as int?;
            var kraj = cmbZavrsetak.SelectedItem as int?;
            if(cjenovnik != null && pocetna != null && kraj != null)
            {
                if(cjenovnik.TipRezervacije.IsDnevna)
                {
                    txtCijena.Text = cjenovnik.Cijena.ToString();
                }
                else
                {
                    var cijena = (kraj.GetValueOrDefault() - pocetna.GetValueOrDefault()) * cjenovnik.Cijena;
                    txtCijena.Text = cijena.ToString();
                }
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    var cjenovnik = cmbTipRezervacije.SelectedItem as Cjenovnik;
                    var teren = cmbTeren.SelectedItem as Teren;
                    var pocetna = cmbPocetak.SelectedItem as int?;
                    var kraj = cmbZavrsetak.SelectedItem as int?;
                    var datum = dtpDatum.Value.Date;
                    var pocetakDatum = new DateTime(datum.Year, datum.Month, datum.Day, pocetna.GetValueOrDefault(), 0, 0);
                    var krajDatum = new DateTime(datum.Year, datum.Month, datum.Day, kraj.GetValueOrDefault(), 0, 0);

                    TerminInsertRequest request = new TerminInsertRequest
                    {
                        CjenovnikId = cjenovnik.Id,
                        TerenId = teren.Id,
                        IsPotvrdjen = cbIsPotvrdjen.Checked,
                        Datum = dtpDatum.Value,
                        Pocetak = pocetakDatum,
                        Kraj = krajDatum,
                        UkupnaCijena = Convert.ToInt32(txtCijena.Text)
                    };
                    Termin termin = null;
                    if(_termin == null)
                    {
                        termin = await _terminService.Insert<Termin>(request);
                    }
                    else
                    {
                        termin = await _terminService.Update<Termin>(_termin.Id, request);
                    }
                    if (termin == null)
                    {
                        MessageBox.Show(Properties.Resources.Zauzeto);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.UspješnaOperacija);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show(Properties.Resources.Greška);
                }
            }
        }

        private void cmbSport_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbSport, e);
        }

        private void cmbTeren_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbTeren, e);
        }

        private void cmbTipRezervacije_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbTipRezervacije, e);
        }
    }
}
