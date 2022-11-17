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

namespace eSport.WinUI.Korisnik
{
    public partial class frmDetaljiKorisnika : Form
    {
        private readonly APIService _serviceKorisnici = new APIService(NazivEntiteta.Korisnik);
        private readonly APIService _serviceUloga = new APIService(NazivEntiteta.Uloga);
        private Model.Korisnik _korisnik;
        public frmDetaljiKorisnika(Model.Korisnik korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmDetaljiKorisnika_Load(object sender, EventArgs e)
        {
            await UcitajUloge();
            if (_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtEmail.Text = _korisnik.Email;
                txtBrojTelefona.Text = _korisnik.BrojTelefona;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;
            }
        }

        private async Task UcitajUloge()
        {
            try
            {
                var uloge = await _serviceUloga.Get<List<Model.Uloga>>();
                if (_korisnik != null)
                {
                    foreach (var item in uloge)
                    {
                        if (_korisnik.KorisnikUlogas.Any(x => x.UlogaId == item.Id))
                        {
                            clbUloge.Items.Add(item, true);
                        }
                        else
                        {
                            clbUloge.Items.Add(item, false);
                        }
                    }
                }
                else
                {
                    clbUloge.DataSource = uloge;
                }
                clbUloge.DisplayMember = "Naziv";              
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.Greška);
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    var listaUloga = clbUloge.CheckedItems.Cast<Model.Uloga>();
                    var ulogaIds = listaUloga.Select(x => x.Id).ToList();

                    var request = new KorisnikInsertRequest();
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.BrojTelefona = txtBrojTelefona.Text;
                    request.Email = txtEmail.Text;
                    request.KorisnickoIme = txtKorisnickoIme.Text;
                    request.Lozinka = txtLozinka.Text;
                    request.LozinkaProvjera = txtLozinkaProvjera.Text;
                    request.Ulogas = ulogaIds;
                    request.UpdateUloga = true;
                    if (_korisnik == null)
                    {
                        var user = await _serviceKorisnici.Insert<Model.Korisnik>(request);
                        if (user == null)
                        {
                            MessageBox.Show("Korisnik sa istim korisničkim imenom već postoji, molimo da ga promijenite!");
                            return;
                        }
                    }
                    else
                    {
                        await _serviceKorisnici.Update<Model.Korisnik>(_korisnik.Id, request);                      
                    }
                    MessageBox.Show("Operacija uspješno izvršena");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(Properties.Resources.Greška);
                }
            }
        }
    }
}
