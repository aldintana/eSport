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
    public partial class frmDetaljiTerena : Form
    {
        APIService terenService = new APIService("Teren");
        APIService sportService = new APIService("Sport");

        private Teren _teren;
        public frmDetaljiTerena(Teren teren = null)
        {
            InitializeComponent();
            _teren = teren;
        }

        private async void frmDetaljiTerena_Load(object sender, EventArgs e)
        {
            await LoadSportove();
            if(_teren != null)
            {
                txtNaziv.Text = _teren.Naziv;
                cmbSport.SelectedIndex = _teren.SportId;
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
            if(_teren==null)
            {
                TerenInsertRequest request = new TerenInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    SportId = cmbSport.SelectedIndex
                };
                var teren = await terenService.Insert<Teren>(request);
            }
            else
            {
                TerenInsertRequest request = new TerenInsertRequest
                {
                    Naziv = txtNaziv.Text,
                    SportId = cmbSport.SelectedIndex
                };
                var teren = await terenService.Update<Teren>(_teren.Id, request);
            }
        }
    }
}
