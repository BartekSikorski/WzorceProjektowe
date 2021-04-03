using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Adapter.I
{
    public class Circle : ICircle
    {
        public Circle(decimal radius)
        {
            Radius = radius;
        }   

        public decimal Radius { get; }
    }
}
