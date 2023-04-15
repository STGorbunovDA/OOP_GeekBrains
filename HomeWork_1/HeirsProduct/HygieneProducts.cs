using HomeWork_1.BaseProduct;

namespace HomeWork_1.HeirsProduct
{
    internal class HygieneProducts : Product
    {
        protected int NumberPiecesPackage { get; private set; }
        public HygieneProducts(string name, decimal price, int quantity, string unitOfMeasure, int numberPiecesPackage) 
            : base(name, price, quantity, unitOfMeasure)
        {
            NumberPiecesPackage = numberPiecesPackage;
        }
    }
}
