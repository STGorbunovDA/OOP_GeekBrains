using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Truck : Transport
    {
        public Truck(string model, string color) : base(model, color, 4, 5100, 60)
        {

        }
        public override string Drive()
        {
            return $"Едет модель {Model}";
        }
    }
}
