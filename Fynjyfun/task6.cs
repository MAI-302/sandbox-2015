//Лаба №6
//С клавиатуры вводится длина целочисленного массива
//Элементы массива генерируются случайным образом
//Создать на его основе массив из средних арифметических соседних элементов
//Цикл while!

using System;

namespace Second
{
	/// <summary>
	/// Main class - основной класс программы
	/// для создания массива средних арифметических соседних элементов исходного массива
	/// Элементы массива генерируются случайным образом
	/// </summary>

	class MainClass
	{
		/// <summary>
		/// Точка входа программы, основной метод.
		/// </summary>
		/// <param name="args">Аргументы для запуска в командной строке(терминале)</param>

		public static void Main (string[] args)
		{
			int N = 0;	//Размер массива
			Random rnd = new Random ();	//Генератор случайных чисел
			int i;	//Счетчик итераций циклов


			Console.WriteLine ("\nВведите длину массива!");

			//Ввод длины массива с клавиатуры
			try
			{
			N = int.Parse (Console.ReadLine());
				if (N <= 0)
				{
					Console.WriteLine("Размер массива должен быть положительным!");
					return;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine ("ERROR: ошибка ввода!");
				return;
			}
			catch (OverflowException) 
			{
				Console.WriteLine ("ERROR: переполнение!");
				return;
			}

			Console.Write ("N = " + N + "\n\n");	//Эхо-печать введенного значения длины массива


			try
			{
			//Динамическое выделение памяти под исходный и измененный массивы
			int[] Array = new int[N];	//Исходный
			float[] Array2 = new float[Array.Length];	//Измененный

			Console.WriteLine ("Исходный массив:");

			//Цикл для заполнения исходного массива случайными целыми числами (от 1 до 100)
			//Эхо-печать
			i= 0;
			while (i < Array.Length)
			{
				Array [i] = rnd.Next (1, 100);
				Console.Write (Array [i] + " ");
				i++;
			}

			//Заполнение второго (измененного) массива
			//средними арифметическими соседних элементов исходного массива

			//Изменение крайних элементов
			if (N != 1) //соседи есть
			{
			Console.WriteLine ("\nМассив средних арифметических соседних элементов:");

			Array2 [0] = Array [1];
			Array2 [N - 1] = Array [N - 2];
	
			//Изменение элементов, имеющих по 2 соседних
			i = 1;
			while(i < Array2.Length-1)
			{
				Array2 [i] = (float)(Array [i - 1] + Array [i + 1]) / 2;
				i++;
			}

			//Цикл для вывода массива из средних арифметических
			i = 0;
			while (i < Array2.Length)
			{
				Console.Write (Array2[i] + " ");
				i++;
			}

			}//end if
			else //соседей нет
			{
					Console.WriteLine ("\nМассив состоит из одного элемента = " + Array[0]);
			}

			}//end try
			catch (OutOfMemoryException) 
			{
				Console.WriteLine ("Недостаточно памяти для создания массива заданного размера!");
			}

			Console.WriteLine ();

		}
	}
}
