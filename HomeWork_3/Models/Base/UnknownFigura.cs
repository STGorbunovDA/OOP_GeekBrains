using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.Models.Base
{
    internal class UnknownFigura : Figura
    {
        public override string Name => "Неизвестная фигура";

        public override string ToString()
        {
            return Name;
        }
    }
}
