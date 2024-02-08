using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikCSV : Raport
    {
        public PlikCSV()
        {
            rozszerzenie = ".csv";
        }

        public override void Zapisz()
        {
            File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie, Zawartosc);
        }
    }
}
