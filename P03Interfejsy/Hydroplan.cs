using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Hydroplan : IUmiejayLatac, IUmiejacyPlywac
    {
        public void Lec()
        {
            Console.WriteLine("Hydroplan leci");
        }

        public void Plyn()
        {
            Console.WriteLine("Hydroplan płynie");
        }
    }
}
