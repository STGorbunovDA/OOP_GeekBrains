namespace HomeWork_1.HeirsProduct.HeirsHygieneProducts
{
    internal class ToiletPaper : HygieneProducts
    {
        protected int NumberOfLayers { get; private set; }
        public ToiletPaper(string name, decimal price, int quantity, string unitOfMeasure, int numberPiecesPackage, int numberOfLayers) 
            : base(name, price, quantity, unitOfMeasure, numberPiecesPackage)
        {
            NumberOfLayers = numberOfLayers;
        }
        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Кол-во штук в упаковке: {NumberPiecesPackage}\n" +
                   $"Кол-во слоёв: {NumberOfLayers}\n";
        }

    }
}
