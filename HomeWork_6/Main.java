public class Main{
	public static void main(String[] args){
		User user = new User("Bob");
		System.out.println(new Persister(user).GetPersisterUser());
		System.out.println(new Report(user).GetReportUser());
	}
}