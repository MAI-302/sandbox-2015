package small6;

import java.util.Random;
import java.util.Scanner;

public class small6 
{
	public static void main(String[] args) 
	{
		int size;
		
		Scanner input = new Scanner(System.in);
		Random rand = new Random();
		
		System.out.println("Введите размер массива: ");
		
		size = input.nextInt();
		
		int[] arr = new int[size];				//Исходный массив
		float[] ave = new float[size];			//Массив средних арифмтических
		
		//Заполнение исходного массива случайными числами
		System.out.print("Элементы массива, сгенерированные случайным образом:");
		for(int i = 0; i < size; i++)
		{
			arr[i] = rand.nextInt(200) - 100;
			System.out.print(arr[i] + "; ");
		}
		
		//Расчитывание первого и последнего элементов массива средних арифметчиеских
		ave[0] = arr[0] / 2f;
		ave[size - 1] = arr[size - 1] / 2f;
		
		//Расчитывание остальных элементов массива средних арифметчиеских
		for(int i = 1; i < (size-1); i++)
		{
			ave[i] = (arr[i-1] + arr[i+1]) / 2f;
		}
		
		System.out.print("\nМассив из средних арифметических соседних элементов исходного массива:");
		for(int i = 0; i < size; i++)
		{
			System.out.print(ave[i] + "; ");
		}
	}
}
