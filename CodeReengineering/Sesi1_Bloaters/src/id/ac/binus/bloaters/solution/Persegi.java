package id.ac.binus.bloaters.solution;

public class Persegi implements BangunDatar{
	private int sisi;
	
	public Persegi(int sisi) {
		super();
		this.sisi = sisi;
	}
	
	@Override
	public int luas() {
		// TODO Auto-generated method stub
		return this.sisi *  this.sisi;
	}

	@Override
	public int keliling() {
		// TODO Auto-generated method stub
		return 4 * this.sisi;
	}
}
