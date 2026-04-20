using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Paneer : Topping
    {
        public Paneer(IOrder Order): base(Order){}

        public override string Description()
        {
            return _order.Description() + ", Paneer";
        }

        public override double Cost()
        {
            return 30 + _order.Cost();
        }
    }
}
