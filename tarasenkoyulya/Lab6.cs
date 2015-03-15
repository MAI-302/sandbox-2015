using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Lab6
    {
        static void Main(string[] args)
        {
            int i = 0;

            Random rnd = new Random();

            Console.Write("Задайте длину массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[n]; //начальный массив из n-чисел
            double[] mean = new double[n]; //массив из среднеарифметических чисел

            Console.WriteLine("Исходный массив:");

            //заполнение массива числами от -100 до 100
            for (i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(-100, 100);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();

            mean[0] = (mas[0] + mas[1]) / 2.0; //cреднее арифметическое для первых двух чисел исходного массива
            Console.Write(mean[0] + " ");
            mean[n - 1] = (mas[n - 1] + mas[n - 2]) / 2.0; //cреднее арифметическое для двух последних чисел исходного массива
            Console.Write(mean[n-1] + " ");

            //дальше у каждого числа есть два соседних,поэтому считаем среднееарифметическое из трёх чисел исходного массива

            for (i = 1; i < (n - 1); i++)
            {
                mean[i] = (mas[i] + mas[i - 1] + mas[i + 1]) / 3.0;
            }

            Console.WriteLine("Массив из среднеарифметических соседних элементов: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(mean[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
