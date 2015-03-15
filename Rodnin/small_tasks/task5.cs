using System;

namespace small5
{
    class task5
    {
        static void Main()
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            double [,] matrix = new double[n, n];
            Random rand = new Random();
            int I, J;
            Console.WriteLine();

            Console.WriteLine("Матрица заполненная случайными числами в диапазоне от -10 до 10");
           
            I = 0;
            do
            {
                J = 0;
                do
                {
                    matrix[I, J] = rand.Next(-10, 10);
                    Console.Write(matrix[I, J] + " ");
                    J++;
                } while (J < matrix.GetLength(1));
                Console.WriteLine();
                I++;
            } while (I < matrix.GetLength(0));

            double det = Determinant(matrix);
            Console.WriteLine("Определитель матрицы равен:" + det);
            Console.ReadKey();
        }

        private static double Determinant(double[,] matrix)
        {
            if (matrix.Length == 1)
            {
                return matrix[0, 0];                                //Исключение для матрицы 1х1(число)
            }
            if (matrix.Length == 4)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]; //Исключение для матрицы 2х2
            }

            int I, J, K;
            double sign = 1, result = 0;

            K = 0;
            do
            {
                double[,] minor = GetMinor(matrix, K);              //Поиск минора
                Console.WriteLine("Минор №" + (K + 1));                 //Вывод минора
                I = 0;
                do
                {
                    J = 0;
                    do
                    {
                        Console.Write(minor[I, J] + " ");
                        J++;
                    } while (J < minor.GetLength(1));
                    Console.WriteLine();
                    I++;
                } while (I < minor.GetLength(0));

                result += sign * matrix[0, K] * Determinant(minor); //Вычисление определителя разложением по первой строке
                sign = -sign;                                       //Учет четности столбца
                K++;
            } while (K < matrix.GetLength(1));
                        return result;
        }

        private static double[,] GetMinor(double[,] matrix, int n)
        {
            double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < n; j++)                 
                {
                    result[i - 1, j] = matrix[i, j];                //Запись первой строки минора
                }
                for (int j = n + 1; j < matrix.GetLength(0); j++)   
                {
                    result[i - 1, j - 1] = matrix[i, j];            //Запись остальных строк
                }                    
            }
            return result;
        }
    }
}
