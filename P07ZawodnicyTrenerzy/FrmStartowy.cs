﻿using P02ZawodnicyNoweOkna.Tools;
using P04Zawodnicy.Shared.Services;
using P06Zawodnicy.Shared.Domain;
using P06Zawodnicy.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07ZawodnicyTrenerzy
{
    public partial class FrmStartowy : Form
    {
        private readonly IManagerZawodnikow mz;
        
        string[] dostepneKolumny = new string[] { "Imie", "Nazwisko", "Kraj", "Waga", "Wzrost" };

        public FrmStartowy(IManagerZawodnikow mz)
        {
            this.mz = mz;
            InitializeComponent();
            Odswiez();

            //zasialmny kontrolke dostepnymi kolumnami 
            foreach (var k in dostepneKolumny)
                clbKolumny.Items.Add(k);
        }

        public void Odswiez()
        {
            mz.WczytajZawodnikow();
            cbKraje.DataSource = mz.PodajKraje();
        }

        private void cbKraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zaznaczonyKraj = (string)cbKraje.SelectedItem;

            if (zaznaczonyKraj != null)
            {
                lbDane.DataSource = mz.PodajZawodnikow(zaznaczonyKraj);
                lbDane.DisplayMember = "ImieNazwisko";

                double wzrost = mz.PodajSredniWzrost(zaznaczonyKraj);
                lblRaport.Text = string.Format("Średni wzrost: {0:0.00} cm", wzrost);
            }
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(zawodnik, this, TrybOkienka.Edycja,mz); 
            frmSzczegoly.Show();


        }

        //public void Zapisz()
        //{
        //    mz.Zapisz();
        //}

        private void btnNowy_Click(object sender, EventArgs e)
        {
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(this, TrybOkienka.Dodwanie,mz);
            frmSzczegoly.Show();
        }

        private void btnPodglad_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = (Zawodnik)lbDane.SelectedItem;
            FrmSzczegoly frmSzczegoly = new FrmSzczegoly(zawodnik, this, TrybOkienka.Podglad, mz);
            frmSzczegoly.Show();
        }

        private void btnGenerujPDF_Click(object sender, EventArgs e)
        {
            Zawodnik[] zawodnicy = (Zawodnik[])lbDane.DataSource;

            if (zawodnicy == null || zawodnicy.Length == 0)
            {
                MessageBox.Show("Pusty zbiór danych", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki pdf (*.pdf)|*.pdf";
            sfd.Title = "Wskaż miejsce zapisu raportu PDF";
            sfd.InitialDirectory = "C:\\dane";
            sfd.FileName = cbKraje.Text + "_" + DateTime.Now.ToString("ssmmhhddMMyy");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PDFManager pm = new PDFManager(sfd.FileName);
                pm.WygenerujPDF(zawodnicy);
                wbPrzegladarka.Navigate(sfd.FileName);
            }

         
        }

        private void clbKolumny_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string > zaznaczoneKolumny= new List<string>();
            foreach (string item in clbKolumny.CheckedItems)
                zaznaczoneKolumny.Add(item);

            Zawodnik.WyswietlaneKolumny = zaznaczoneKolumny.ToArray();

            lbDane.DisplayMember = null;
            lbDane.DisplayMember = "DynamicznaWlasciwosc";

        }

        private void btnPokazSreniWiek_Click(object sender, EventArgs e)
        {
            string wybranyKraj = cbKraje.SelectedItem.ToString();
            int sredniWiek = mz.PodajSredniWiekZawodnikow(wybranyKraj);
            MessageBox.Show($"Średni wiek zaowdników z kraju {wybranyKraj}: {sredniWiek}");
        }
    }
}
