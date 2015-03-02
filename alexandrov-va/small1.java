package small1;

import java.util.Scanner;

public class small1 {

	//Функция факториала
	static double fact(double x)
	{
		double i = 2;
		double res = 1;
		
		if(x <= 1)
		{
			return 1;
		}
		else
		{
			while(i <= x)
			{
				res *= i;
				i++;
			}
		}
		
		return res;
	}
	
	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		
		System.out.print("Введите слово:\t");
		String str = input.next();				//Исходное слово
		
		double count = fact(str.length());					//Начальное значение кол-ва анаграмм
		boolean[] letters = new boolean[str.length()];		//Массив флагов для слова. Предназначен для того, чтобы не рассматривать рассмотренные буквы.
		double repeats = 0;									//Кол-во повторов для каждой буквы
		char[] chars = str.toCharArray();					//Строка в виде массива символов
		int i, j;
		
		//Цикл подсчета повторов
		i = 0;
		while(i < str.length())
		{
			repeats = 0;
			//Цикл от рассматриваемой буквы до конца
			j = i;
			while(j < str.length())
			{
				//Если найдена еще одна такая буква и буква не рассмотрена, то ставим на этой букве флаг false, и инкрементируем счетчик повторов
				if(chars[i] == chars[j] && !letters[j])
				{
					letters[j] = true;
					repeats++;
				}
				j++;
			}
			count = count / fact(repeats);		//Корректировка кол-ва анаграмм
			i++;
		}
		
		System.out.println("Количество анаграмм: " + count);
	}

}
