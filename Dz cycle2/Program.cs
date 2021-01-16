using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_cycle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberUser;
            int number = 0;
            int numbercount = 1;
            bool isValidInput;

            Console.Write("Введите число: ");
            do
            {
                isValidInput = int.TryParse(Console.ReadLine(), out numberUser);
            } while (isValidInput != true);

            for (int i = 0; i <= numberUser; i++)
            {
                if (i == numbercount)
                {
                    numbercount *= 10;
                    number++;
                }
            }

            Console.Write($"Разряд: {number}");

            Console.ReadKey();
        }
    }
}

