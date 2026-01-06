package id.ac.binus.bloaters.solution;

public class LongMethodDecomposeConditional {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int bilangan = 11;
		
		if(bilangan%2 == 1 && bilangan > 0) {
			System.out.println("Bilangan bulat ganjil positif");
		} else {
			System.out.println("Bukan bilangan bulat ganjil positif");
		}
	}

}
