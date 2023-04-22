namespace HomeWork_3.Models
{
    internal class Square : Rectangle
    {
        public override string Name => "Квадрат";
        public Square(double width) : base(width)
        {

        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
