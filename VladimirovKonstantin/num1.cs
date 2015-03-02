using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово ");
	    string a=Console.ReadLine();
            bool[] a_bool = new bool[a.Length]; // массив флагов, отмечает переменные, проверенные на повторение 
	    int [] repetitions = new int [a.Length]; // массив в котором содержится число перестановок одинаковых символов
            for (int i = 0; i < repetitions.Length; i++)
            {
                repetitions[i] = 1;  // для удобства счет начнётся с 1
            }
	    for (int i=0;i<a.Length;i++) 
	    {
		for (int j =i+1; j<a.Length; j++) // сравненние со следующего символа, чтобы не сравнивать символы дважды
		{
			if ((a[i]==a[j]) && (!a_bool[j])) //проверка равенства символов и наличия флага
			{
				repetitions[i]++; // подсчёт кол-ва повторов
				a_bool[j] = true;// пометка повторяющихся символов
			}
		}
		if (repetitions[i] !=1)
		{
                    int temp = repetitions[i];
                    repetitions[i] = factorial(temp);//рассчёт числа перестановок одинаковых символов (факториал)
		}			
            }

            ulong result = factorial(a.Length); // рассчёт максимально возможного кол-ва анаграмм
	    for (int i=0; i<a.Length;i++)
		{
			if(repetitions[i] != 1)
			{
                        	result /= repetitions[i];// удаление лишнего числа перестановок
			}
		}
            result--;// - входное слово
	    Console.WriteLine("Колличество аннаграм  : " + result);// вывод результата
	    System.Console.ReadKey();
        }

        private static ulong factorial(int n) // рекурсивный подсчёт факториала
        {
            factorial =1;
            for (int i=2;i<=n;i++)
            {
            	factorial*=i;
            }
            return factorial;
        }
    }
}
