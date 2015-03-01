using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seven
{
    class laba7
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int n;
            int m;
            int MinInColumn = Int32.MaxValue;
            int i = 0;
            int j = 0;
            int MaxInRow = Int32.MinValue;

            Console.WriteLine("Напишите кол-во строк матрицы ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Введено некорректное n "); Environment.Exit(0); }

            Console.WriteLine("Напишите кол-во столбцов матрицы ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m <= 0) { Console.WriteLine("Введено некорректное m "); Environment.Exit(0); }
            

            int[][] mas = new int [n][];
            //массив для максимальных элементов

            i = 0;

            Console.WriteLine("Сгенерированная матрица ");

            do
            {
                mas[i] = new int[m];
                do
                {
                    mas[i][j] = random.Next(10,100);
                    Console.Write(mas[i][j] + " ");
                    j++;
                } while (j < m);
                Console.WriteLine();
                i++;
                j = 0;

            } while (i < n);

            i = 0;

            do
            {
                do
                {
                    if (MaxInRow < mas[i][j])
                    {
                        MaxInRow = mas[i][j];
                    }
                    j++;
                } while (j < m);
                if (MaxInRow < MinInColumn)
                {
                    MinInColumn = MaxInRow;
                }
                MaxInRow = 0;
                i++;
                j = 0;
            } while (i < n);

            Console.WriteLine("Минимальный из максимальных элементов строк двумерного массива " + MinInColumn);

            Console.ReadKey();
        }
    }
}
