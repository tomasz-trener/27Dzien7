using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Intrefejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 2,5,6,3,1};

            Array.Sort(liczby);

            Console.WriteLine(string.Join(" ", liczby));

          

            Krzeslo[] krzesla = new Krzeslo[]
            {
                new Krzeslo{ Firma="xxx", Waga=3},
                new Krzeslo{ Firma="yyyyy", Waga=1},
                new Krzeslo{ Firma="zzzz", Waga=2},
            };

            Array.Sort(krzesla);


            foreach (var k in krzesla)
            {
                Console.WriteLine(k.Firma + " " + k.Waga);
            }


            // inne itrefejsy, np IColonable 

            Krzeslo k1 = new Krzeslo() { Firma = "xyz", Waga = 30 };
            Krzeslo k2 = k1; // przekazanie przez referencje 

            k1.Waga++; // zmieni obiekt na który wzkazuje k1 i k2 

            // a ja chce zrobic niezalezna kopie 

            Krzeslo k3 = new Krzeslo() // teraz mam kopie 
            {
                Firma = k1.Firma,
                Waga = k1.Waga,
            };

            Krzeslo k4 = (Krzeslo)k1.Clone(); // teraz mma kopie 

            Console.ReadKey();
        }
    }
}
