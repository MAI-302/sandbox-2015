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
			int [] povtory = new int [a.Length]; // массив в котором содержится число перестановок одинаковых символов
            for (int i = 0; i < povtory.Length; i++)
            {
                povtory[i] = 1;  // для удобства счет начнётся с 1
            }
			for (int i=0;i<a.Length;i++) 
			{
				for (int j =i+1; j<a.Length; j++) // сравненние со следующего символа, чтобы не сравнивать символы дважды
				{
					if ((a[i]==a[j]) && (!a_bool[j])) //проверка равенства символов и наличия флага
					{
						povtory[i]++; // подсчёт кол-ва повторов
						a_bool[j] = true;// пометка повторяющихся символов
					}
				}
				if (povtory[i] !=1)
				{
                    int temp = povtory[i];
                    povtory[i] = factorial(temp);//рассчёт числа перестановок одинаковых символов (факториал)
				}			
			}

            float result = factorial(a.Length); // рассчёт максимально возможного кол-ва анаграмм
			for (int i=0; i<a.Length;i++)
			{
				if(povtory[i] != 1)
				{
                    result /= povtory[i];// удаление лишнего числа перестановок
				}
			}
			result--;// - входное слово
			Console.WriteLine("Колличество аннаграм  : " + result);// вывод результата
			System.Console.ReadKey();
        }

        private static int factorial(int n) // рекурсивный подсчёт факториала
        {
            if (n == 1)
                return n;
            else
                return n * factorial(n - 1);
        }
    }
}
