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
            char[] chars = input_word.ToCharArray();
            var Hash = new HashSet<char>(); //Создаем множество 

            foreach (var x in chars) // Добавляем те элементы, которых еще нет в множестве
                if (!Hash.Contains(x))
                {
                    Hash.Add(x);
                }              
            chars = Hash.ToArray(); //Передаем элементы из множества обратно в массив
            ulong result;
            if (Convert.ToInt32(input_word.Length) != Convert.ToInt32(chars.Length))
            {
                result = Factorial(Convert.ToInt32(input_word.Length)) / (Factorial(Convert.ToInt32(chars.Length)));
            }
            else
            {
                result = Factorial(Convert.ToInt32(input_word.Length));
            }
            result--;
	        Console.WriteLine("Колличество аннаграм  : " + result);// вывод результата
	        Console.ReadKey();
        }
        private static ulong Factorial(int n) // рекурсивный подсчёт факториала
        {
            if (n == 1)
            {
                return Convert.ToUInt64(n);
            }
            else
            {

                return Convert.ToUInt64(n) * Factorial(n - 1);
            }
        }
    }
}
