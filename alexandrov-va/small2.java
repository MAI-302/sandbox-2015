	package small2;

import java.util.Scanner;
import java.util.Stack;

public class small2 {
	
	static int counter;
 
    public static boolean validate(String input) 
    {
        for (char c : input.toCharArray()) 
        {
            if (c == ')' && counter == 0) 
            {
                return false;
            }
            if (c == '(') 
            {
                counter++;
            }
            if (counter > 0 && c == ')') 
            {
                    counter--;
            }
        }
        return (counter == 0);
    }
	
	public static void main(String[] args) 
	{
		
		String str;
		Scanner input = new Scanner(System.in);	
		counter = 0;
		
		str = input.next();
		
		boolean correct = validate(str);
		System.out.println("Скобки расставлены " + (correct ? "" : "не") + "правильно");
	}

}
