package id.ac.binus.bloaters.problems;

public class LongMethodDecomposeConditional {

	public static boolean isOddPositive(int bilangan) {
		if(bilangan > 0) {
			if(bilangan%2 == 1) {
				return true;
			}
		} 
		return false;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int bilangan = 11;
		
		if(isOddPositive(bilangan)) {
			System.out.println("Bilangan bulat ganjil positif");
		} else {
			System.out.println("Bukan bilangan bulat ganjil positif");
		}
	}

}
