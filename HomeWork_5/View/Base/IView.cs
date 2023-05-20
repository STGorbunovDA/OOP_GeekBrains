﻿namespace HomeWork_5.View.Base
{
    internal interface IView
    {
        void ShowMenuOne();
        void ShowMessage(string message);
        void ShowMenuTwo();
        string ReadString();
        int ReadChooseInt();
    }
}
