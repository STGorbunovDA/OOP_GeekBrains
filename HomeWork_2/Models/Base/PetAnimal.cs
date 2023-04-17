namespace HomeWork_2.Models.Base
{
    internal class PetAnimal : Animal
    {
        /// <summary> Кличка </summary>
        protected string NamedAnimal  { get; private set; }

        /// <summary> Порода </summary>
        protected string BreedAnimal { get; private set; }

        /// <summary> Наличие прививок </summary>
        protected int AvailabilityVaccinationsAnimal { get; private set; }

        /// <summary> Цвет шерсти </summary>
        protected string ColorWoolAnimal { get; private set; }

        /// <summary> Дата Рождения </summary>
        protected string DateBirthAnimal { get; private set; }

        public PetAnimal(int id, string classAnimal, int growth, int weight, string eyesColorAnimal, string namedAnimal, 
            string breedAnimal, int availabilityVaccinationsAnimal, string colorWoolAnimal, 
            string dateBirthAnimal)
            : base(id, classAnimal, growth, weight, eyesColorAnimal)
        {
            NamedAnimal = namedAnimal;
            BreedAnimal = breedAnimal;
            AvailabilityVaccinationsAnimal = availabilityVaccinationsAnimal;
            ColorWoolAnimal = colorWoolAnimal;
            DateBirthAnimal = dateBirthAnimal;
            
        }
    }
}
