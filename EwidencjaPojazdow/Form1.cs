using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        // Tworzymy listę, która automatycznie odświeża tabelę na ekranie
        BindingList<Pojazd> listaPojazdow = new BindingList<Pojazd>();

        public Form1()
        {
            InitializeComponent();
            // Podpinamy listę do tabeli przy starcie programu
            dgvPojazdy.DataSource = listaPojazdow;
        }

        // Metoda dodawania pojazdu (ETAP 1)
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

            // Czyścimy pola tekstowe
            txtNr.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtWlasciciel.Clear();
        }

        // Metoda generowania raportu (ETAP 2)
        private void btnGenerujRaport_Click(object sender, EventArgs e)
        {
            // 1. Filtracja LINQ - wybieramy pojazdy z przeglądem w bieżącym miesiącu i roku
            var dzisiaj = DateTime.Now;
            var daneDoRaportu = listaPojazdow.Where(p =>
                p.DataPrzegladu.Month == dzisiaj.Month &&
                p.DataPrzegladu.Year == dzisiaj.Year).ToList();

            // 2. Tworzymy okno podglądu raportu
            Form oknoRaportu = new Form();
            oknoRaportu.Text = "Raport - Przeglądy w tym miesiącu";
            oknoRaportu.Size = new System.Drawing.Size(850, 600);
            oknoRaportu.StartPosition = FormStartPosition.CenterScreen;

            // 3. Konfiguracja ReportViewer
            ReportViewer rv = new ReportViewer();
            rv.Dock = DockStyle.Fill;

            // Ścieżka do pliku raportu (upewnij się, że nazwa pliku jest identyczna!)
            rv.LocalReport.ReportPath = "RaportPojazdow.rdlc";

            // Łączymy dane z DataSetem w raporcie (Nazwa "DataSet1" musi być taka sama jak w pliku .rdlc)
            ReportDataSource rds = new ReportDataSource("DataSet1", daneDoRaportu);

            rv.LocalReport.DataSources.Clear();
            rv.LocalReport.DataSources.Add(rds);

            // 4. Wyświetlenie
            oknoRaportu.Controls.Add(rv);
            rv.RefreshReport();
            oknoRaportu.ShowDialog();
        }
    }

    // Klasa reprezentująca dane pojazdu
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