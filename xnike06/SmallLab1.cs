using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallLab1
{
    class SmallLab1
    {
        static long Factorial(long n) //вычисление факториала
        {

            if (n <= 1)
            {
                return n; //конец работы
            }
            else
            {
                return (n * Factorial(n - 1)); //рекурсия
            }
        }

        static void Main(string[] args)
        {
            int i, j;
            long litera_quantity; //количество повторов одной буквы
            Console.Write("Введите слово: ");
            string word = Console.ReadLine(); //вводимое пользователем слово
            long anagramm_quantity = Factorial(word.Length); //количество возможных анаграм(в начале присвается число без учета повторяющихся букв)
            bool[] litera_check = new bool[word.Length]; //повторялась ли буква ранее
            i = 0;
            while (i < word.Length)
            {
                j = 2;
                litera_quantity = 1; //количество повторов одной буквы
                while (j < word.Length)
                {
                    if (word[i] == word[j] && litera_check[j] == false) //проверка на повторение буквы, а так же на наличие её предыдущих проверок
                    {
                        litera_quantity++;//увеличиваем количество повторов одной буквы
                        litera_check[j] = true; //для предотврвщения дальнейших проверок на эту букву
                    }
                    j++;
                }
                if(litera_quantity > 1) //для предотвращения лишних вызовов
                {
                    anagramm_quantity /= Factorial(litera_quantity);//убираем повторяющиеся анаграммы
                }
                i++;
            }
            Console.WriteLine("Количество анаграмм в слове " + word + ": " + anagramm_quantity);
            Console.ReadKey();

        }

    }
}
