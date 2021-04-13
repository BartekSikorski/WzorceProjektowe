using System;
using System.Collections.Generic;

namespace WzorceProjektowe.Creational.Prototype
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Addresses { get; internal set; }
        internal IdInfo IdInfo { get; set; }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Addresses = new List<string>(Addresses);
            clone.IdInfo = (IdInfo)IdInfo.Clone();
            return clone;
        }
    }
}