namespace Notes.View.Base
{
    internal interface IView
    {
        void ShowMenuOne();
        void ShowMessage(string message);
        string ReadString();
        int ReadChooseInt();
    }
}
