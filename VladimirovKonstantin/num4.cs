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
            Console.WriteLine("Введите слово/строку ");
			string a=Console.ReadLine();
            bool[] a_bool = new bool[a.Length]; // массив флагов, отмечает переменные, проверенные на повторение  
			int [] povtory = new int [a.Length];// массив в котором содержатся счетчики повтора для каждого символа
            for (int i = 0; i < povtory.Length; i++)
            {
                povtory[i] = 1; // для удобства счет начнётся с 1
            }
			for (int i=0;i<a.Length;i++)
			{
				for (int j =i+1; j<a.Length; j++)
				{
					if ((a[i]==a[j]) && (!a_bool[j])) //проверка равенства символов и наличия флага
					{
						povtory[i]++; 
						a_bool[j] = true;
					}
				}			
			}
			for (int i=0;i<a.Length;i++)
			{
			if (!a_bool[i])	
				{
				Console.WriteLine("Символ " + a[i]+" встречается "+povtory[i]+" раз."); //вывод результата
				}
			}
			System.Console.ReadKey();
        }
    }
}
