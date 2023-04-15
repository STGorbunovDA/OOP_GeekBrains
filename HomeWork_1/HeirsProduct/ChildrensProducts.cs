using HomeWork_1.BaseProduct;

namespace HomeWork_1.HeirsProduct
{
    internal class ChildrensProducts : Product
    {
        protected int MinimumAge { get; private set; }
        protected bool Hypoallergenic { get; private set; }

        public ChildrensProducts(string name, decimal price, int quantity, string unitOfMeasure, int minimumAge, bool hypoallergenic) 
            : base(name, price, quantity, unitOfMeasure)
        {
            MinimumAge = minimumAge;
            Hypoallergenic = hypoallergenic;
        } 
    }
}
