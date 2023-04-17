namespace HomeWork_2.Models.Base
{
    public class UnknownAnimal : Animal
    {
        public UnknownAnimal(int id) : base(id, "Неизвестное животное", 0, 0, "Неизвестное животное") { }

        public override string ToString()
        {
            return $"{Id}. Неизвестное животное\n";
        }
    }
}
