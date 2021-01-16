using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_cycle3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int result;
            bool isValidInput;

            Console.Write("Введите число: ");

            do
            {
                isValidInput = int.TryParse(Console.ReadLine(), out number);
            } while (isValidInput != true);

            while (number != 0)
            {
                result = number % 10;
                number = number / 10;
                Console.Write(result);
            }

            Console.ReadKey();
        }
    }
}
