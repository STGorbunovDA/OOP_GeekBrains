using FigthingClub.Presenters;
using FigthingClub.View;
using FigthingClub.View.Base;

namespace FigthingClub
{
    class Program
    {
        static void Main()
        {
            IView view = new ConsoleView();
            Presenter presenter = new(view);
            presenter.AppRun();
        }
    }
}