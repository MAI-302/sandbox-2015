using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLab6
{
    class SmallLab6
    {
        static void Main(string[] args)
        {
            int i = 0;

            Random r = new Random();

            Console.WriteLine("Задайте длину массива n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] massive = new int[n]; //начальный массив из n-чисел
            Double[] mean = new double[n]; //массив из среднеарифметических чисел

            Console.WriteLine("Исходный массив:");

            while (i < n)
            {
                massive[i] = r.Next(-50, 50);
                Console.Write(massive[i] + " ");
                i++;
            } //заполнение массива числами от -50 до 50
            Console.WriteLine();

            mean[0] = (massive[0] + massive[1]) / 2.0; //cреднее арифметическое для первых двух элементов исходного массива
            mean[n - 1] = (massive[n - 1] + massive[n - 2]) / 2.0; //cреднее арифметическое для первых двух элементов исходного массива

            //т.к. у каждого элемента дальше будет по 2 соседних, то и среднее арифметическое будем искать из 3 элементов
            i = 1;

            while (i < n - 1)
            {
                mean[i] = (massive[i] + massive[i - 1] + massive[i + 1]) / 3.0;
                i++;
            } //такой цикл, потому что для последнего элемента мы уже высчитали среднее арифметическое

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
