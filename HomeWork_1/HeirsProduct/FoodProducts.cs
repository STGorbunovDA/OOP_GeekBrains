using HomeWork_1.BaseProduct;

namespace HomeWork_1.HeirsBase
{
    internal class FoodProducts : Product
    {
        protected string ShelfLife { get; private set; }
        public FoodProducts(string name, decimal price, int quantity, string unitOfMeasure, string shelfLife)
            : base(name, price, quantity, unitOfMeasure)
        {
            ShelfLife = shelfLife;
        }





        public override string ToString()
        {
            return $"----------Продукты----------";
        }
    }
}
