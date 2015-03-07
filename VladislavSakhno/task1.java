
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;


public class task1 {
	

	
	public static long fac( int n )		

    {
        if( n <= 1 )     // base case
            return 1;

        else
            return n * fac( n - 1 );
    }
    
	
	public static void main(String[] args) throws IOException{
		int n;
		Scanner br = new Scanner(System.in);
		System.out.println("âåäèòå ñëîâî");
		String str = br.nextLine();
		
		 n = 1;					     // _$$$$__$$___$$_$$$$$$_$$__$$__$$$$_____$$$__$$$$__$$__$$_$$__$$__$$$$
		for(int i = 1; i < str.length()+1; i++){     // $$__$$_$$$_$$$_$$_____$$_$$__$$__$$___$_$$_$$__$$_$$__$$_$$_$$__$$__$$
		n *= i;					     //	$$_____$$_$_$$_$$$$___$$$$___$$$$$$__$__$$_$$__$$__$$$$$_$$$$___$$$$$$
		}					     //	$$__$$_$$___$$_$$_____$$_$$__$$__$$_$$__$$_$$__$$_____$$_$$_$$__$$__$$
							     //	_$$$$__$$___$$_$$$$$$_$$__$$_$$__$$_$$__$$__$$$$______$$_$$__$$_$$__$$
	long k = fac(str.length());
		System.out.println("×èñëî àíàãðàì : "+  n+ " ÷åðåç ôóíêöèþ :" + k);
		
	}
	

}
