//Лаба №7
//Найти минимальный из максимальных элементов строк двумерного массива
//цикл do...while

using System;

namespace Third
{
	/// <summary>
	/// Main class - основной класс программы
	/// для поиска минимального из максимальных
	/// элементов строк двумерного массива
	/// </summary>

	class MainClass
	{
		/// <summary>
		/// Точка входа программы, основной метод.
		/// </summary>
		/// <param name="args">Аргументы для запуска в командной строке(терминале)</param>

		public static void Main (string[] args)
		{
			//Объявление переменных
			int StrCount = 0;
			int ColumnCount = 0;	//Количество строк и столбцов
			int i, j;	//Счетчики итераций циклов
			Random rnd = new Random ();	//Генератор случайных чисел

			#region Ввод размера матрицы
			Console.WriteLine ("\nВведите количество строк матрицы.");

			try
			{
			StrCount = int.Parse (Console.ReadLine());
				if (StrCount <= 0)
				{
					Console.WriteLine("Размер матрицы может быть только положительным!");
					return;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR: ошибка ввода!");
				return;
			}
			catch (OverflowException)
			{
				Console.WriteLine("ERROR: переполнение!");
				return;
			}
			//Эхо-печать введенного количества строк
			Console.Write ("StrCount = " + StrCount + "\n\n");

			Console.WriteLine ("\nВведите количество столбцов матрицы.");

			try
			{
				ColumnCount = int.Parse (Console.ReadLine());
				if (ColumnCount <= 0)
				{
					Console.WriteLine("Размер матрицы может быть только положительным!");
					return;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("ERROR: ошибка ввода!");
				return;
			}
			catch (OverflowException)
			{
				Console.WriteLine("ERROR: переполнение!");
				return;
			}


			//Эхо-печать введенного количества столбцов
			Console.Write ("ColumnCount = " + ColumnCount + "\n\n");


			#endregion


			try
			{
			//Динамическое выделение памяти под исходный массив
			int[,] Array = new int[StrCount, ColumnCount];
		

			Console.WriteLine ("Исходный массив:");

			#region Генерация элементов массива и эхо - печать
			i = 0;
			do
			{
				j = 0;
				do
				{
					Array[i, j] = rnd.Next(1, 100);
					Console.Write (Array [i, j] + " ");
					j++;
				}
				while (j != ColumnCount);

				Console.WriteLine ();
				i++;
			}
			while (i != StrCount);

			#endregion

			#region Min_Max по строкам
			// Один проход по матрице, без дополнительного массива
			i = 0;
			do
			{
				j = 0;
				do
				{
					if (Array[i, j] >= Array[i,0])
					{
						Array [i,0] = Array [i, j];
					}

					j++;
				}
				while (j != ColumnCount);

				if (Array[i,0] <= Array[0,0])
				{
					Array[0,0] = Array[i,0];
				}

				i++;
			}
			while (i != StrCount);

			#endregion

			//Вывод минимального из максимумов по строкам двумерного массива
			Console.WriteLine ("\nMinMax = " + Array[0,0]);
			}//end try
			catch (OutOfMemoryException) 
			{
				Console.WriteLine("ERROR: недостаточно памяти для создания матрицы заданного размера!");
				return;
			}
		}//end Main
	}
}
