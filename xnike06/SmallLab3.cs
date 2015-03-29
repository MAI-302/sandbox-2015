using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLab3
{
    class SmallLab3
    {
        static void Main(string[] args)
        {
            int i, j;
            bool check = true;
            Console.Write("Введите размерность матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int[,] myarray = new int[n, n];
            Random random = new Random();
            //Заполнение матрицы автоматически числами от -50 до 50
            i = 0;
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    myarray[i, j] = random.Next(-50, 50);
                    Console.Write(myarray[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            int first = myarray[0, 0]; //Число
            i = 0;
            while (i < n)
            {
                j = 0;
                if (myarray[i, i] != first)
                    check = false;
                while (j < n)
                {
                    if ((myarray[i, j] != 0) && (i != j))
                        check = false;
                    j++;
                }
                i++;
            }
            if (check == false)
                Console.WriteLine("Mатрица не является произведение числа и единичной матрицы.");
            else
                Console.WriteLine("Матрица я вляется произведением числа  " + first + "  и единичной матрицы");
            Console.ReadKey();
        }
    }
}
