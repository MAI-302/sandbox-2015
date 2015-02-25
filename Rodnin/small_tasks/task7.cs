using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m:");
            int m = int.Parse(Console.ReadLine());

            int[,] mass = new int[n, m];
            Random rand = new Random();
            Console.WriteLine();

            Console.WriteLine("Матрица заполненная случайными числами в диапазоне от -100 до 100");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rand.Next(-100, 100);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[] maxOfRows = new int[m];
            int min;

            maxOfRows[0] = mass[0, 0];

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] > maxOfRows[i])
                    {
                        maxOfRows[i] = mass[i,j];
                    }
                }
            }

            min = maxOfRows[0];

            for (int i = 1; i < m; i++)
            {
                if (maxOfRows[i] < min)
                    min = maxOfRows[i];
            }
            Console.WriteLine("Минимальный среди максимальных: " + Convert.ToString(min));
            Console.ReadKey();
        }
    }
}
