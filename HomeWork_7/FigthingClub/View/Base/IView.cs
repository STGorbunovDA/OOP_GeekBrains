namespace FigthingClub.View.Base
{
    public interface IView
    {
        void PrintMenu();
        void PrintRules();
        void ShowMessage(string message);
        string ReadString();
        int ReadChooseInt();
    }
}
