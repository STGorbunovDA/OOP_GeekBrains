namespace HomeWork_1.HeirsProduct.HeirsDrinksProducts
{
    internal class Lemonade : DrinksProducts
    {
        public Lemonade(string name, decimal price, int quantity, string unitOfMeasure, double volume ) 
            : base(name, price, quantity, unitOfMeasure, volume)
        { 
        }
        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Объём {Volume}\n";
        }
    }
}
