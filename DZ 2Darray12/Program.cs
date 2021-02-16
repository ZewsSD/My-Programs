using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2Darray12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 6];
            int temp = 0;
            

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 99 + 1);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,0] > array[i,array.GetLength(1) - 1])
                    {
                        temp = array[i, 0];
                        array[i, 0] = array[i, array.GetLength(1) - 1];
                        array[i, array.GetLength(1) - 1] = temp;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
