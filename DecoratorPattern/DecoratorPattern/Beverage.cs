using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string desc = "Unknown";
        public string Size { get; set; } = "";
        public virtual string Description()
        {
            return desc;
        }
        public abstract double Cost();
        public virtual string GetSize()
        {
            return Size;
        }
        public virtual void SetSize()
        {
            Console.WriteLine("Enter Size of your drink = S/M/L");
            Size = Console.ReadLine() ?? "S";
        }
    }
}
