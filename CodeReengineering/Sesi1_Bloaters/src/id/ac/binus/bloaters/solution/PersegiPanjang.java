package id.ac.binus.bloaters.solution;

public class PersegiPanjang implements BangunDatar {
	private int panjang;
	private int lebar;
	
	public PersegiPanjang(int panjang, int lebar) {
		super();
		this.panjang = panjang;
		this.lebar = lebar;
	}

	@Override
	public int luas() {
		// TODO Auto-generated method stub
		return this.panjang * this.lebar;
	}

	@Override
	public int keliling() {
		// TODO Auto-generated method stub
		return 2 * (this.panjang + this.lebar);
	}

}
