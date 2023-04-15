using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Example_1
{
    internal abstract class Transport
    {
        protected string Model { get; private set; }

        protected string Color { get; private set; }

        private int WheelsCount { get;  }

        private int Weight { get; }

        private int Speed { get;  }

        public Transport(string model, string color, int wheelsCount, int weight, int speed)
        {
            Model = model;
            Color = color;
            WheelsCount = wheelsCount;
            Weight = weight;
            Speed = speed;
        }

        public abstract string Drive();

        public override string ToString()
        {
            return $"Модель: {Model}\nЦвет: {Color}\nКол-во колёс: {WheelsCount}\nВес: {Weight}\nСкорость: {Speed}";
        }

    }
}
