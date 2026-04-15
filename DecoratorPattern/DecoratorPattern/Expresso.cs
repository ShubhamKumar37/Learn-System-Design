using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            desc = "Expresso Coffe";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
