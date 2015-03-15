using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_1
{
    class task1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово :");
            string input_word = Console.ReadLine();

            ulong result = Factorial((ulong)(input_word.Length));		//Анаграммы слова без учета повторов
            bool[] letters = new bool[input_word.Length];		        //Массив для помечения просмотренных букв
            ulong repeats = 0;									        //Количество повторов для каждой буквы
            char[] chars = input_word.ToCharArray();					
            int i, j;

            
            i = 0;
            while (i < input_word.Length)
            {
                repeats = 0;
                j = i;
                while (j < input_word.Length)
                {
                    //Если найдена такая же буква, и она еще не была рассмотрена, отмечаем ее и инкрементируем repeats
                    if (chars[i] == chars[j] && !letters[j])
                    {
                        letters[j] = true;
                        repeats++;
                    }
                    j++;
                }
                //Условие воизбежание деления на ноль
                if (repeats > 0)
                {
                    result = result / Factorial(repeats);  
                }
                i++;
            }
            Console.WriteLine("Колличество аннаграм  : " + result);// вывод результата
	        Console.ReadKey();
        }
        private static ulong Factorial(ulong n) // рекурсивный подсчёт факториала
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
