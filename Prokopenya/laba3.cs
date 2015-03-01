using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
    class laba3
    {

        static Random random = new Random();

        static void Main(string[] args)
        {
            int number; //число для умножения
            int i = 0;  //счетчик цикла
            int j = 0;  //счетник цикла
            int n;      //размерность матрицы
            bool flag = true; //результат работы программы


            Console.WriteLine("Напишите размерность квадратной матрицы ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Console.WriteLine("Сгенерированная матрица ");

            while (i < matrix.GetLength(0)) //цикл по строкам
            {
                while (j < matrix.GetLength(1)) //цикл по столбцам
                {
                    matrix[i, j] = random.Next(0,100);
                    Console.Write(matrix[i, j] + " ");

                    if (matrix[i, j] != 0 && (i != j))
                    {
                        flag = false;
                    }
                    j++;
                }
                Console.WriteLine();
                i++;
                j = 0;
            }

            i = 0;

            Console.WriteLine("Напишите число ");
            number = Convert.ToInt32(Console.ReadLine());

            i = 0;

            while (i < matrix.GetLength(0))   //на диагонали
            {
                if (matrix[i, i] != number)
                {
                    flag = false;
                }
                i++;
            }

            if (flag)
                Console.WriteLine("Матрица является произведением числа и единичной матрицы");
            else
                Console.WriteLine("Матрица не является произведением числа и единичной матрицы");

            Console.ReadKey();
        }
    }
}