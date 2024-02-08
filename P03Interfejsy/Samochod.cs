using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Samochod : IUmiejacyJezdzic
    {
        public void Jedz()
        {
            Console.WriteLine("Samochod jedzie");
        }
    }
}
