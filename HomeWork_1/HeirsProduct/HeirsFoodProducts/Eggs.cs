using HomeWork_1.HeirsBase;

namespace HomeWork_1.HeirsProduct.HeirsFoodProducts
{
    internal class Eggs : FoodProducts
    {
        protected int QuantityPerPackage { get; private set; }

        public Eggs(string name, decimal price, int quantity, string unitOfMeasure, string shelfLife, int quantityPerPackage) 
            : base(name, price, quantity, unitOfMeasure, shelfLife)
        {
            QuantityPerPackage = quantityPerPackage;
        }

        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Кол-во в упаковке: {QuantityPerPackage}\n";
        }
    }
}
