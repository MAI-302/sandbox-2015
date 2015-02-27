package small2;

import java.util.Scanner;

public class small2 {

	public static void main(String[] args) 
	{
		String str;
		Scanner input = new Scanner(System.in);	
		
		str = input.next();
		char let;
		
		
		int count = 0;
		String sub = "";
		
		int i = 0;
		while(i < str.length())
		{
			let = str.toCharArray()[i];
			if(let == '(')
				count++;
			if(let == ')')
				count--;
			
			i++;
		}
		
		if(count == 0)
		{
			System.out.println("Выполнено необходимое условие: левых скобок столько же, сколько и правых.");
		}
		else
		{
			System.out.println("Необходимое условие не выполнено: количество левых и правых скобок не совпадает.");
			System.exit(0);
		}
		
		i = 0;
		while(i < str.length())
		{
			if(str.toCharArray()[i] == '(')
			{
				sub = str.substring(i);
			}
			if(sub.indexOf(')') == -1)
			{
				System.out.println("Не выполнено достаточное условие: после левой скобки не найдена правая.");
				System.exit(0);
			}
			
			i++;
		}
		
		System.out.println("Выполнено достаточное условие: после каждой левой скобки есть хотя бы одна правая.");
	}

}
