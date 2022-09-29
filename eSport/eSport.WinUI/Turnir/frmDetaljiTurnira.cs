using System;
using System.Linq;
using eSport.Model;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace eSport.WinUI
{
    public partial class frmDetaljiTurnira : Form
    {
        private List<int> pocetak = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
        private List<int> zavrsetak = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
        APIService _sportService = new APIService(NazivEntiteta.Sport);
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        APIService _cjenovnikService = new APIService(NazivEntiteta.Cjenovnik);
        APIService _turnirService = new APIService(NazivEntiteta.Turnir);
        private Turnir _turnir;
        public frmDetaljiTurnira(Turnir turnir = null)
        {
            InitializeComponent();
            _turnir = turnir;
        }

        private async void frmDetaljiTurnira_Load(object sender, EventArgs e)
        {
            await LoadSportove();
            cmbPocetak.DataSource = pocetak;
            cmbZavrsetak.DataSource = zavrsetak;
            if (_turnir != null)
            {
                cmbPocetak.SelectedItem = _turnir.VrijemePocetka;
                cmbZavrsetak.SelectedItem = _turnir.VrijemeKraja;
                dtpDatumPocetka.Value = _turnir.DatumPocetka;
                dtpDatumKraja.Value = _turnir.DatumKraja;
                cmbSport.SelectedValue = _turnir.Teren.SportId;
                cbIsPotvrdjen.Checked = _turnir.IsPotvrdjen;
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
            if (sport != null)
            {
                if (_turnir?.Teren?.SportId != sport.Id)
                    await LoadTerene(sport.Id);
                else
                    await LoadTerene(sport.Id, _turnir.Teren.Id);
            }
        }

        private async void cmbTeren_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var teren = comboBox.SelectedItem as Teren;
            if (teren != null)
            {
                if (_turnir?.TerenId != teren.Id)
                    await LoadCjenovnik(teren.Id);
                else
                    await LoadCjenovnik(teren.Id, _turnir.CjenovnikId);
            }
        }

        private void cmbPocetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var start = comboBox.SelectedItem as int?;
            if (start != null)
            {
                var index = zavrsetak.IndexOf(start.GetValueOrDefault());
                var noviZavrsetak = zavrsetak.Skip(index + 1);
                cmbZavrsetak.DataSource = noviZavrsetak.ToList();
                IzracunajCijenu();
            }
        }

        private void IzracunajCijenu()
        {
            var cjenovnik = cmbTipRezervacije.SelectedItem as Cjenovnik;
            var pocetna = cmbPocetak.SelectedItem as int?;
            var kraj = cmbZavrsetak.SelectedItem as int?;
            var datumPocetka = dtpDatumPocetka.Value;
            var datumKraja = dtpDatumKraja.Value.AddSeconds(10);
            if (cjenovnik != null && pocetna != null && kraj != null)
            {
                int brojDana = datumKraja.Subtract(datumPocetka).Days + 1;
                if (cjenovnik.TipRezervacije.IsDnevna)
                {
                    txtCijena.Text = (cjenovnik.Cijena * brojDana).ToString();
                }
                else
                {
                    var cijena = (kraj.GetValueOrDefault() - pocetna.GetValueOrDefault()) * cjenovnik.Cijena * brojDana;
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
                    var datumPocetka = dtpDatumPocetka.Value.Date;
                    var datumKraja = dtpDatumKraja.Value.Date;
                    
                    TurnirInsertRequest request = new TurnirInsertRequest
                    {
                        CjenovnikId = cjenovnik.Id,
                        TerenId = teren.Id,
                        IsPotvrdjen = cbIsPotvrdjen.Checked,
                        DatumPocetka = dtpDatumPocetka.Value,
                        DatumKraja = dtpDatumKraja.Value,
                        VrijemePocetka = pocetna.GetValueOrDefault(),
                        VrijemeKraja = kraj.GetValueOrDefault(),
                        UkupnaCijena = Convert.ToInt32(txtCijena.Text)
                    };
                    Turnir turnir = null;
                    if (_turnir == null)
                    {
                        turnir = await _turnirService.Insert<Turnir>(request);
                    }
                    else
                    {
                        turnir = await _turnirService.Update<Turnir>(_turnir.Id, request);
                    }
                    if (turnir == null)
                    {
                        MessageBox.Show("Zauzeto");
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

        private void dtpDatumKraja_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = sender as DateTimePicker;
            if (dateTimePicker.Value < dtpDatumPocetka.Value)
                dtpDatumKraja.Value = dtpDatumPocetka.Value;
            IzracunajCijenu();
        }

        private void dtpDatumPocetka_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = sender as DateTimePicker;
            if (dateTimePicker.Value > dtpDatumKraja.Value)
                dtpDatumKraja.Value = dtpDatumPocetka.Value;
            IzracunajCijenu();
        }

        private void cmbZavrsetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzracunajCijenu();
        }

        private void cmbTipRezervacije_SelectedIndexChanged(object sender, EventArgs e)
        {
            IzracunajCijenu();
        }

        private void cmbSport_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbSport, e);
        }

        private void cmbTeren_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbTeren, e);
        }

        private void cmbTipRezervacije_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validator.ValidacijaComboBox(errorProvider, cmbTipRezervacije, e);
        }
    }
}
