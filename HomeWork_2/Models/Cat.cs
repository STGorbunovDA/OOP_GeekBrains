using HomeWork_2.Models.Base;
using static HomeWork_2.Infrastructure.ClassAnimalEnums;

namespace HomeWork_2.Models
{
    internal class Cat : PetAnimal, ISoundAnimal, IShowingAffection
    {
        /// <summary> Наличие шерсти </summary>
        protected bool AvailabilityWool { get; private set; }
        public Cat(int id, string сlassAnimal, int growth, int weight, string eyesColorAnimal, string namedAnimal, 
            string breedAnimal, int availabilityVaccinationsAnimal, string colorWoolAnimal,
            string dateBirthAnimal, bool availabilityWool) : base(id, сlassAnimal, growth, weight, eyesColorAnimal, namedAnimal,
                breedAnimal, availabilityVaccinationsAnimal, colorWoolAnimal, dateBirthAnimal)
        {
            AvailabilityWool = availabilityWool;
        }


        public string MakeSound()
        {
            return $"{СlassAnimal}: мяу";
        }

        public string ShowingAffection()
        {
            return $"{СlassAnimal} {NamedAnimal} проявляет ласку";
        }

        public override string ToString()
        {
            return $"{Id}. Класс животного: {СlassAnimal}\n" +
                $"Рост: {Growth} см.\n" +
                $"Вес: {Weight} кг.\n" +
                $"Цвет глаз: {EyesColorAnimal}\n" +
                $"Кличка: {NamedAnimal}\n" +
                $"Порода: {BreedAnimal}\n" +
                $"Наличие прививок: {AvailabilityVaccinationsAnimal}\n" +
                $"Цвет шерсти: {ColorWoolAnimal}\n" +
                $"Дата Рождения: {DateBirthAnimal}\n" +
                $"Наличие шерсти: {AvailabilityWool}\n";
        }
    }
}
