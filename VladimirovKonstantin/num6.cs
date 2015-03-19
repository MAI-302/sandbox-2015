using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_sharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int [] mass = new int[n];
            double[] result = new double[n+1];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                    mass[i] = rnd.Next(0, 100);
                    Console.Write(mass[i] + "\t");
            }
            Console.WriteLine();
            result[0]=mass[1];
            result[n]=mass[n-2];
            for (int i = 0; i < n-1; i++)
            {
                result[i + 1] = (mass[i] + mass[i + 1]) / 2.0;
            }
            for (int i = 0; i < n+1; i++)
            {
                Console.Write("{0:G}",result[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
