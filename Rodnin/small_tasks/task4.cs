using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите текст");
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray().Distinct().ToArray(); //Получаем массив символов входящих в input

            int i = 0;
            while (i < chars.Length)
            {
                Console.WriteLine("Символ {0} встречается  {1} раз", chars[i], input.ToCharArray().Count(x => x == chars[i]));
                i++;
            }
            Console.ReadKey();
        }
    }
}
