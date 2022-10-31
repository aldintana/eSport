using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace eSport.WinUI
{
    public partial class frmIzvjestajTermina : Form
    {
        private IList<Model.Termin> _termini;
        private string _terenNaziv;
        private string _sportNaziv;
        private string _rasponDatuma;
        public frmIzvjestajTermina(IList<Model.Termin> termini, string rasponDatuma, string terenNaziv, string sportNaziv)
        {
            InitializeComponent();
            _termini = termini.OrderBy(t => t.TerenNaziv).ToList();
            _rasponDatuma = rasponDatuma;
            _terenNaziv = terenNaziv;
            _sportNaziv = sportNaziv;
        }

        private void frmIzvjestajTermina_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            var cijena = _termini.Sum(t => t.UkupnaCijena);
            var brojTermina = _termini.Count();
            var ukupanPrihod = $"Ukupan prihod: {cijena}KM";
            var ukupanBrojTermina = $"Broj termina: {brojTermina}";
            reportParameters.Add(new ReportParameter("RasponDatuma", _rasponDatuma));
            reportParameters.Add(new ReportParameter("Teren", _terenNaziv));
            reportParameters.Add(new ReportParameter("Sport", _sportNaziv));
            reportParameters.Add(new ReportParameter("UkupanPrihod", ukupanPrihod));
            reportParameters.Add(new ReportParameter("BrojTermina", ukupanBrojTermina));
            reportViewer.LocalReport.SetParameters(reportParameters);

            var reportList = new List<object>();
            var i = 1;
            foreach (var item in _termini)
            {
                reportList.Add(new
                {
                    Datum = item.Datum.ToString("dd.MM.yyyy."),
                    Pocetak = item.Pocetak.ToString("H:mm"),
                    Kraj = item.Kraj.ToString("H:mm"),
                    Teren = item.Teren.Naziv,
                    RedniBroj = i++,
                    Cijena = item.UkupnaCijena
                });
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "Termini";
            dataSource.Value = reportList;
            reportViewer.LocalReport.DataSources.Add(dataSource);
            this.reportViewer.RefreshReport();
        }
    }
}
