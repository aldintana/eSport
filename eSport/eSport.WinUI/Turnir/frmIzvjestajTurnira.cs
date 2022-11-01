using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eSport.WinUI
{
    public partial class frmIzvjestajTurnira : Form
    {
        private IList<Model.Turnir> _turniri;
        private string _terenNaziv;
        private string _sportNaziv;
        private string _rasponDatuma;
        public frmIzvjestajTurnira(IList<Model.Turnir> turniri, string rasponDatuma, string terenNaziv, string sportNaziv)
        {
            InitializeComponent();
            _turniri = turniri.OrderBy(t => t.TerenNaziv).ToList();
            _rasponDatuma = rasponDatuma;
            _terenNaziv = terenNaziv;
            _sportNaziv = sportNaziv;
        }

        private void frmIzvjestajTurnira_Load(object sender, System.EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            var cijena = _turniri.Sum(t => t.UkupnaCijena);
            var brojTurnira = _turniri.Count();
            var ukupanPrihod = $"Ukupan prihod: {cijena}KM";
            var ukupanBrojTurnira = $"Broj turnira: {brojTurnira}";
            reportParameters.Add(new ReportParameter("RasponDatuma", _rasponDatuma));
            reportParameters.Add(new ReportParameter("Teren", _terenNaziv));
            reportParameters.Add(new ReportParameter("Sport", _sportNaziv));
            reportParameters.Add(new ReportParameter("UkupanPrihod", ukupanPrihod));
            reportParameters.Add(new ReportParameter("BrojTurnira", ukupanBrojTurnira));
            reportViewer.LocalReport.SetParameters(reportParameters);

            var reportList = new List<object>();
            var i = 1;
            foreach (var item in _turniri)
            {
                reportList.Add(new
                {
                    DatumPocetka = item.DatumPocetka.ToString("dd.MM.yyyy."),
                    DatumKraja = item.DatumKraja.ToString("dd.MM.yyyy."),
                    VrijemePocetka = $"{item.VrijemePocetka}:00",
                    VrijemeKraja = $"{item.VrijemeKraja}:00",
                    Naziv = item.Naziv,
                    Teren = item.Teren.Naziv,
                    RedniBroj = i++,
                    Cijena = item.UkupnaCijena
                });
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "Turniri";
            dataSource.Value = reportList;
            reportViewer.LocalReport.DataSources.Add(dataSource);
            this.reportViewer.RefreshReport();
        }
    }
}
