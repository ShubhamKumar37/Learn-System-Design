using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string desc = "Unknown";
        public virtual string Description()
        {
            return desc;
        }
        public abstract double Cost();
    }
}
