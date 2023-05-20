public class Persister implements IGetInfoUser {
	private User user;
	
	public Persister(User user){
		this.user = user;
	}
	public String GetInfoUser(){
		return "Save user: " + user.getName();
	}

}