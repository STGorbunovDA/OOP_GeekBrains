using Notes.Presenters;
using Notes.View;
using Notes.View.Base;

namespace Notes
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