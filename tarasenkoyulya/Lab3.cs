using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Lab3
    {
        static void Main(string[] args)
        {
            bool check = true;
            Console.Write("Введите размерность матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[n, n];
            Random rand = new Random();
            //Заполнение матрицы автоматически числами от -50 до 50
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myMatrix[i, j] = rand.Next(-50, 50);
                    Console.Write(myMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int first = myMatrix[0, 0]; //Число
            for (int i = 0; i < n; i++)
            {
                if (myMatrix[i, i] != first)
                    check = false;
                for (int j = 0; j < n; j++)
                {
                    if ((myMatrix[i, j] != 0) && (i != j))
                        check = false;
                }
            }
            if (check == false)
                Console.WriteLine("Mатрица не является произведение числа и единичной матрицы.");
            else
                Console.WriteLine("Матрица я вляется произведением числа  " + first + "  и единичной матрицы");
            Console.ReadKey();
        }
    }
}
