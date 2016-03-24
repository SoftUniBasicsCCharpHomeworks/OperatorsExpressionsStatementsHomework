using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a number:");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = (number / 1000) % 10;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            Console.WriteLine(firstDigit+secondDigit+thirdDigit+fourthDigit);
            Console.WriteLine("{0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}
