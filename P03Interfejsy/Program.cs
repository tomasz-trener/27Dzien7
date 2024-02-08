using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // polimorfizm 

            IUmiejacyJezdzic[] tablicaPojazdowUmiejacychJezdzic = new IUmiejacyJezdzic[]
            {
                new Samochod(),
                new Amfibia()
            };

            foreach (var p in tablicaPojazdowUmiejacychJezdzic)
            {
                p.Jedz();
            }
            Console.ReadLine();
        }
    }
}
