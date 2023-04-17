using HomeWork_2.Models.Base;
using static HomeWork_2.Infrastructure.ClassAnimalEnums;

namespace HomeWork_2.Models
{
    internal class Dog : PetAnimal, ISoundAnimal, IShowingAffection, ITraining
    {
        /// <summary> Наличие дрессировки </summary>
        protected bool AvailabilityTraining { get; private set; }

        public Dog(int id, string classAnimal ,int growth, int weight, string eyesColorAnimal, string namedAnimal, 
            string breedAnimal, int availabilityVaccinationsAnimal, string colorWoolAnimal, 
            string dateBirthAnimal, bool availabilityTraining) 
            : base(id, classAnimal, growth, weight, eyesColorAnimal, namedAnimal, breedAnimal, availabilityVaccinationsAnimal, 
                  colorWoolAnimal, dateBirthAnimal)
        {
            AvailabilityTraining = availabilityTraining;
        }

        public string MakeSound()
        {
            return $"{СlassAnimal}: гав-гав";
        }

        public string ShowingAffection()
        {
            return $"{СlassAnimal} {NamedAnimal} проявляет ласку";
        }

        public string Training()
        {
            return $"{СlassAnimal} {NamedAnimal} проходит тренировку";
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
                $"Наличие дрессировки: {AvailabilityTraining}\n";
        }
    }
}
