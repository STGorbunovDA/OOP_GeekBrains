using HomeWork_2.Models.Base;

namespace HomeWork_2.Models
{
    internal class Wolf : WildAnimal, ISoundAnimal
    {
        /// <summary> Вожак стаи </summary>
        protected bool Packmaster { get; private set; }

        public Wolf(int id, string classAnimal, int growth, int weight, string eyesColorAnimal,
            string habitatAnimal, string dateOfLocation, bool packmaster)
            : base(id, classAnimal, growth, weight, eyesColorAnimal, habitatAnimal, dateOfLocation)
        {
            Packmaster = packmaster;
        }

        public string MakeSound()
        {
            return $"{СlassAnimal}: у-у-у";
        }
        public override string ToString()
        {
            return $"{Id}. Класс животного: {СlassAnimal}\n" + 
                $"Рост: {Growth} см.\n" +
                $"Вес: {Weight} кг.\n" +
                $"Цвет глаз: {EyesColorAnimal}\n" +
                $"Место обитания: {HabitatAnimal}\n" +
                $"Дата нохождения: {DateOfLocation}\n" +
                $"Вожак стаи: {Packmaster}\n";
        }
    }
}
