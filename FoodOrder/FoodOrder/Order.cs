using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public class Order : IOrder
    {
        public string Desc { get; set; } = "Unknown";
        public virtual string Description()
        {
            return Desc;
        }

        public virtual double Cost()
        {
            return 100.00;
        }
        
    }
}
