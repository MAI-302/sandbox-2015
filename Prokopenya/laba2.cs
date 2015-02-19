using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two
{
    class laba2
    {
        static void Main(string[] args)
        {
            string str;
            char left  = '(';
            char right = ')';
            int[] count = new int[2];

            Console.WriteLine("Напишите текст ");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char c;
                c = str[i];
                if (c == left)               
                    count[0]++;

                if (c == right)
                    count[1]++;
            }

            if (count[0] == count[1] && count[0] == 0)
            {
                Console.WriteLine("В тексте нет скобок ");
                Console.ReadKey(true);
                Environment.Exit(0);
            }

            if (count[0] == count[1] && count[0] !=0)
            {
                Console.WriteLine("Все скобки расставленны верно ");
            }
            else
            {
                Console.WriteLine("Проверьте кол-во расставленных скобок");
                Console.WriteLine("Левых скобок " + count[0]);
                Console.WriteLine("Правых скобок " + count[1]);
            }
            Console.ReadKey(true);


        }
    }
}
