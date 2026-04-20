using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Patty : Topping
    {
        public Patty(IOrder Order) : base(Order)
        {
            List<string> order = (this.Description().Split(',')).ToList();
            if (!order.Contains("Burger")) throw new ArgumentException("Order is not burger so we can't put patty in it");
        }

        public override string Description()
        {
            return _order.Description() + ", Patty";
        }

        public override double Cost()
        {
            return 10 + _order.Cost();
        }
    }
}
