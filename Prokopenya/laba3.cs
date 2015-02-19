using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three
{
    class laba3
    {
        static void Main(string[] args)
        {
            int number; //число для умножения
            int i = 0;  //счетчик цикла
            int j = 0;  //счетник цикла
            int n;      //размерность матрицы
            bool flag = true; //результат работы программы


            Console.WriteLine("Напишите размерность квадратной матрицы ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,n];
            Console.WriteLine("Введите матрицу ");

            while (i < n) //цикл по строкам
            {
                while (j < n) //цикл по столбцам
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());                  
                    if (matrix[i, j] != 0 && (i != j))
                    {
                        flag = false;
                    }
                    j++;
                }
                i++;
                j = 0;
            }

            i = 0;

            Console.WriteLine("Введеная матрица:");
            //печать введенной матрицы на экран
            while (i < n)
            {
                while (j < n)
                {
                    Console.Write(matrix[i, j] + "\t"); 
                    j++;
                }
                Console.WriteLine("\n");
                i++;
                j = 0;
            }

            Console.WriteLine("Напишите число ");
            number = Convert.ToInt32(Console.ReadLine());

            i = 0;
            
            while (i < n)   //на диагонали
            {
                if (matrix[i,i] != number)
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
