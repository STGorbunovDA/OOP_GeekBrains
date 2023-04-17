namespace HomeWork_2.Models.@Base
{
    public abstract class Animal
    {
        /// <summary> Id животного </summary>
        internal int Id { get; private set; }

        /// <summary> Класс животного </summary>
        /// 
        protected string СlassAnimal { get; private set; }

        /// <summary> Рост </summary>
        protected int Growth { get; private set; }
        
        /// <summary> Вес </summary>
        protected int Weight { get; private set; }

        /// <summary> Цвет глаз </summary>
        protected string EyesColorAnimal { get; private set; }

        protected Animal(int id, string сlassAnimal, int growth, int weight, string eyesColorAnimal)
        {
            Id = id;
            Growth = growth;
            Weight = weight;
            EyesColorAnimal = eyesColorAnimal;
            СlassAnimal = сlassAnimal;
        }

        public override string ToString()
        {
            return "Такого животного нет";
        }

    }
}
