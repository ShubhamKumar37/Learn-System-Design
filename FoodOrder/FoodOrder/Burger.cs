using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Burger : Order
    {
        public Burger()
        {
            Desc = "Burger";
        }

        public override string Description()
        {
            return Desc;
        }

        public override double Cost()
        {
            return 50;
        }
    }
}
