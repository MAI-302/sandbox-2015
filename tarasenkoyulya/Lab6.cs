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

            Console.WriteLine("Задайте длину массива n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[n]; //начальный массив из n-чисел
            Double[] mean = new double[n]; //массив из среднеарифметических чисел

            Console.WriteLine("Исходный массив:");

            while (i < n) //заполнение массива числами от -100 до 100
            {
                mas[i] = rnd.Next(-100, 100);
                Console.Write(mas[i] + " ");
                i++;
            }
            Console.WriteLine();

            mean[0] = (mas[1] + mas[2]) / 2.0; //cреднее арифметическое для первых двух чисел исходного массива
            mean[n - 1] = (mas[n - 1] + mas[n - 2]) / 2.0; //cреднее арифметическое для первых двух чисел исходного массива

            //дальше у каждого числа есть два соседних,поэтому считаем среднееарифметическое из трёх чисел исходного массива
            i = 1;

            while (i < n-1)
            {
                mean[i] = (mean[i] + mean[i - 1] + mean[i + 1]) / 3.0;
                i++;
            }

            i = 0; //обнуление счётчика, чтобы заполнить массив, состоящий из среднеарифметических элементов

            Console.WriteLine("Массив из среднеарифметических соседних элементов: ");

            while (i < n)
            {
                Console.Write(mean[i] + " ");
                i++;
            }
            Console.ReadKey();
        }
    }
}
