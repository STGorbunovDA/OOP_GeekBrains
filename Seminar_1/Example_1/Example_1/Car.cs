using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Car : Transport
    {
        public Car(string model, string color) : base(model, color, 4, 2137, 140)
        {

        }


        public override string Drive()
        {
           return $"Едет модель {Model}";
        }
    }
}
