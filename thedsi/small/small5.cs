using System;
using System.Linq;

class determinant
{
    public static void Main()
    {
        Console.Write("Введите размер матрицы: ");
        int n = int.Parse(Console.ReadLine());
        double[][] M = new double[n][];
        Console.WriteLine("Введите строки матрицы, разделяя элементы пробелом");        
        for(int i = 0; i < n; i++)
        {
            Console.Write("Строка {0}: ", i + 1);
            M[i] = Console.ReadLine().Split(new[]{' '})
                                     .Select(x => double.Parse(x))
                                     .ToArray();
            if(M[i].Count() != n)
            {
                Console.WriteLine("Ошибка: введено неверное количество элементов.");
                return;
            }
        }
        Console.WriteLine("Определитель: {0}", det(M));
    }
    
    static double det(double[][] M)
    {
        if(M.Length < 2) return M[0][0];
        double r = 0;       
        for(int i = 0; i < M.Length; i++)
        {
            double Alg = det( M.Where((x,j) => j != i).ToArray() );
            if((i + M.Length) % 2 == 0) Alg = -Alg;
            r += Alg * M[i][M.Length - 1];
        }
        return r;
    }
}