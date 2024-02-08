using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Interfejsy
{
    internal class Amfibia : IUmiejacyPlywac, IUmiejacyJezdzic
    {
        public void Jedz()
        {
            Console.WriteLine("amfibia jedzie");
        }

        public void Plyn()
        {
            Console.WriteLine("amfibia płynie");
        }
    }
}
