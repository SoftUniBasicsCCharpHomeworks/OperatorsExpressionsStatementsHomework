using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            bool isSeven = false;

            if ((n / 100) % 10==7)
            {
                isSeven=true;
            }
            Console.WriteLine(isSeven);
        }
    }
}
