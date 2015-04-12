using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            bool[] povtor = new bool[str.Length]; 
            int[] schetchik = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (!povtor[j])) //проверка равенства символов и его повтора
                    {
                        schetchik[i]++;
                        povtor[j] = true;
                    }
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                schetchik[i] = schetchik[i] + 1; // т.к. массив начинается с 0
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (!povtor[i])
                {
                    Console.WriteLine("Символ " + str[i] + " встречается " + schetchik[i] +  " раз."); //вывод результата
                }
            }
            System.Console.ReadKey();
        }
    }
}
