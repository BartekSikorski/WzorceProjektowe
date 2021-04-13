using System;

namespace WzorceProjektowe.Creational.Prototype
{
    public class IdInfo : ICloneable
    {
        public IdInfo()
        {
            IdNumber = Guid.NewGuid();
        }

        public Guid IdNumber { get; internal set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}