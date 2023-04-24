using HomeWork_5.Presenters;
using HomeWork_5.View;
using HomeWork_5.View.Base;

namespace HomeWork_5
{
    internal class Program
    {
        static void Main()
        {
            IView view = new ConsoleView();
            ConfigsPresenter presenter = new(view);
            presenter.AppRun();
        }
    }
}