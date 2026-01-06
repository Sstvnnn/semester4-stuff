package id.ac.binus.solutions.carrepair;

public class Car {
	private String carName;
	private String engineName;
	private String tireName;
	private Integer tireRadius;
	private Integer enginePower;
	private Float carRating;
	
	public Car(String carName, String engineName, String tireName, Integer tireRadius, Integer enginePower,
			Float carRating) {
		super();
		this.carName = carName;
		this.engineName = engineName;
		this.tireName = tireName;
		this.tireRadius = tireRadius;
		this.enginePower = enginePower;
		this.carRating = carRating;
	}
	
	public String getCarName() {
		return carName;
	}
	public String getEngineName() {
		return engineName;
	}
	public String getTireName() {
		return tireName;
	}
	public Integer getTireRadius() {
		return tireRadius;
	}
	public Integer getEnginePower() {
		return enginePower;
	}
	public Float getCarRating() {
		return carRating;
	}
}
