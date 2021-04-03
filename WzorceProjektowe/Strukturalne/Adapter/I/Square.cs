using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Adapter.I
{
    public class Square
    {
        public Square(decimal width)
        {
            Width = width;
        }

        public decimal Width { get; }
    }
}
