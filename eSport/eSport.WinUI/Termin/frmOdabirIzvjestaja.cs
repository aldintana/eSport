using eSport.Model;
using eSport.WinUI.Properties;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmOdabirIzvjestaja : Form
    {
        APIService _sportService = new APIService(NazivEntiteta.Sport);
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        APIService _terminService = new APIService(NazivEntiteta.Termin);
        public frmOdabirIzvjestaja()
        {
            InitializeComponent();
        }

        private async void frmOdabirIzvjestaja_Load(object sender, System.EventArgs e)
        {
            await LoadSportove();
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

        private async void cmbSport_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var sport = cmbSport.SelectedItem as Sport;
            await LoadTerene(sport?.Id);
        }

        private async void btnGenerisi_Click(object sender, System.EventArgs e)
        {
            var teren = cmbTeren.SelectedItem as Teren;
            var sport = cmbSport.SelectedItem as Sport;
            var terminSearchRequest = new TerminSearchRequest
            {
                TerenId = teren?.Id,
                SportId = sport?.Id,
                OdDatuma = dtpOdDatuma.Value,
                DoDatuma = dtpDoDatuma.Value,
                IncludeList = new string[] {NazivEntiteta.Teren}
            };
            if (terminSearchRequest?.SportId == 0)
                terminSearchRequest.SportId = null;
            var termini = await _terminService.Get<List<Model.Termin>>(terminSearchRequest);
            if(termini != null)
            {
                if(termini.Count == 0)
                {
                    MessageBox.Show("Nema podataka");
                    return;
                }
                var pocetak = dtpOdDatuma.Value.Date.ToString("dd.MM.yyyy.");
                var kraj = dtpDoDatuma.Value.Date.ToString("dd.MM.yyyy.");
                var rasponDatuma = $"Vremenski period: {pocetak} - {kraj}";
                var terenNaziv = "Svi";
                var sportNaziv = "Svi";
                if (teren != null)
                    terenNaziv = teren.Naziv;
                if (sport != null && sport.Id != 0)
                    sportNaziv = sport.Naziv;
                frmIzvjestajTermina frmIzvjestajTermina = new frmIzvjestajTermina(termini, rasponDatuma, terenNaziv, sportNaziv);
                frmIzvjestajTermina.Show();
            }
            else
            {
                MessageBox.Show(Resources.Greška);
            }
        }
    }
}
