﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Intrefejsy
{
    internal class MechanizmOdejomowania : IOperacja
    {
        public double WykonajOperacje(int a, int b)
        {
            return a - b;
        }
    }
}
