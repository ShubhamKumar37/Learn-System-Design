using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Cheese : Topping
    {
        public Cheese(IOrder Order) : base(Order) {}

        public override string Description()
        {
            return _order.Description() + ", Cheese";
        }
        public override double Cost()
        {
            return 10 + _order.Cost();
        }
    }
}
