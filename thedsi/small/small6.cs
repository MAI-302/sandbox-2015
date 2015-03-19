using System;

class average
{
	public static void Main()
	{
		Console.Write("Введите длину массива: ");
		int n = int.Parse(Console.ReadLine());
		double[] arr = new double[n];
		
		Random rnd = new Random();
		for(int i = 0; i < n; i++)
		{
			arr[i] = rnd.Next(-30, 30);
		}
		
		Console.WriteLine("Исходный массив:");
		foreach(double x in arr)
		{
			Console.Write("{0:0.##} ", x);
		}
		Console.WriteLine();
		
		double[] arr2 = new double[n];
		arr2[0] =   (arr[0]   + arr[1]  ) / 2;
		arr2[n-1] = (arr[n-2] + arr[n-1]) / 2;
		for(int i = 1; i < n - 1; i++)
		{
			arr2[i] = (arr[i-1] + arr[i] + arr[i+1]) / 3;
		}
		
		Console.WriteLine("Массив, состоящий из средних арифметических соседних элементов:");
		foreach(double x in arr2)
		{
			Console.Write("{0:0.##} ", x);
		}
		Console.WriteLine();
	}

}