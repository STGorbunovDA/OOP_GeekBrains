using HomeWork_3.Models;
using HomeWork_3.Models.Base;

namespace HomeWork_3.Repositories
{
    internal class FiguraRepository
    {
        internal List<Figura> GetFiguresPlane()
        {
            List<Figura> figures = new List<Figura>();

            Figura triangle = new Triangle(3.0, 2.0, 3.0);

            Figura rectangle = new Rectangle(2.0, 3.0);

            Figura square = new Square(3.0);

            Figura circle = new Circle(4.0);

            figures.Add(triangle);
            figures.Add(rectangle);
            figures.Add(square);
            figures.Add(circle);

            return figures;

        }
    }
}
