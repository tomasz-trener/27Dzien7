using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieDziedziczenie
{
    internal class PlikSQL : Raport
    {
        public PlikSQL()
        {
            rozszerzenie = ".sql";
        }

        public override void Zapisz()
        {
            // File.WriteAllText(Sciezka + "\\" + Nazwa + rozszerzenie, Zawartosc);
            Zawartosc = $"SELECT {Zawartosc} from Dane";
            base.Zapisz();
        }
    }
}
