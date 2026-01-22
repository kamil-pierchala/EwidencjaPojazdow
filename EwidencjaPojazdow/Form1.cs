using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        BindingList<Pojazd> listaPojazdow = new BindingList<Pojazd>();

        public Form1()
        {
            InitializeComponent();
            dgvPojazdy.DataSource = listaPojazdow;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Pojazd nowyPojazd = new Pojazd
            {
                NrRejestracyjny = txtNr.Text,
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                RokProdukcji = (int)numRok.Value,
                DataPrzegladu = dtpData.Value,
                Wlasciciel = txtWlasciciel.Text
            };

            listaPojazdow.Add(nowyPojazd);

            txtNr.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtWlasciciel.Clear();
        }

        private void btnGenerujRaport_Click(object sender, EventArgs e)
        {
            var dzisiaj = DateTime.Now;
            var daneDoRaportu = listaPojazdow.Where(p =>
                p.DataPrzegladu.Month == dzisiaj.Month &&
                p.DataPrzegladu.Year == dzisiaj.Year).ToList();

            Form oknoRaportu = new Form();
            oknoRaportu.Text = "Raport - Przeglądy w tym miesiącu";
            oknoRaportu.Size = new System.Drawing.Size(850, 600);
            oknoRaportu.StartPosition = FormStartPosition.CenterScreen;

            ReportViewer rv = new ReportViewer();
            rv.Dock = DockStyle.Fill;

            rv.LocalReport.ReportPath = "RaportPojazdow.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSet1", daneDoRaportu);

            rv.LocalReport.DataSources.Clear();
            rv.LocalReport.DataSources.Add(rds);

            oknoRaportu.Controls.Add(rv);
            rv.RefreshReport();
            oknoRaportu.ShowDialog();
        }
    }

    public class Pojazd
    {
        public string NrRejestracyjny { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }
        public DateTime DataPrzegladu { get; set; }
        public string Wlasciciel { get; set; }
    }
}