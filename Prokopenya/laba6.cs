using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace six
{
    class laba6
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int n = 0;
            int i = 0;

            Console.WriteLine("Напишите длину массива");
            n =  Convert.ToInt32(Console.ReadLine());

            double[] mas = new double[n];
            double[] sredArif = new double[n];

            Console.WriteLine("Исходный массив ");

            while (i < n) 
            {
                mas[i] = random.Next(0,100);
                Console.Write(mas[i] + " ");
                i++;
            }

            Console.WriteLine();

            sredArif[0] = (mas[0] + mas[1]) / 2;        //для первого элемента

            sredArif[n-1] = (mas[n-1] + mas[n - 2]) / 2;//для последнего

            //дальше у всех уже 2 соседних элемента
            i = 1; 

            while (i < n - 1) 
            {                              
                    sredArif[i] = (mas[i] + mas[i - 1] + mas[i + 1]) / 3;
                    i++;                    
            }

            i = 0;

            Console.WriteLine("Массив из средних арифметичиских соседних элементов ");

            while (i < n) 
            { 
                Console.WriteLine("{0:0.##}",sredArif[i]);
                i++; 
            }

            Console.ReadKey();
        }
    }
}
