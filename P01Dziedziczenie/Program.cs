using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programista p = new Programista();
            p.Imie = "Jan";
            p.Nazwisko = "Kowalski";
            p.TypKomputera = "Laptop";
            p.Programuj();

            var z = new Zawodnik();
            z.Imie = "Adam";
            z.Nazwisko = "Nowak";
            z.NrNarty = 42;
            z.Skocz();

            Czlowiek c1 = new Czlowiek();

            Czlowiek c2 = (Czlowiek)new Zawodnik(); // typ szczegółowy na bardziej ogólny nie wymaga jawnego rzutowania 

            c2.Imie = "Jan";
            
            ((Zawodnik)c2).Skocz(); // na czas wywoływania metody "skocz" tratkuje c2 jako zawodnika 

            List<Zawodnik> tylkoZawodnicy = new List<Zawodnik>();
            List<Programista> tylkoProgramisci = new List<Programista>();
            // zamiast list indywidualnych...

            List<Czlowiek> osoby = new List<Czlowiek>();
            osoby.Add(p);
            osoby.Add(z);

            foreach (var o in osoby)
            {
               // Console.WriteLine(o.Imie + " " + o.Nazwisko + " " + ((Zawodnik)o).NrNarty);

                if (o is Zawodnik)
                    Console.WriteLine(o.Imie + " " + o.Nazwisko + " " + ((Zawodnik)o).NrNarty);
                else if (o is Programista)
                    Console.WriteLine(o.Imie + " " + o.Nazwisko + " " + ((Programista)o).TypKomputera);
            }

            Console.ReadKey();
        }
    }
}
