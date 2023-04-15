namespace HomeWork_1.HeirsProduct.HeirsHygieneProducts
{
    internal class Diapers : HygieneProducts
    {
        protected int Size { get; private set; }
        protected int MinimumWeight { get; private set; }
        protected int MaximumWeight { get; private set; }
        protected string Type { get; private set; }

        public Diapers(string name, decimal price, int quantity, string unitOfMeasure, int numberPiecesPackage, 
            int size, int minimumWeight, int maximumWeight, string type) 
            : base(name, price, quantity, unitOfMeasure, numberPiecesPackage)
        {
            Size = size;
            MinimumWeight = minimumWeight;
            MaximumWeight = maximumWeight;
            Type = type;
        }

        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Кол-во штук в упаковке: {NumberPiecesPackage}\n" +
                   $"Размер: {Size}\n" +
                   $"Минимальный вес: {MinimumWeight}\n" +
                   $"Максимальный вес: {MaximumWeight}\n" +
                   $"Тип: {Type}\n";
        }


    }
}
