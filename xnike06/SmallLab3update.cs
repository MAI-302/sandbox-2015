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
            //Забиваем матрицу вручную
            int[,] myarray = { {6, 0, 0},
                               {0, 6, 0} ,
                               {0, 0, 6} };
            i = 0;
            while (i < myarray.GetLength(0))
            {
                j = 0;
                while(j < myarray.GetLength(1))
                {
                    Console.Write(myarray[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            int first = myarray[0, 0]; //Число
            i = 0;
            while (i < myarray.GetLength(0))
            {
                j = 0;
                if (myarray[i, i] != first)
                    check = false;
                while (j < myarray.GetLength(1))
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
