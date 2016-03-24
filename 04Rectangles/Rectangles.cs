using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Please, enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Please, enter height:");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("The perimeter is {0}\nThe area is {1}",perimeter,area);
        }
    }
}
