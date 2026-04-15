using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            desc = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
