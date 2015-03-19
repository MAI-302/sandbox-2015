using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_sharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[,] mass = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(0, 100);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int min_max=int.MaxValue;
            int sub_max = mass[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mass[i, j] > sub_max)
                        sub_max = mass[i, j];
                }
                    if (sub_max < min_max)
                        min_max = sub_max;
                    sub_max = 0;
            }
            Console.WriteLine("Минимальный из максимальных элементов строк двумерного массива\t"+min_max);
            Console.ReadKey();
        }
    }
}
