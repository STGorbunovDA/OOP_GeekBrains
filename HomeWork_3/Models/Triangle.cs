using HomeWork_3.Infrastructure;
using HomeWork_3.Models.Base;

namespace HomeWork_3.Models
{
    internal class Triangle : Polygon, IGetArea
    {
        public override string Name => "Треугольник";
        public Triangle(double a, double b, double c) : base(3, new double[] { a, b, c })
        {
            if ((a <= 0.0 || b <= 0.0 || c <= 0.0) || !(a + b > c && a + c > b && b + c > a))
                new UnknownFigura();
        }
        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            // Формула Герона
            Area = Math.Sqrt(p * (p - LSides[0]) * (p - LSides[1]) * (p - LSides[2]));
            return Area;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
