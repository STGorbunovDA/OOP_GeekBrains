namespace HomeWork_2.Models.Base
{
    internal class WildAnimal : Animal
    {
        /// <summary> Место обитания </summary>
        protected string HabitatAnimal { get; private set; }

        /// <summary> Дата нохождения </summary>
        protected string DateOfLocation { get; private set; }
        public WildAnimal(int id, string сlassAnimal, int growth, int weight, string eyesColorAnimal, 
            string habitatAnimal, string dateOfLocation)
            : base(id, сlassAnimal, growth, weight, eyesColorAnimal)
        {
            HabitatAnimal = habitatAnimal;
            DateOfLocation = dateOfLocation;
        }
    }
}
