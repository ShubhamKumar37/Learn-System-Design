using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description()
        {
            return beverage.Description() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }
    }
}
