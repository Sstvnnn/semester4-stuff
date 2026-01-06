package id.ac.binus.bloaters.solution;

public class LargeClass {
	
	public int luasPersegi(int sisi) {
		return sisi*sisi;
	}
	
	public int kelilingPersegi(int sisi) {
		return 4*sisi;
	}
	
	public int luasPersegiPanjang(int panjang, int lebar) {
		return panjang*lebar;
	}
	
	public int kelilingPersegiPanjang(int panjang, int lebar) {
		return 2*(panjang+lebar);
	}
	
	public int luasSegitiga (int alas, int tinggi) {
		return (alas*tinggi)/2;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Persegi persegi = new Persegi(5);
		System.out.println("Luas Persegi : " + persegi.luas());
		System.out.println("Keliling Persegi : " + persegi.keliling());
		
		PersegiPanjang persegiPanjang = new PersegiPanjang(2, 3);
		System.out.println("Luas Persegi : " + persegiPanjang.luas());
		System.out.println("Keliling Persegi : " + persegiPanjang.keliling());
		
		BangunDatar segitiga = new BangunDatar() {
			private int alas = 2;
			private int tinggi = 3;
			@Override
			public int luas() {
				// TODO Auto-generated method stub
				return this.alas * this.tinggi / 2;
			}
			
			@Override
			public int keliling() {
				// TODO Auto-generated method stub
				return 0;
			}
		};
		
		System.out.println("Luas Segitiga : " + segitiga.luas());
	}

}
