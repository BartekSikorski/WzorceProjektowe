using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Creational.Builder
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
