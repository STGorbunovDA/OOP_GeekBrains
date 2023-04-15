using HomeWork_1.HeirsBase;

namespace HomeWork_1.HeirsProduct.HeirsFoodProducts
{
    internal class Bread : FoodProducts
    {
        protected string TypeOfFlour { get; private set; }
        public Bread(string name, decimal price, int quantity, string unitOfMeasure, string shelfLife, string typeOfFlour) 
            : base(name, price, quantity, unitOfMeasure, shelfLife)
        {
            TypeOfFlour = typeOfFlour;
        }
        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Тип муки: {TypeOfFlour}\n";
        }

    }
}
