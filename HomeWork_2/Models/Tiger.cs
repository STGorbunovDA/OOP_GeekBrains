using HomeWork_2.Models.Base;

namespace HomeWork_2.Models
{
    internal class Tiger : WildAnimal, ISoundAnimal
    {
        public Tiger(int id, string classAnimal,int growth, int weight, string eyesColorAnimal, string habitatAnimal, string dateOfLocation) 
            : base(id, classAnimal,growth, weight, eyesColorAnimal, habitatAnimal, dateOfLocation)
        {
        }

        public string MakeSound()
        {
            return $"{СlassAnimal}: э-о-ун";
        }

        public override string ToString()
        {
            return $"{Id}. Класс животного: {СlassAnimal}\n" +
                $"Рост: {Growth} метра\n" +
                $"Вес: {Weight} кг.\n" +
                $"Цвет глаз: {EyesColorAnimal}\n" +
                $"Место обитания: {HabitatAnimal}\n" +
                $"Дата нахождения: {DateOfLocation}\n";
        }
    }
}
