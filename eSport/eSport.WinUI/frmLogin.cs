using System;
using System.Linq;
using System.Windows.Forms;
using eSport.WinUI.Properties;
using System.Collections.Generic;

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
            bool admin = false;
            try
            {
                var korisnici = await _korisnikService.Get<List<Model.Korisnik>>();

                var korisnik = korisnici.First(x => x.KorisnickoIme == txtKorisnickoIme.Text);

                APIService.LogiraniKorisnikId = korisnik.Id;
                foreach (var uloga in korisnik.KorisnikUlogas)
                {
                    if (uloga.Uloga.Naziv == "Admin")
                    {
                        admin = true;
                    }
                }

                if(admin)
                {
                    frmPocetna frm = new frmPocetna();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(Resources.NemaPermisija);
                }
            }
            catch
            {
                MessageBox.Show(Resources.GreškaUPrijavi);
            }
        }
    }
}
