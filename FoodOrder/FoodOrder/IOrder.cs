using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder
{
    public interface IOrder
    {
        double Cost();
        string Description(); 
    }
}
