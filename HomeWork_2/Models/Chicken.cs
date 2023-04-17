using HomeWork_2.Models.Base;

namespace HomeWork_2.Models
{
    internal class Chicken : BirdAnimal, IFlying, ISoundAnimal
    {
        public Chicken(int id, string classAnimal, int growth, int weight, string eyesColorAnimal, int flyingHeight)
            : base(id, classAnimal, growth, weight, eyesColorAnimal, flyingHeight)
        {
        }

        public string Flying()
        {
            return $"{СlassAnimal} летит на {FlyingHeight} метрах";
        }

        public string MakeSound()
        {
            return $"{СlassAnimal}: кхо-кхо";
        }

        public override string ToString()
        {
            return $"{Id}. Класс животного: {СlassAnimal}\n" +
                $"Рост: {Growth} см.\n" +
                $"Вес: {Weight} кг.\n" +
                $"Цвет глаз: {EyesColorAnimal}\n" +
                $"Максимальная высота полёта: {FlyingHeight}\n";
        }
    }
}
