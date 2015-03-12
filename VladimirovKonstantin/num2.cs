using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool count = false;
            int result = 0;
            Console.WriteLine("Введите выражение ");
            string a = Console.ReadLine();
			
            for (int i = 0; i < a.Length; i++) //Просматриваем выражение в поисках открывающей скобки
            {
                if (a[i] == '(') 
                    for (int j = i + 1; j < a.Length; j++) // Если мы её нашли, то начинаем искать закрывающую скобку
                    {
                        if ((a[j]==')')&&(count==true)) // Нашли закрывающую, отлично, начинаем искать следующую открывающую
                        {
                            result++;
                            break;
                        }
                        else
                        
                            if ((a[j]==')')&&(count==false))// Если между скобками пустота, то мы такие скобки не считаем
                                break;
                            else 
                                if ((a[j]!=' ')&&(a[j]!='(')&&(count==false))// Если между скобками есть хоть 1 элемент и это не ( или  "пробел", то мы считаем их "полными"
                                    count = true;

                    }
            }
            Console.WriteLine("В выражении " + result + " скобок."); // Выводим количество "полных" скобок 
            Console.ReadKey(true);
        }
    }
}
