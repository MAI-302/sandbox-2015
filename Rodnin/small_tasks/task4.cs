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
            char[] chars = input.ToCharArray();

            var Hash = new HashSet<char>(); //Создаем множество 

            foreach (var x in chars) // Добавляем те элементы, которых еще нет в множестве
                if (!Hash.Contains(x))
                    Hash.Add(x);

            Array.Resize(ref chars, Hash.Count); //Изменяем размер массива
            chars = Hash.ToArray(); //Передаем элементы из множества обратно в массив

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
