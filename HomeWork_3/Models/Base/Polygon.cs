using HomeWork_3.Infrastructure;

namespace HomeWork_3.Models.Base
{
    internal abstract class Polygon : Figura, IGetPerimeter
    {
        protected int NSides { get;private set; }
        internal double[] LSides { get; set; }

        protected Polygon(int nSides, double[] lSides)
        {
            NSides = nSides;
            LSides = lSides;
        }

        public double GetPerimeter()
        {
            double res = 0.0;
            foreach (double side in LSides)
                res += side;
            return res;
        }
    }
}
