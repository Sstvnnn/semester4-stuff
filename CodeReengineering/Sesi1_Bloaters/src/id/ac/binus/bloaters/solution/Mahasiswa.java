package id.ac.binus.bloaters.solution;

public class Mahasiswa {
	private String nim;
	private String nama;
	private String domisili;
	private String email;
	private String phone;
	
	public Mahasiswa(String nim, String nama, String domisili, String email, String phone) {
		super();
		this.nim = nim;
		this.nama = nama;
		this.domisili = domisili;
		this.email = email;
		this.phone = phone;
	}

	public String getNim() {
		return nim;
	}

	public String getNama() {
		return nama;
	}

	public String getDomisili() {
		return domisili;
	}

	public String getEmail() {
		return email;
	}

	public String getPhone() {
		return phone;
	}
	
	
	
	
}
