using System;
using System.Text;
using System.Text.RegularExpressions;


namespace small2
{
    class task2
    {
        public static void Main()
        {
            Console.WriteLine("Введите выражение: ");
            string str = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < str.Length && result >= 0; i++)
            {
                if (str[i] == '(')
                {
                    result++;
                }
                if (str[i] == ')')
                {
                    result--;
                }
            }                
            Console.WriteLine((result == 0) ? "Скобки расставлены верно" : "Скобки расставлены неправильно");
            Console.ReadKey(true);

        }
    }
}
