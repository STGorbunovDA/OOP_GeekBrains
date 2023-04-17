namespace HomeWork_2.Models.Base
{
    internal class BirdAnimal : Animal
    {
        /// <summary> Высота полёта </summary>
        protected int FlyingHeight { get; private set; }
        public BirdAnimal(int id, string сlassAnimal, int growth, int weight, string eyesColorAnimal, int flyingHeight)
            : base(id, сlassAnimal, growth, weight, eyesColorAnimal)
        {
            FlyingHeight = flyingHeight;
        }
    }
}
