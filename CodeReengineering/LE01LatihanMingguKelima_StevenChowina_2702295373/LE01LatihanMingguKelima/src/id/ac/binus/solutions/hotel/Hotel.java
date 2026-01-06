package id.ac.binus.solutions.hotel;

import java.util.ArrayList;

public class Hotel {
	private ArrayList<Room> roomList;
	private Integer daysRent;
	
	public Hotel(Integer daysRent) {
		super();
		this.roomList = new ArrayList<>();
		this.daysRent = daysRent;
	}
	
	public void addRoom(String roomType) {
		roomList.add(new Room(roomType));
	}

    public long calculateTotalPrice() {
        long totalPrice = 0;
        for (Room room : roomList) {
            totalPrice += room.getRoomPrice() * daysRent;
        }
        return totalPrice;
    }
	
    public void displayTotalPrice() {
    	long totalPrice = calculateTotalPrice();
    	System.out.println("Total : " + totalPrice );
    }

	public ArrayList<Room> getRoomList() {
		return roomList;
	}

	public Integer getDaysRent() {
		return daysRent;
	}
    
	
}
