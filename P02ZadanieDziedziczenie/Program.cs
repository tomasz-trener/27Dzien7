using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raport[] raporty = new Raport[]
            {
                new PlikCSV(){ Nazwa = "Jeden", Zawartosc = "ala ma kota", Sciezka = @"c:\dane\pliki"},
                new PlikHTML(){ Nazwa = "Dwa", Zawartosc = "ala ma kota", Sciezka = @"c:\dane\pliki"},
                new PlikSQL(){ Nazwa = "Trzy", Zawartosc = "ala ma kota", Sciezka = @"c:\dane\pliki"}

            };

            //foreach (var p in raporty)
            //{
            //    if (p is PlikCSV)
            //        ((PlikCSV)p).Zapisz();
            //    else if (p is PlikHTML)
            //        ((PlikHTML)p).Zapisz();
            //    else if(p is PlikSQL)
            //        ((PlikSQL)p).Zapisz();
            //}

            foreach (var p in raporty)
            {
                p.Zapisz();
            }
        }
    }
}
