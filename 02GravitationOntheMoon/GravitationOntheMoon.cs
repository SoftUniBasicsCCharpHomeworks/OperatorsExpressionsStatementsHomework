using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOntheMoon
{
    class GravitationOntheMoon
    {
        static void Main()
        {
            Console.Write("Please, enter a weight:");
            double n = double.Parse(Console.ReadLine());
            double weightMoon =n*(17d/100d);
            Console.WriteLine("Weight on the Moon is {0}", weightMoon);
        }
    }
}
