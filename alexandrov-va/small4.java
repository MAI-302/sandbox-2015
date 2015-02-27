package small4;

import java.util.Scanner;

public class small4 
{

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		
		String str = input.next();
		
		boolean[] letters = new boolean[str.length()];
		int i, j, repeats;
		char ch, let;
		

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
				System.out.println("Буква " + ch + " встречается " + repeats + " раз.");
			}
			i++;
		}
	}

}
