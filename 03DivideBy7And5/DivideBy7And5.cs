using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            bool isDevidable = true;
            if (n%5!=0 && n%7!=0)
            {
                isDevidable = false;
            }
                Console.WriteLine(isDevidable);
        }
    }
}
