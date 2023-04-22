using HomeWork_3.Infrastructure;
using HomeWork_3.Models.Base;

namespace HomeWork_3.Models
{
    internal class Rectangle : Polygon, IGetArea
    {
        public override string Name => "Прямоугольник";
        public Rectangle(double width, double height) : base(4, new double[] { width, height, width, height })
        {
            if (width <= 0.0 || height <= 0.0 || width == height)
                new UnknownFigura();
        }

        public Rectangle(double width) : base(4, new double[] { width, width, width, width })
        {
            if (width <= 0.0)
                new UnknownFigura();
        }

        public double GetArea()
        {
            Area = LSides[0] * LSides[1];
            return Area;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
