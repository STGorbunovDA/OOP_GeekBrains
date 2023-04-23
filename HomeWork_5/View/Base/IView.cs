namespace HomeWork_5.View.Base
{
    internal interface IView
    {
        void ShowMenu();
        void ShowMessage(string message);
        int ReadChooseInt();
        string ReadString();


    }
}
