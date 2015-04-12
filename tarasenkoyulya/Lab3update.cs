using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 //Дана квадратная матрица. Определить, является ли она произведением числа и единичной матрицы.
{
    class Lab3
    {
        static void Main(string[] args)
        {
            bool check = true;
            //Забиваем матрицу вручную
            int[,] myMatrix = { {6, 0, 0},
                                {0, 6, 0} ,
                                {0, 0, 6} };
            for (int i=0; i<myMatrix.GetLength(0); i++)
            {
                for (int j=0; j<myMatrix.GetLength(1); j++)
                {
                    Console.Write(myMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
           
            int first = myMatrix[0, 0]; //Число

            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    if ((myMatrix[i, j] != 0) && (i != j) || (myMatrix[i, i] != first))
                        check = false;
                }
            }
            if (check == false)
                Console.WriteLine("Mатрица не является произведение числа и единичной матрицы.");
            else
                Console.WriteLine("Матрица является произведением числа  " + first + "  и единичной матрицы");
            Console.ReadKey();
        }
    }
}
