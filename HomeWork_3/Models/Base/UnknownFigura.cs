namespace HomeWork_3.Models.Base
{
    internal class UnknownFigura : Figura
    {
        public override string Name => "Неизвестная фигура";

        public override string ToString()
        {
            return Name;
        }
    }
}
