using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Program
    {
        static void Main()
        {
            Transport[] transports = {
                new Car("Audi","Red"),
                new Bike("Kawasaki ", "Black"),
                new Truck("Белаз", "Жёлтый"),
                new Bicycle("Взрослик", "Батин")
            };
            
            GetTransport(transports);
            Console.ReadLine();
        }

        private static void GetTransport(Transport[] transports)
        {
            foreach (Transport transport in transports)
            {
                Console.WriteLine(transport);
                Console.WriteLine(transport.Drive());
                Console.WriteLine();
            }
        }
    }
}
