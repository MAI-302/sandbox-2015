using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Lab2
    {
        public static void Main()
        {
            Console.Write("Введите выражение: ");
            string str = Console.ReadLine();
            int result = 0;//всё хорошо и скобки расставлены верно
            for (int i = 0; i < str.Length && result >= 0; i++)
            {
                if (str[i] == '(')//если i-ый элемент строки = '('
                {
                    result++;
                }
                if (str[i] == ')')//если i-ый элемент строки = ')'
                {
                    result--;
                }
            }
            Console.WriteLine((result == 0) ? "Скобки расставлены верно" : "Скобки расставлены неправильно");
            Console.ReadKey(true);

        }
    }
}

