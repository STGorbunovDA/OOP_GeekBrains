public class Persister implements IGetPersisterUser {
	private User user;
	
	public Persister(User user){
		this.user = user;
	}
	public String GetPersisterUser(){
		return "Save user: " + user.getName();
	}

}