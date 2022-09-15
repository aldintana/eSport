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
    public partial class frmPrikazTermina : Form
    {
        APIService _terminService = new APIService(NazivEntiteta.Termin);
        APIService _terenService = new APIService(NazivEntiteta.Teren);
        public frmPrikazTermina()
        {
            InitializeComponent();
            dgvTermini.AutoGenerateColumns = false;
        }

        private async Task LoadTerene()
        {
            var tereni = await _terenService.Get<List<Teren>>();
            tereni.Insert(0, new Teren());
            cmbTereni.DataSource = tereni;
            cmbTereni.DisplayMember = "Naziv";
            cmbTereni.ValueMember = "Id";
        }

        private async void frmPrikazTermina_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadTerene();
                TerminSearchRequest searchRequest = new TerminSearchRequest
                {
                    IncludeList = new string[] { NazivEntiteta.Teren },
                    OdDatuma = DateTime.Now
                };

                dgvTermini.DataSource = await _terminService.Get<List<Model.Termin>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            } 
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                var teren = cmbTereni.SelectedItem as Teren;
                int? terenId = teren?.Id;
                if (terenId == 0)
                    terenId = null;
                TerminSearchRequest searchRequest = new TerminSearchRequest
                {
                    IncludeList = new string[] { NazivEntiteta.Teren },
                    OdDatuma = DateTime.Now,
                    TerenId = terenId
                };

                dgvTermini.DataSource = await _terminService.Get<List<Model.Termin>>(searchRequest);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            frmDetaljiTermina frmDetaljiTermina = new frmDetaljiTermina();
            if (frmDetaljiTermina.ShowDialog() == DialogResult.OK)
            {
                dgvTermini.DataSource = null;
                frmPrikazTermina_Load(sender, e);
            }
        }
    }
}
