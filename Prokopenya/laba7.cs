using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seven
{
    class laba7
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int min = Int32.MaxValue;
            int i = 0;
            int j = 0;

            Console.WriteLine("Напишите кол-во строк матрицы ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Введено некорректное n "); Environment.Exit(0); }

            Console.WriteLine("Напишите кол-во столбцов матрицы ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m <= 0) { Console.WriteLine("Введено некорректное m "); Environment.Exit(0); }
            

            int[][] mas = new int [n][];
            int[] vector = new int[n];
            //массив для максимальных элементов
            do
            {
                vector[i] = Int32.MinValue;
                i++;
            }while (i < n);

            i = 0;

            Console.WriteLine("Заполниете матрицу числами");

            do
            {
                mas[i] = new int[m];
                do
                {
                    mas[i][j] = Convert.ToInt32(Console.ReadLine());
                    j++;
                } while (j < m);

                Console.WriteLine();
                i++;
                j = 0;

            } while (i < n);
            //Вывод матрицы
            Console.WriteLine("Полученная матрица ");
            i = 0;

            do
            {
                do
                {
                    Console.Write(mas[i][j] + "\t");
                    j++;
                } while (j < m);
                Console.WriteLine();
                i++;
                j = 0;
            } while (i < n);

            i = 0;
            //находим максимальный элемент в каждой строке
            do
            {
                IEnumerable<int> row = mas[i].Cast<int>();
                vector[i] = row.Max();
                i++;
            } while (i < n);

            i = 0;
            //минимальный среди максимальных
            Console.WriteLine("Минимальный элемент равен " + vector.Min());

            Console.ReadKey();
        }
    }
}
