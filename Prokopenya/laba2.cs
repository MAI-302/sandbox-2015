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
            int count = 0;
            int left = 0;
            int right = 0;
            bool flag = true;

            Console.WriteLine("Напишите текст ");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char c;
                c = str[i];

                if (c == '(')
                {
                    left++;
                }

                if ((left == 0 && c == ')') || (left == right && c == ')'))
                {
                    flag = false;
                }

                if (c == ')')
                {
                    right++;
                }

            }
            
            if (left == 0 && right == 0)
            {
                Console.WriteLine("В тексте нет скобок ");
                Console.ReadKey(true);
                Environment.Exit(0);
            }

            if (left == right && flag == true)
            {
                Console.WriteLine("Все скобки расставленны верно ");
            }
            else
            {
                Console.WriteLine("Проверьте кол-во расставленных скобок");
            }
            Console.ReadKey(true);


        }
    }
}
