public class Report implements IGetReportUser {
    private User user;

    public Report(User user)
    {
        this.user = user;
    }
    public String GetReportUser() {
        return "Report for user: " + user.getName();
    }
}
