using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace four
{
    class laba4
    {
        static void Main(string[] args)
        {
            var chars = new Dictionary<char, int>();
            char c;
            int i = 0;

            Console.WriteLine("Напишите текст");
            string str = Console.ReadLine();

            do
            {
                c = str[i];
                if (!Char.IsControl(c))
                    if (chars.ContainsKey(c))
                        chars[c]++;
                    else
                        chars.Add(c, 1);
                i++;
            } while (i < str.Length);

            foreach (var kp in chars)
                Console.WriteLine("Символ '{0}' встречается {1} раз", kp.Key, kp.Value);
            Console.ReadKey();

        }
    }
}
