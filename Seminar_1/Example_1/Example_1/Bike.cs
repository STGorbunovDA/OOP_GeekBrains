using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Bike : Transport
    {
        public Bike(string model, string color) : base(model, color, 2, 1100, 80)
        {

        }
        public override string Drive()
        {
            return $"Едет модель {Model}";
        }
    }
}
