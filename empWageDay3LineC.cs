﻿using System;
using System.Collections.Generic;
using System.Text;

namespace empWageDay3
{
    class empWageDay3LineC
    {
        public static void EmpWageDay3LineC()
        {
            int X1 = 4;
            int Y1 = 2;
            int X2 = 1;
            int Y2 = 3;

            float length = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(length);
        }

    }

}
