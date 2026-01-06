package id.ac.binus.problems;

import java.util.Scanner;
import java.util.Vector;

/*
 * Smell Code : The Dispensable - Comments
 * Reason     : Terdapat Comment yang tidak dibutuhkan
 * Solution   : Hapus Comment dan beri penamaan varibel dan method yg jelas
 */

/*
 * Smell Code : The Dispensable - Duplicate Code
 * Reason     : Dua kondisi if dipisah bisa digabung menjadi satu
 * Solution   : Consolidate Conditional Expression
 */

/*
 * Smell Code : Object-Orientation Abusers - Primitive Obsession
 * Reason     : Informasi tentang object "Car" disimpan dalam beberapa Vector terpisah
 * Solution   : Buat class "Car" dan encapsulate
 */

/*
 * Smell Code : The Bloaters - Data Class
 * Reason     : Atribut dari Object Car dipisah-pisah ke Vector
 * Solution   : Extract Class
 */

/*
 * Smell Code : The Bloaters - Long Method
 * Reason     : Terlalu banyak coding didalam satu method
 * Solution   : Extract Method
 */

public class CarRepair {
	Scanner java = new Scanner(System.in);
	
	//Object Car punya Nama, Rating, Engine, Tire
	Vector<String> carName = new Vector<>();
	Vector<String> engineName = new Vector<>();
	Vector<String> tireName = new Vector<>();
	Vector<Integer> tireRadius = new Vector<>();
	Vector<Integer> enginePower = new Vector<>();
	Vector<Float> carRating = new Vector<>();

	boolean isBetween(int low, int high,int value){
		if(value<low) return false;
		if(value>high) return false;
		return true;
	}
	
	public CarRepair() {
		//Car 1
		carName.add("Mazda RX-8");
		carRating.add(8.9f);
		engineName.add("Mazda 13B-MSP Renesis");
		enginePower.add(247);
		tireName.add("PROXES R1R");
		tireRadius.add(18);
		//Car 2
		carName.add("Acura NSX");
		carRating.add(9.3f);
		engineName.add("Longitudinally mounted 3.5L Twin-Turbo V6");
		enginePower.add(480);
		tireName.add("Ventus V2");
		tireRadius.add(16);
		//Car 3
		carName.add("BMW M4");
		carRating.add(9.1f);
		engineName.add("3.0 L S55B30T0 twin turbo I6");
		enginePower.add(425);
		tireName.add("Azenis FK510");
		tireRadius.add(19);
		
		int n = 0;
		
		do{
			for(int i=0;i<25;i++){
				System.out.println();
			}
			System.out.println("1. View Car Spesification");
			System.out.println("2. Delete Car");
			System.out.println("3. Exit");
			do{
				System.out.print("Choose: ");
				n = java.nextInt(); java.nextLine();
			}while(!isBetween(1,2,n));
			switch(n){
			case 1:
				for(int i=0;i<25;i++){
					System.out.println();
				}
				
				for(int j=0;j<80;j++){
					System.out.print("-");
				}
				System.out.println();
				for(int i=0;i<carName.size();i++){
					System.out.println("Car No."+(i+1));
					System.out.println(carName.get(i)+" - "+carRating.get(i)+"/10.0 (*)");
					System.out.println("\tEngine - "+engineName.get(i));
					System.out.println("\t\tPower: "+enginePower.get(i)+" hp\n");
					System.out.println("\tTires - "+tireName.get(i));
					System.out.println("\t\tRadius: "+tireRadius.get(i)+"\"");
					for(int j=0;j<80;j++){
						System.out.print("-");
					}
					System.out.println();
				}
				java.nextLine();
				break;
			case 2:
				for(int i=0;i<25;i++){
					System.out.println();
				}
				
				for(int j=0;j<80;j++){
					System.out.print("-");
				}
				System.out.println();
				for(int i=0;i<carName.size();i++){
					System.out.println("Car No."+(i+1));
					System.out.println(carName.get(i)+" - "+carRating.get(i)+"/10.0");
					System.out.println("\tEngine - "+engineName.get(i));
					System.out.println("\t\tPower: "+enginePower.get(i)+" hp\n");
					System.out.println("\tTires - "+tireName.get(i));
					System.out.println("\t\tRadius: "+tireRadius.get(i)+"\"");
					for(int j=0;j<80;j++){
						System.out.print("-");
					}
					System.out.println();
				}
				int idx=0;
				do{
					System.out.printf("Which one you want to delete [1-%d]? ",carName.size());
					idx = java.nextInt(); java.nextLine();
				}while(!isBetween(1,carName.size(),idx));
				idx--;
				carName.remove(idx);
				carRating.remove(idx);
				engineName.remove(idx);
				enginePower.remove(idx);
				tireName.remove(idx);
				tireRadius.remove(idx);
				System.out.println("Delete Success!");
				java.nextLine();
				break;
			}
		}while(n!=3);
	}

	public static void main(String[] args) {
		new CarRepair();

	}
}
