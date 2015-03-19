using System;
using System.Linq;

class minmax
{
	public static void Main()
	{
		Console.Write("Введите количество строк: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("Введите количество столбцов: ");
		int m = int.Parse(Console.ReadLine());
		
		double[,] arr = new double[n, m];
		
		Console.WriteLine("Введите элементы, разделяя их пробелом:");
		for(int i = 0; i < n; i++)
		{
			Console.Write("Строка {0}: ", i);
			double[] line = Console.ReadLine().Split(new[]{' '})
						.Select(x => double.Parse(x))
						.ToArray();
			if(line.Count() != m)
			{
				Console.WriteLine("Ошибка: введено неверное количество элементов.");
				return;
			}
			for(int j = 0; j < m; j++)
			{
				arr[i, j] = line[j];
			}
		}
		int mini = -1;
		int minj = 0;
		for(int i = 0; i < n; i++)
		{
			int maxj = 0;
			for(int j = 1; j < m; j++)
			{
				if(arr[i, j] > arr[i, maxj]) maxj = j;
			}
			if(mini < 0 || arr[i, maxj] < arr[mini, minj])
			{
				mini = i;
				minj = maxj;
			}
		}
		Console.WriteLine("Минимальный из максимальных - элемент [{0},{1}] = {2}",
												mini, minj, arr[mini, minj]);
	}

}