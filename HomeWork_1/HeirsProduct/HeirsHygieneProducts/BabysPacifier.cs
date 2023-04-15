using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1.HeirsProduct.HeirsHygieneProducts
{
    internal class BabysPacifier : HygieneProducts
    {
        public BabysPacifier(string name, decimal price, int quantity, string unitOfMeasure, int numberPiecesPackage) : base(name, price, quantity, unitOfMeasure, numberPiecesPackage)
        {
        }
        public override string ToString()
        {
            return $"Наименование товара: {Name}\n" +
                   $"Цена: {Price}\n" +
                   $"Кол-во товара: {Quantity}\n" +
                   $"Единица измерения: {UnitOfMeasure}\n" +
                   $"Кол-во штук в упаковке: {NumberPiecesPackage}\n";
        }
    }
}
