using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description()
        {
            return beverage.Description() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
