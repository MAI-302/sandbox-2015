using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLab7
{
    class SmallLab7
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int Index = 0;//индекс максимального элемента в строке
            int MinMax = int.MaxValue;//минимакс

            Random rnd = new Random();

            Console.Write("Введите количество строк n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n <= 0)
            {
                Console.WriteLine("Некорректное число строк n матрицы!");
                Environment.Exit(0);
            }

            Console.Write("Введите количество столбцов m: ");
            int m = Convert.ToInt32(Console.ReadLine());
             if(m <= 0)
            {
                Console.WriteLine("Некорректное число столбцов m матрицы!");
                Environment.Exit(0);
            }

            int [,] Matrix = new int [n, m]; //задаём двумерный массив(матрицу)

            Console.WriteLine();
            Console.WriteLine("Исходая матрица:");

            //заполнение и вывод исходной матрицы числами от -100 до 100
            do
            {
                j = 0;
                do
                {
                    Matrix[i, j] = rnd.Next(-100, 100);//элементу массива присваиваем случайное значение от -100 до 100
                    Console.Write(Matrix[i, j] + " ");
                    j++;
                } while (j < Matrix.GetLength(1));
                Console.WriteLine();
                i++;
            } while (i < Matrix.GetLength(0));

            Console.WriteLine();

            i = 0;

                do
                {
                    j = 0;
                    do
                    {
                        if (Matrix[i, j] > Matrix[i, Index])
                        {
                            Index = j;
                        }
                        j++;
                    } while (j < Matrix.GetLength(1));
                    if (Matrix[i, Index] < MinMax)
                    {
                        MinMax = Matrix[i, Index];
                    }
                i++;
                } while (i < Matrix.GetLength(0));
            
           // Console.WriteLine();

            Console.WriteLine("Минимальный элемент из максимальных элементов по строкам: " + MinMax);

            Console.ReadKey();
        }
    }
}