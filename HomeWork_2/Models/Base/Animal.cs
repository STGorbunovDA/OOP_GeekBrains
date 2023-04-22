namespace HomeWork_2.Models.@Base
{
    public abstract class Animal: IComparable
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

        public int CompareTo(object obj)
        {
            Animal p = obj as Animal;

            if (p != null)
            {
                if (Weight < p.Weight)
                    return -1;
                else if (Weight > p.Weight)
                    return 1;
                else return 0;
            }
            else throw new Exception("TEST");
        }
    }
}
