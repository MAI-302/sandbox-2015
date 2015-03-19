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
            bool check = true;
            Console.WriteLine("Введите размерность матрицы");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Сгенерировать матрицу [G] или ввести с клавиатуры [I] ?");
            string decition = Console.ReadLine();
            switch(decition)
            {
                case "G":
                    {
                        Random rnd = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matrix[i, j] = rnd.Next(0, 100);
                                Console.Write(matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "I":
                    {
                        Console.WriteLine("Введите матрицу:\n");
                        for (int i = 0; i < n; i++)
                        {
                            string s = Console.ReadLine();
                            int j = 0;
                            foreach (int v in s.Split(' ').Select(v => Convert.ToInt32(v)))
                            {
                                matrix[i, j++] = v;
                            }
                        }
                        Console.WriteLine("Полученная матрица:");
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < n; ++j)
                            {
                                Console.Write(matrix[i, j] + "\t");
                            }
                            Console.WriteLine("\n");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введён неизвесный символ, матрица будет сгенерирована");
                        Random rnd = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matrix[i, j] = rnd.Next(0, 100);
                                Console.Write(matrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
            }
            int first = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] != first)
                    check = false;
                for (int j = 0; j < n; j++)
                {
                    if ((matrix[i, j] != 0) && (i != j))
                        check = false;
                }
            }
            if (check==false)
                Console.WriteLine("Mатрица не является произведение числа и единичной матрицы.");
            else
                Console.WriteLine("Матрица я вляется произведением числа  "+first+"  и единичной матрицы");
            Console.ReadKey();
        }
    }
}
