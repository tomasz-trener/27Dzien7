using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Samolot : IUmiejayLatac
    {
        public void Lec()
        {
            Console.WriteLine("Samolot leci");
        }
    }
}
