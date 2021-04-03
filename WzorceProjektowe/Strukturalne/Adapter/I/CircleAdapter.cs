using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Adapter.I
{
    public class CircleAdapter : ICircle
    {
        private readonly Square square;

        public CircleAdapter(Square square)
        {
            this.square = square;
        }
        public decimal Radius => (decimal)((float)Math.Sqrt(2) * (float)square.Width / 2);
    }
}
