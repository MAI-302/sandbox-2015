package small1;

import java.util.Scanner;

public class small1 {

	//Функция факториала
	static int fact(int x)
	{
		if(x <= 1)
		{
			return 1;
		}
		else
		{
			return x*fact(x-1);
		}
	}
	
	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		
		System.out.print("Введите слово:\t");
		String str = input.next();				//Исходное слово
		
		int count = fact(str.length());			//Начальное значение кол-ва анаграмм
		boolean[] letters = new boolean[str.length()];		//Массив флагов для слова. Предназначен для того, чтобы не рассматривать рассмотренные буквы.
		int repeats = 0;									//Кол-во повторов для каждой буквы
		char ch, let;
		int i, j;
		
		//Заполнение массива флагов true
		i = 0;
		while(i < str.length())
		{
			letters[i] = true;
			i++;
		}
		
		//Цикл подсчета повторов
		i = 0;
		while(i < str.length())
		{
			ch = str.toCharArray()[i];
			repeats = 0;
			
			//Если буква не рас	смотрена
			if(letters[i])
			{
				//Цикл от рассматриваемой буквы до конца
				j = i;
				while(j < str.length())
				{
					let = str.toCharArray()[j];
					//Если найдена еще одна такая буква, то ставим на этой букве флаг false, и инкрементируем счетчик повторов
					if(let == ch)
					{
						letters[j] = false;
						repeats++;
					}
					j++;
				}
			}
			count = count / fact(repeats);		//Корректировка кол-ва анаграмм
			i++;
		}
		
		System.out.println("Количество анаграмм: " + count);
	}

}
