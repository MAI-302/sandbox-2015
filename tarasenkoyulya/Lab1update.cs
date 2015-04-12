using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово :");
            string word = Console.ReadLine();

            ulong result = Factorial((ulong)(word.Length));//Анаграммы слова без учета повторов
            bool[] letters = new bool[word.Length];//Массив для помечения просмотренных букв
            ulong repeats = 0;//Количество повторов для каждой буквы
            char[] chars = word.ToCharArray();



            int i = 0;
            while (i < word.Length)
            {
                repeats = 0;
                int j = i;
                while (j < word.Length)
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
            Console.WriteLine("Количество анаграмм: " + result);//Вывод результата
            Console.ReadKey();
        }
        private static ulong Factorial(ulong n)//Рекурсивный подсчёт факториала
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
