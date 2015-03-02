using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_7
{
    class small7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m:");
            int m = int.Parse(Console.ReadLine());

            int[,] mass = new int[n, m];
            Random rand = new Random();
            int I, J;
            Console.WriteLine();

            Console.WriteLine("Матрица заполненная случайными числами в диапазоне от -100 до 100");

            I = 0;
		    while(I < mass.GetLength(0))
		    {
			    J = 0;
			    while(J < mass.GetLength(1))
			    {
				        mass[I, J] = rand.Next(-100, 100);
                        Console.Write(mass[I, J] + " ");
				        J++;
			    }
			    Console.WriteLine();
			    I++;
		    }

            
            int MaxOfStr = 0;				//Индекс максимального элемента в строке
            int minmax = int.MaxValue;		//Минимакс
		    
		
		    
		    I = 0;
		    while(I < mass.GetLength(0))
		    {
			    J = 0;
			    while(J < mass.GetLength(1))
			    {
			        if (mass[I, J] > mass[I, MaxOfStr]) 
			        {
			            MaxOfStr = J;
			        }
				    J++;
			    }

		        if (mass[I, MaxOfStr] < minmax) 
		        {
		            minmax = mass[I, MaxOfStr];
		        }									
			    I++;
		    }

            Console.WriteLine("Минимальный среди максимальных : " + minmax);
            Console.ReadKey();
        }
    }
}
