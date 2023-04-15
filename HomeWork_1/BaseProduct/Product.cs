namespace HomeWork_1.BaseProduct
{
    internal abstract class Product
    {
        protected string Name { get; private set; }

        protected decimal Price { get; private set; }

        protected int Quantity { get; private set; }

        protected string UnitOfMeasure { get; }

        protected Product(string name, decimal price, int quantity, string unitOfMeasure)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            UnitOfMeasure = unitOfMeasure;
        }
    }
}
