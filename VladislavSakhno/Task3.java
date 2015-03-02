import java.util.Scanner;


public class Task3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int n = 4;
		int m = 5;
		Scanner s = new Scanner (System.in);
		boolean flag = false;
		
		int a[][]  = new int [n][m];
		
		for (int i = 0; i < n; i++){
			for(int j = 0; j < m; j++){
				a[i][j]= s.nextInt(); 
			}
		}
		
		for (int i = 0; i < n; i++){
			for(int j = 0; j < m; j++){
				if((i!=j) && (a[i][j]!=0)){
					flag = true;
				}
			}
		}
		if(flag==true){
			System.out.println("матрица удовлетворяет требованиям");
		}
	}

}
