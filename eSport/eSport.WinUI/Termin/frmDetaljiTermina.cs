using eSport.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public frmDetaljiTermina()
        {
            InitializeComponent();
        }

        private async void frmDetaljiTermina_Load(object sender, EventArgs e)
        {
            await LoadSportove();
            cmbPocetak.DataSource = pocetak;
            cmbZavrsetak.DataSource = zavrsetak;
        }

        private async Task LoadSportove()
        {
            var sportovi = await _sportService.Get<List<Sport>>();
            sportovi.Insert(0, new Sport());
            cmbSport.DataSource = sportovi;
            cmbSport.DisplayMember = "Naziv";
            cmbSport.ValueMember = "Id";
        }

        private async Task LoadTerene(int? sportId = null)
        {
            TerenSearchRequest searchRequest = new TerenSearchRequest
            {
                SportId = sportId
            };
            var tereni = await _terenService.Get<List<Teren>>(searchRequest);
            cmbTeren.DataSource = tereni;
            if (tereni != null && tereni.Count == 0)
            {
                //cmbTeren.Items.Clear();
                cmbTeren.DataSource = null;
                cmbTeren.SelectedItem = null;
                cmbTeren.ResetText();
            }
            cmbTeren.DisplayMember = "Naziv";
            cmbTeren.ValueMember = "Id";
        }

        private async Task LoadCjenovnik(int? terenId = null)
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
                //cmbTeren.Items.Clear();
                cmbTipRezervacije.DataSource = null;
                cmbTipRezervacije.SelectedItem = null;
                cmbTipRezervacije.ResetText();
            }
            cmbTipRezervacije.DisplayMember = "Naziv";
            cmbTipRezervacije.ValueMember = "Id";
        }

        private async void cmbSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var sport = comboBox.SelectedItem as Sport;
            if(sport != null)
            {
                await LoadTerene(sport.Id);
            }
        }

        private async void cmbTeren_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var teren = comboBox.SelectedItem as Teren;
            if (teren != null)
            {
                await LoadCjenovnik(teren.Id);
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
                        IsPotvrdjen = true,
                        Datum = dtpDatum.Value,
                        Pocetak = pocetakDatum,
                        Kraj = krajDatum,
                        UkupnaCijena = Convert.ToInt32(txtCijena.Text)
                    };
                    var termin = await _terminService.Insert<Termin>(request);
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
