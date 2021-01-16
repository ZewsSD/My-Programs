using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isValidInput;

            Console.Write("Введите число: ");
            do
            {
                isValidInput = int.TryParse(Console.ReadLine(), out number);
            } while (isValidInput != true);

            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i);   
                }
            }

            Console.ReadKey();
        }
    }
}
