import java.util.*;

public class Class {
	
	public static void main(String[] args)
	{
		int MaxInRow = -2147483648;
		int MinInColumn = 2147483647;
		int rows = 3;
		int cols = 3;
		int[][] arr = new int[rows][cols];
		int i = 0, j;
		
		
		Random Rnd = new Random();
		
		do
		{
			j = 0;
			do
			{
			arr[i][j] = Rnd.nextInt(20);
			System.out.print(arr[i][j] + " ");
			
			j++;
			}
			while(j < cols);
			System.out.println("");
			
			i++;
		}
		while(i < rows);
		
		i = 0;
		do
		{
			j = 0;
			do
			{
				 if (MaxInRow < arr[i][j])
                 {
                     MaxInRow = arr[i][j];
                 }
				 j++;
			}
			while (j < cols);
			if (MaxInRow < MinInColumn)
            {
                MinInColumn = MaxInRow;
            }
            MaxInRow = 0;
            i++;
		}
		while(i < rows);
		 System.out.println("Минимальный из максимальных элементов строк двумерного массива " + MinInColumn);
	}
}

		
		
		
	
	

