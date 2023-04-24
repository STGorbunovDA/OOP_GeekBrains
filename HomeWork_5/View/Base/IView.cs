namespace HomeWork_5.View.Base
{
    internal interface IView
    {
        void ShowMenuOne();
        void ShowMessage(string message);
        int ReadChooseInt();
        string ReadString();
        void ShowMenuTwo();

    }
}
