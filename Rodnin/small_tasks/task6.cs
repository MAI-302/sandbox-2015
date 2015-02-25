using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small6
{
    class small6
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Задайте длину массива n:");
            int n = int.Parse(Console.ReadLine());

            int[] massive = new int[n];
            double[] mean = new double[n];

            Console.WriteLine("Исходный массив: ");

            for (int i = 0; i < n; i++) // Заполнение массива числами от -100 до 100
            {
                massive[i] = random.Next(-100, 100);
                Console.Write(massive[i] + " ");  
            }

            Console.WriteLine(); 
            
            mean[0] = (massive[0] + massive[1]) / 2.0;   //Среднее арифм. для первого элемента

            mean[n - 1] = (massive[n - 1] + massive[n - 2]) / 2.0;  //Среднее арифм. для последнего элемента

            for (int i = 1; i < n - 1; i++) //Среднее арифм. для остальных элементов
            {               
                    mean[i] = (massive[i] + massive[i - 1] + massive[i + 1]) / 3.0;                
            }

            Console.WriteLine("Массив из средних арифметичиских соседних элементов: ");

            for (int i = 0; i < n; i++) //Вывод массива из средних арифметичиских соседних элементов с округлением до 3 знаков после запятой
            {                                                                                   
                Console.Write(Math.Round(mean[i],3) + " ");
            }

            Console.ReadKey();
        }
    }
}
