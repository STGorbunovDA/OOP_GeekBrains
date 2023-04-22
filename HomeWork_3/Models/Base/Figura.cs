namespace HomeWork_3.Models.Base
{
    internal abstract class Figura : IComparable
    {
        public abstract string Name { get; }

        protected double Area { get; set; }

        public int CompareTo(object obj)
        {
            Figura p = obj as Figura;

            if (p != null)
            {
                if (Area < p.Area)
                    return -1;
                else if (Area > p.Area)
                    return 1;
                else return 0;
            }
            else throw new Exception("TEST");
        }
    }
}
