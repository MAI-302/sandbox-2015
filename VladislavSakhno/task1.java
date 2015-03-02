
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
		System.out.println("ведите слово");
		String str = br.nextLine();
		
		 n = 1;
		for(int i = 1; i < str.length()+1; i++){
		n *= i;
			
		}
		
	long k = fac(str.length());
		System.out.println("Число анаграм : "+  n+ " через функцию :" + k);
		
	}
	

}
