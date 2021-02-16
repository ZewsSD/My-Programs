using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2Darray9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 6];
            int[] array2 = new int[0];
            int number = 0;
            int temp = 0;

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(7, 70 + 1);
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
                    if (array[i, j] % 7 == 0)
                    {
                        temp++;
                        array2 = new int[temp];
                    }
                }
            }

            Console.WriteLine(temp);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 7 == 0)
                    {
                        number++;
                        array2[temp - number] = array[i, j];
                    }
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
