using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Bicycle : Transport
    {
        public Bicycle(string model, string color) : base(model, color, 2, 15, 35)
        {

        }
        public override string Drive()
        {
            return $"Едет модель {Model}";
        }
    }
}
