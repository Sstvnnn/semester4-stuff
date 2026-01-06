package id.ac.binus.solutions.hotel;

import java.util.ArrayList;
import java.util.Arrays;

public class Room {
	private String roomType;
	private ArrayList<String> roomFacilities;
	private long roomPrice;
	
	public Room(String roomType) {
		this.roomType = roomType;
		setRoomDetails();
	}
	
	private void setRoomDetails() {
		roomFacilities = new ArrayList<>();
		
		switch(roomType.toLowerCase()) {
			case "economy":
				roomPrice = 350000;
				roomFacilities.addAll(Arrays.asList("Non-AC", "Single Bed", "Non-Water Heater"));
				break;
			case "suite":
				roomPrice = 450000;
				roomFacilities.addAll(Arrays.asList("AC", "Single Bed", "Water Heater"));
				break;
			case "president":
				roomPrice = 600000;
				roomFacilities.addAll(Arrays.asList("AC", "Bed : King Size", "Water Heater"));
				break;
			default:
				roomPrice = 0;
				roomFacilities.addAll(Arrays.asList("", "", ""));
		}
	}

	public String getRoomType() {
		return roomType;
	}

	public ArrayList<String> getRoomFacilities() {
		return roomFacilities;
	}

	public long getRoomPrice() {
		return roomPrice;
	}
	
	
}
