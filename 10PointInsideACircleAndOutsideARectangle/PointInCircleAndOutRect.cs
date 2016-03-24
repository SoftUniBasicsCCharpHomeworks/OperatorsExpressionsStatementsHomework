using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideACircleAndOutsideARectangle
{
    class PointInCircleAndOutRect
    {
        static void Main()
        {
            Console.Write("Please, enter x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please, enter y:");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = Math.Pow(x-1, 2) + Math.Pow(y-1, 2) <= (1.5*1.5);
            bool inRectangle = (x >= -1 & x <= 5) & (y>= -1 & y <= 1);

            if (inCircle && !inRectangle)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
