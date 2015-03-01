package small3;

public class small3 
{

	public static void main(String[] args) 
	{
		
		int arr[][] = 
			{
				{4, 0, 0},
				{0, 4, 0},
				{0, 0, 4}
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
		
		//Проверяем, скалярная ли матрица
		for(int i = 0; i < arr.length; i++)
		{
			for(int j = 0; j < arr.length; j++)
			{
				if((i != j && arr[i][j] != 0) || (i == j && (i+j)>1 && arr[i][j] != arr[i-1][j-1]))
				{
					System.out.println("Матрица не скалярная.");
					System.exit(0);
				}
			}
		}
		
		System.out.println("Матрица скалярная.");
	}

}
