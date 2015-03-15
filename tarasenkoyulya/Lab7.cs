using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Lab7
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int IndexOfMax = 0;//индекс максимального элемента в строке
            int MinOfMaxs = int.MaxValue;//минимакс

            Random rnd = new Random();

            Console.Write("Введите количество строк row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            if(row <= 0)
            {
                Console.WriteLine("Некорректное число строк матрицы!");
                Environment.Exit(0);
            }

            Console.Write("Введите количество столбцов col: ");
            int col = Convert.ToInt32(Console.ReadLine());
             if(col <= 0)
            {
                Console.WriteLine("Некорректное число строк матрицы!");
                Environment.Exit(0);
            }

            int [,] myarray = new int [row, col]; //задаём двумерный массив(матрицу)

            Console.WriteLine();
            Console.WriteLine("Исходая матрица:");

            //заполнение и вывод исходной матрицы числами от -50 до 50
            while (i < myarray.GetLength(0))
            {
                j = 0;
                while (j < myarray.GetLength(1))
                {
                    myarray[i, j] = rnd.Next(-50, 50);//элементу массива присваиваем рандомное значение от -50 до 50
                    Console.Write(myarray[i, j] + " ");
                    j++;
                } 
                Console.WriteLine();
                i++;
            } 

            Console.WriteLine();

            i = 0;

                while (i < myarray.GetLength(0))
                {
                    j = 0;
                    while (j < myarray.GetLength(1))
                    {
                        if (myarray[i, j] > myarray[i, IndexOfMax])
                        {
                            IndexOfMax = j;
                        }
                        j++;
                    }
                    if (myarray[i, IndexOfMax] < MinOfMaxs)
                    {
                        MinOfMaxs = myarray[i, IndexOfMax];
                    }
                i++;
                }

            Console.WriteLine("Минимальный элемент из максимальных элементов по строкам: " + MinOfMaxs);

            Console.ReadKey();
        }
    }
}
