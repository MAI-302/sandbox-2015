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
		char[] chars = str.toCharArray();					//Строка в виде массива символов
		
		//Цикл подсчета повторов
		i = 0;
		while(i < str.length())
		{
			repeats = 0;

			//Цикл от рассматриваемой буквы до конца
			j = i + 1;
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
			
			if(!letters[i])
				System.out.println("Буква " + chars[i] + " встречается " + (repeats+1) + " раз.");
			
			i++;
		}
	}

}
