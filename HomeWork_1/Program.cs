using HomeWork_1.BaseProduct;
using HomeWork_1.HeirsProduct.HeirsDrinksProducts;
using HomeWork_1.HeirsProduct.HeirsFoodProducts;
using HomeWork_1.HeirsProduct.HeirsHygieneProducts;

namespace HomeWork_1
{
    internal class Program
    {
        static void Main()
        {
            Product[] products = {
                new Milk("Молоко", 112.50m, 1, "литры", "15.04.2023", 3.2),
                new Lemonade("Лимонад", 44.20m, 1, "литры", 0.5),
                new Bread("Хлеб", 34.30m, 1,"штука","15.04.2023", "Ржаная"),
                new Eggs("Яйца",105.0m, 1, "упаковка", "15.04.2023", 10),
                new Masks("Маски",100.0m, 1, "упаковка", 100),
                new ToiletPaper("Туалетная бумага", 55.0m, 1, "упаковка", 4, 2 ),
                new Diapers("Подгузники", 120.0m, 1, "упаковка", 10, 1, 5, 12, "для детей"),
                new BabysPacifier("Соска", 10.0m,1, "упаковка", 2)
            };
            PrintProducts(products);
            Console.ReadLine();
        }

        private static void PrintProducts(Product[] products)
        {
            foreach (var item in products)
                Console.WriteLine(item);
        }
    }
}
