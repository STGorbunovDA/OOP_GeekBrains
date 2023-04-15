using HomeWork_1.BaseProduct;

namespace HomeWork_1.HeirsProduct
{
    internal class DrinksProducts : Product
    {
        protected double Volume { get; private set; }

        public DrinksProducts(string name, decimal price, int quantity, string unitOfMeasure, double volume) 
            : base(name, price, quantity, unitOfMeasure)
        {
            Volume = volume;
        } 

    }
}
