import java.util.Scanner;


		public class task2 {

			public static void main(String[] args) {

				Scanner br = new Scanner(System.in);
				System.out.println("ведите выражение");
				String str = br.nextLine();
				
				char right ='(';
				char left = ')';
				int a = 0;
				int b = 0;
				
				for (int i = 0; i <str.length(); i++){
					if( str[i] = right) {
						a++;
					}
				
					if(str[i] = left){
						b++;
					}
				}
					if( a== b){
						System.out.println("верно");
					}
					else{
						System.out.println("неверно");
					}
						

			}

		}

	


