using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Matrix
    {
        public int row, col;
        public int[,] p; //Двумерный массив

        public Matrix(int n, int m)
        {
            row = n;
            col = m;
            p = new int[n, m];
        }

        public void InitMartix()   //Заполнение матрицы 
        {


            Random rd = new Random();
            int i = 0;
            do
            {
                int j = 0;
                do
                {

                    p[i, j] = rd.Next(10);
                    j++;
                } while (j < row);
                i++;
            } while (i < row);
        }
        public void ShowMartix() // вывод матрицы 
        {
            int i = 0;
            do
            {
                int j = 0;
                do
                {
                    Console.Write(p[i, j]);
                    Console.Write(' ');
                    j++;
                } while (j < row);
                Console.WriteLine();
                i++;
            } while (i < row);
        }
        //дискрименант матрицы  2x2
        public double Det2x2()
        {
            double det;
            det = p[0, 0] * p[1, 1] - p[0, 1] * p[1, 0];

            return det;
        }
        //минор матрицы 
        public Matrix Minor(int a, int b)
        {

            int i, j, p, q;
            Matrix MIN = new Matrix(row - 1, col - 1);
            Console.WriteLine();
            i = 0;
            p = 0;
            do
            {
                j = 0; q = 0;
                do
                {
                    if (i == a) i++;
                    if (j == b) j++;
                    MIN.p[p, q] = this.p[i, j];

                    Console.Write(MIN.p[p, q]);

                    j++; q++;

                } while (q < MIN.row);
                i++;
                p++;
                Console.WriteLine();

            } while (p < MIN.row);
            Console.WriteLine();


            return MIN;

        }

    }

    class Lab5
    {//дискриминант матрицы 
        public static double Det(Matrix B)
        {
            int n;
            int signo;
            double det = 0;
            // проверки 
            if (B.row != B.col)
            {
                Console.WriteLine("Матрица должна быть квадратной!");
                return 0;
            }
            else
                if (B.row == 1)
                    return B.p[0, 0];
                else
                    if (B.row == 2)
                        return B.Det2x2();
                    else


                        n = 0;
            do
            { //проверка четности для четных стобцов 
                //знак =(+),нечетных =(-)
                if ((n & 1) == 0)
                {
                    signo = 1;
                }
                else
                {
                    signo = -1;
                }
                //(n&1)==0 ? (signo=1):(signo=-1);
                det = det + signo * B.p[0, n] * Det(B.Minor(0, n));
                n++;
            } while (n < B.col);

            return det;
        }
        static void Main(string[] args)
        {
            Matrix m = new Matrix(3, 3);
            m.InitMartix();
            Console.WriteLine("Матрица:");
            m.ShowMartix();
            Console.WriteLine("Миноры:");
            double d = Det(m);
            Console.Write("Опредилитель матрицы равен: ");
            Console.Write(d);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}