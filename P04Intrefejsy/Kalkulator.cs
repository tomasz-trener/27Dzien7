using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Intrefejsy
{
    internal class Kalkulator
    {
        public double WykonajOperacje(int a, int b, IOperacja operacja)
        {
            double wynik = operacja.WykonajOperacje(a, b);
            return wynik;
        }
    }
}
