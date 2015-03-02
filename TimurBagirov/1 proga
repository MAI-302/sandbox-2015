import java.util.*;

public class Programm

{
	
	static double fact(double x) {
		double a = 1;
		double i = 2;
		if(x <= 1){
			return 1;
		}
		else
		do{
			a *= i;
			i++;
		}
		while(i <= x);	

		return a;
	}

	public static void main(String[] args) {

		String Str;

		System.out.println("Введите слово (Можно ввести любую комбинацию символов)");
		Scanner scn = new Scanner(System.in);

		int i, j;
		
		double repeats;
		boolean[] letterPresent;

		do {
			Str = scn.next();
			Str = Str.toLowerCase();

			letterPresent = new boolean[Str.length()];

			double result = fact(Str.length());

			i = 0;
			do {
				repeats = 0;
				j = i;
				do {
					if (Str.toCharArray()[i] == Str.toCharArray()[j] && !letterPresent[j]) {
						letterPresent[j] = true;
						repeats++;
					}
					j++;
				} while (j < Str.length());
				result = result / fact(repeats);

				i++;
			} while (i < Str.length());
			System.out.println("Число комбинаций = " + result);

		} while (Str != "пока не надоест вводить слова =)");
	}
}
