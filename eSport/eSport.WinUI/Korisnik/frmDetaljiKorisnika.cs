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
    }
}
