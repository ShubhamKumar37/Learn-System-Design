using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            SetSize();
            desc = "House Blend Coffee";
        }

        public override double Cost()
        {
            string size = GetSize();
            if(size == "S") return 0.10;
            else if(size == "M") return 0.20;
            return 0.30;
        }

        public override string GetSize()
        {
            return Size;
        }

        public override void SetSize()
        {
            Console.WriteLine("Enter Size of your drink = S/M/L");
            Size = Console.ReadLine() ?? "S";
        }
    }
}
