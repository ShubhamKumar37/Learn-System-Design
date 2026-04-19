using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Soya : CondimentDecorator
    {
        Beverage beverage;

        public Soya(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description()
        {
            return beverage.Description() + ", Soya";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }

    }
}
