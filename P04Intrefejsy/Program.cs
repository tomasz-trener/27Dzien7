using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Intrefejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            k.WykonajOperacje(2, 3, new MechanizmDodawania());
            k.WykonajOperacje(2,3, new MechanizmOdejomowania());

            // zalety : 
            // 1) łatwy podział systemu na czesci (kazdy programista pracuje na niezaleznej klasie)
            // 2) nie wszystkie czesci musza byc gotowe, zeby całoś działała 
            // 3) DI (Dempendency Injection ) poznamy później 
        }
    }
}
