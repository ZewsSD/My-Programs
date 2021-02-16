using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2Darray11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 6];
            int min = int.MaxValue;
            int max = int.MinValue;
            int minI = 0;
            int minJ = 0;
            int maxI = 0;
            int maxJ = 0;

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
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minI = i;
                        minJ = j;
                    }
                    else if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);

            array[minI, minJ] = array[maxI, maxJ];
            array[maxI, maxJ] = min;

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
