using HomeWork_3.Infrastructure;
using HomeWork_3.Models.Base;

namespace HomeWork_3.Models
{
    internal class Circle : Figura, IGetArea, IСircleLength
    {
        public override string Name => "Круг";

        internal double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius > 0.0)
                Radius = radius;
            else new UnknownFigura();
        }

        public double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2.0);
            return Area;
        }

        public double GetСircleLength()
        {
            return 2.0 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
