using HomeWork_1.HeirsBase;

namespace HomeWork_1.HeirsProduct.HeirsFoodProducts
{
    internal class Milk : FoodProducts
    {
        protected double PercentFatContent { get; private set; }

        public Milk(string name, decimal price, int quantity, string unitOfMeasure, string shelfLife, double percentFatContent) 
            : base(name, price, quantity, unitOfMeasure, shelfLife)
        {
            PercentFatContent = percentFatContent;
        }
        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Срок годности {ShelfLife}\n" +
                   $"Процент жирности {PercentFatContent}\n";
        }

    }
}
