package small7;

import java.util.ArrayList;
import java.util.Arrays;

public class small7 
{

	public static void main(String[] args) 
	{
		int[][] arr = {
				{-5, 4, 3},
				{6, 0, -3},
				{3, -2, -1}};
		
		int jMax = 0;						//Индекс максимального элемента для текущей строки
		int minmax = Integer.MAX_VALUE;		//Минимальный среди максимальных элементов строк
		int i, j;
		
		System.out.println("Исходный массив:");
		i = 0;
		while(i < arr.length)
		{
			j = 0;
			while(j < arr[i].length)
			{
				System.out.print(arr[i][j] + " \t");
				
				j++;
			}
			
			System.out.println("");
			
			i++;
		}
		
		//Поиск минимакса
		i = 0;
		while(i < arr.length)
		{
			j = 0;
			while(j < arr[i].length)
			{
				if(arr[i][j] > arr[i][jMax])				//Поиск максимума в i-ой строке
					jMax = j;
				
				j++;
			}
			
			System.out.println(String.format("Строка %d, максимальный элемент: %d", i, arr[i][jMax]));
			
			if(arr[i][jMax] < minmax)						//Сравнивание максимума с минимаксом
				minmax = arr[i][jMax];						
			
			i++;
		}
		
		System.out.println("Минимальный среди максимальных элементов строк: " + minmax);
	}

}
