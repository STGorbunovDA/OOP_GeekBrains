public class Report implements IGetInfoUser {
    private User user;

    public Report(User user)
    {
        this.user = user;
    }
    public String GetInfoUser() {
        return "Report for user: " + user.getName();
    }
}
