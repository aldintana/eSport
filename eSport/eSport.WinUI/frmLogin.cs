using eSport.WinUI.Properties;
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
    public partial class frmLogin : Form
    {
        private readonly APIService _korisnikService = new APIService(NazivEntiteta.Korisnik);
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            APIService.KorisnickoIme = txtKorisnickoIme.Text;
            APIService.Lozinka = txtLozinka.Text;
            APIService.Admin = false;

            try
            {
                var korisnici = await _korisnikService.Get<List<Model.Korisnik>>();

                var korisnik = korisnici.First(x => x.KorisnickoIme == txtKorisnickoIme.Text);

                APIService.LogiraniKorisnikId = korisnik.Id;
                foreach (var uloga in korisnik.KorisnikUlogas)
                {
                    if (uloga.Uloga.Naziv == "Admin")
                    {
                        APIService.Admin = true;
                    }
                }

                frmPocetna frm = new frmPocetna();
                frm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show(Resources.GreškaUPrijavi);
            }
        }
    }
}
