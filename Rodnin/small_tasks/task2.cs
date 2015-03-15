using System;
using System.Text;
using System.Text.RegularExpressions;


namespace small2
{
    class task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение");
            string input = Console.ReadLine();

            Regex r = new Regex("[^()]*", RegexOptions.IgnoreCase);
            Console.WriteLine(r.Replace(input, ""));

            StringBuilder str = new StringBuilder(input);
            int i = 0;         
            do
            {
                if ((str[i] == '(' && str[i + 1] == ')'))
                {
                    str.Remove(i, 1);
                    str.Remove(i, 1);
                    i = -1;
                }
                i++;
            } while (i < str.Length-1);
            

            if (str.Length == 0)
            {
                Console.WriteLine("Скобки расставлены правильно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены неправильно");
            }               
            Console.ReadKey(true);
        }
    }
}
