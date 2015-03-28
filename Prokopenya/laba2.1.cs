using System;
using System.Text;
using System.Text.RegularExpressions;


namespace laba2.1
{
    class laba2
    {
        public static void Main()
        {
            Console.WriteLine("Напишите текст: ");
            string str = Console.ReadLine();
            int res = 0;
            for (int i = 0; i < str.Length && res >= 0; i++)
            {
                if (str[i] == '(') res++;
                if (str[i] == ')') res--;
            }                
            Console.WriteLine((res == 0) ? "Скобки расставлены верно" : "Скобки расставлены неправильно");
            Console.ReadKey();

        }
    }
}
