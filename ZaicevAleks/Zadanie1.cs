using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово ");
	        string word=Console.ReadLine();

            int i, j;

            bool[] letbool = new bool[word.Length]; 
	        int [] repeatCount = new int [word.Length]; 

            i = 0;
            while(i < repeatCount.Length)
            {
                repeatCount[i] = 1;  
                i++;
            }

            i = 0;
	        while(i<word.Length) //Цикл по строке
	        {
                j = i+1;
		        while(j<word.Length) //Цикл от рассматриваемой буквы
		        {
			        if ((word[i]==word[j]) && (!letbool[j])) 
			        {
				        repeatCount[i]++; // подсчет повтора
				        letbool[j] = true; // буква отмечена
			        }
                    j++;
		        }

                //Если повторения найдены, возводим их число в факториал
		        if (repeatCount[i] !=1)
		        {
                        int temp = repeatCount[i]; 
                        repeatCount[i] = factorial(temp);
		        }
                i++;
            }

            int result = factorial(word.Length);

            i = 0;
            //деление исходного количества анаграмм на каждое число повторений (кроме 1) в факториале
	        while(i<word.Length)
		    {
			    if(repeatCount[i] != 1)
			    {
                        	    result /= repeatCount[i];
			    }
                i++;
		    }

	        Console.WriteLine("Колличество аннаграм в слове : " + result);
	        System.Console.ReadKey();
        }

        private static int factorial(int n)
        {
            int factorial =1;
            int i = 2;
            while(i<=n)
            {
            	factorial*=i;
                i++;
            }
            return factorial;
        }
    }
}
