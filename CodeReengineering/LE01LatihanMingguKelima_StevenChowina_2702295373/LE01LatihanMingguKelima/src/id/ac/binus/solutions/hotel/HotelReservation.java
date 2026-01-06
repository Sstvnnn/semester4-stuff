package id.ac.binus.solutions.hotel;

import java.util.Scanner;

public class HotelReservation {
	private Scanner scan =  new Scanner(System.in);
	private Hotel hotel;
	
	private void inputVisitor() {
		System.out.print("Visitor's name : ");
		String name = scan.next();
		System.out.print("Visitor's address : ");
		String address = scan.next();	
	}
	
	private void addRoom(int totalOfRoom) {
        for (int i = 0; i < totalOfRoom; i++) {
            System.out.print("Enter type of room (economy/suite/president): ");
            String roomType = scan.nextLine();
            hotel.addRoom(roomType);
        }
	}
	private void inputRoom() {
		System.out.print("how many room? ");
		int totalOfRoom = scan.nextInt(); scan.nextLine();
		System.out.print("how many days? ");
		int daysRent = scan.nextInt(); scan.nextLine();
		
		hotel = new Hotel(daysRent);
		addRoom(totalOfRoom);
	}
	
	public HotelReservation() {
		inputVisitor();
		inputRoom();
		hotel.displayTotalPrice();
	}
	
	public static void main(String[] args) {
		new HotelReservation();
	}

}
