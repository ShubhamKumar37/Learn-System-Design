using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Pizza : Order
    {
        public Pizza()
        {
            Desc = "Pizza";
        }
        
        public override double Cost()
        {
            return 200.00;
        }
    }
}
