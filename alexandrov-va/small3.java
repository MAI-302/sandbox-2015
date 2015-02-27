package small3;

public class small3 
{

	public static void main(String[] args) 
	{
		boolean isScalar1 = true;		//Первое условие скалярной матрицы
		boolean isScalar2 = true;		//Второе условие скалярной матрицы
		
		int arr[][] = 
			{
				{4, 0, 0},
				{0, 5, 0},
				{1, 0, 4}
			};
		
		//Вывод матрицы
		for(int i = 0; i < arr.length; i++)
		{
			for(int j = 0; j < arr.length; j++)
			{
				System.out.print(arr[i][j] + "\t");
			}
			System.out.println("");
		}
		
		//Проверка первого условия - все элементы не на главной диагонали нулевые
		for(int i = 0; i < arr.length; i++)
		{
			for(int j = 0; j < arr.length; j++)
			{
				if(i != j && arr[i][j] != 0 && isScalar1)
				{
					System.out.println("Найден ненулевой элемент, находящийся не на главной диагонали.");
					isScalar1 = false;
				}
			}
		}

		//Проверка второго условия - все элементы на главной диагонали одинаковые
		for(int i = 1; i < arr.length; i++)
		{
			for(int j = 1; j < arr.length; j++)
			{
				if(i == j && arr[i][j] != arr[i-1][j-1] && isScalar2)
				{
					System.out.println("На главной диагонали элементы различаются.");
					isScalar2 = false;
				}
			}
		}
		
		//Вывод
		if(isScalar1 && isScalar2)
		{
			System.out.println("Матрица скалярная.");
		}
		else
		{
			System.out.println("Матрица не является скалярной");
		}
	}

}
