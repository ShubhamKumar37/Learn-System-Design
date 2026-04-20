using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Topping : IOrder
    {
        protected IOrder _order { get; set; }

        public Topping(IOrder _order)
        {
            this._order = _order;
        }

        public virtual string Description()
        {
            return _order.Description();
        }

        public virtual double Cost()
        {
            return _order.Cost();
        }
    }
}
