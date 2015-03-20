using System;
using System.Linq;

class identprod
{
    public static void Main()
    {
        Console.Write("Введите размер матрицы: ");
        int n = int.Parse(Console.ReadLine());
        int[][] M = new int[n][];
        Console.WriteLine("Введите строки матрицы, разделяя элементы пробелом");        
        for(int i = 0; i < n; i++)
        {
            Console.Write("Строка {0}: ", i + 1);
            M[i] = Console.ReadLine().Split(new[]{' '})
                                     .Select(x => int.Parse(x))
                                     .ToArray();
            if(M[i].Count() != n)
            {
                Console.WriteLine("Ошибка: введено неверное количество элементов.");
                return;
            }
        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i != j)
                {
                    if(M[i][j] != 0)
                    {
                        Console.WriteLine("Обнаружены ненулевые элементы вне главной диагонали");
                        return;
                    }
                }
                else
                {
                    if(M[i][j] != M[0][0])
                    {
                        Console.WriteLine("Обнаружены разные значения на главной диагонали");
                        return;
                    }
                }
            }
        }
        Console.WriteLine("Матрица является произведением единичной матрицы и числа {0}", M[0][0]);
    }
}
