using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_3
{
    class task3
    {
        static void Main(string[] args)
        {
            bool ifMatrixIsNumberMultUnMatrix = true;

            Console.WriteLine("Введите размерность матрицы n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число :");
            int number = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random rand = new Random();
            Console.WriteLine();

            Console.WriteLine("Матрица заполненная случайными числами в диапазоне от -100 до 100");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    Console.Write(matrix[i, j] + " ");
                    
                }
                Console.WriteLine();
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i != j) && (matrix[i, j] != 0))
                    {
                        ifMatrixIsNumberMultUnMatrix = false;
                    }      
                }
                if (matrix[i, i] != number)
                {
                    ifMatrixIsNumberMultUnMatrix = false;
                } 
            }

            if (ifMatrixIsNumberMultUnMatrix)
            {
                Console.WriteLine("Матрица является произведением числа и единичной матрицы");
            }
            else
            {
                Console.WriteLine("Матрица не является произведением числа и единичной матрицы"); 
            }
            Console.ReadKey();
        }
    }
}
