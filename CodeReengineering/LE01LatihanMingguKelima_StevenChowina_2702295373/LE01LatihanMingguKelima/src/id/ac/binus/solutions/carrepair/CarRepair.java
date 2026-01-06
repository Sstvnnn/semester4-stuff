package id.ac.binus.solutions.carrepair;

import java.util.Scanner;
import java.util.Vector;

public class CarRepair {
	Scanner scan = new Scanner(System.in);
	Vector<Car> carList = new Vector<>();
	
	private void printEmpty() {
		for(int i=0;i<25;i++){
			System.out.println();
		}
	}
	
	private void printLine() {
		for(int j=0;j<80;j++){
			System.out.print("-");
		}
		System.out.println();
	}
	
	private void printMenu() {
		System.out.println("1. View Car Spesification");
		System.out.println("2. Delete Car");
		System.out.println("3. Exit");
	}
	
	private void getInput() {
		do{
			System.out.print("Choose: ");
			this.choice = scan.nextInt(); 
			scan.nextLine();
		}while(isBetween(this.choice, 3));
	}
	
	private boolean isBetween(int n, int high) {
		return n < 1 || n > high;
	}
	
	private void printCarDetails() {
		int i = 0;
		for (Car car : carList) {
			System.out.println("Car No."+ (i+1));
			System.out.println(car.getCarName() + " - " + car.getCarRating() + "/10.00 (*)");
			System.out.println("\tEngine - " + car.getEngineName());
			System.out.println("\t\tPower: " + car.getEnginePower() + " hp\n");
			System.out.println("\tTires - " + car.getTireName());
			System.out.println("\t\tRadius: " + car.getTireRadius() + "\"");
			printLine();
			i++;
		}
	}
	
	private void removeCarInput() {
		int index = 0;
		do{
			System.out.printf("Which one you want to delete [1-%d]? ",carList.size());
			index = scan.nextInt(); 
			scan.nextLine();
		}while(isBetween(index, carList.size()));
		removeCar(index-1);
	}
	
	private void removeCar(int index) {
		carList.remove(index);
		System.out.println("Delete Success!");
		scan.nextLine();
	}
	
	private void viewCarMenu() {
		printEmpty();
		printLine();
		printCarDetails();
		scan.nextLine();
	}
	
	private void deleteCarMenu() {
		printEmpty();
		printLine();
		printCarDetails();
		removeCarInput();
	}
	
	private void switchCase(int choice) {
		switch (choice) {
		case 1:
			viewCarMenu();
			break;
		case 2:
			deleteCarMenu();
			break;
		default:
			break;
		}
	}
	
	private void addCar() {
		carList.add(new Car("Mazda RX-8", "Mazda 13B-MSP Renesis", "PROXES R1R", 18, 247, 8.9f));
		carList.add(new Car("Acura NSX", "Longitudinally mounted 3.5L Twin-Turbo V6", "Ventus V2", 16, 480, 9.3f));
		carList.add(new Car("BMW M4", "3.0 L S55B30T0 twin turbo I6", "Azenis FK510", 19, 425, 9.1f));
	}
	
	private int choice = 0;
	
	public CarRepair() {
		addCar();
		do {
			printEmpty();
			printMenu();
			getInput();
			switchCase(choice);
		} while(choice !=3);
	}

	public static void main(String[] args) {
		new CarRepair();
	}

}
