package small2;

import java.util.Scanner;

public class small2 {

	public static void main(String[] args) 
	{
		
		String str;								//Слово
		Scanner input = new Scanner(System.in);	
		
		str = input.next();
		char let;								//i-ый символ в слове
		
		int count = 0;								//Счетчик разности кол-ва левых и правых скобок
		
		int i = 0;
		
		do
		{
			let = str.toCharArray()[i];
			
			//Подсчет числа левых скобок и правых скобок
			if(let == '(')
				count++;
			if(let == ')')
				count--;
			
			//Проверка нахождения правой скобки после левой
			if(let == '(' && str.indexOf(')', i) == -1)
			{
				System.out.println("Скобки расставлены неправильно.");
				System.exit(0);
			}
			
			i++;
		}
		while(i < str.length());
		
		//Проверка числа левых скобок и правых скобок
		if(count == 0)
		{
			System.out.println("Скобки расставлены правильно.");
		}
		else
		{
			System.out.println("Скобки расставлены неправильно.");
		}
	}

}
