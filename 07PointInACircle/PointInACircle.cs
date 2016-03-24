using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.Write("Please, enter x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please, enter y:");
            double y = double.Parse(Console.ReadLine());

            bool isInside = Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2) <= Math.Pow(2, 2);
            Console.WriteLine(isInside);
        }
    }
}
