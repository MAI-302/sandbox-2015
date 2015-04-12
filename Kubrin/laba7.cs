using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {

            // создание двумерного массива 
            Console.WriteLine("Введите количество строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] A = new int[n, m];
            Random random = new Random();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                for (int j = 0; j < A.GetLength(1); ++j)
                {
                    A[i, j] = random.Next(1, 100);//рандомное заполнение
                    Console.Write(A[i, j] + "   ");

                }
                Console.WriteLine("");
            }
            int min= A[0,0];
            //нахождение максимального элемента в строке
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                int max = A[i, 0];

                for (int j = 0; j < A.GetLength(1); ++j)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }

                    if (i == 0)        // минимальному присваиваем первое максимальное
                    {
                        min = max;
                    }
                }
              
                  
                if (max < min)
                {
                      min = max;
                }
                
           }

     
            Console.WriteLine("min:{0}", min);
            Console.ReadLine();


        }
    }
}