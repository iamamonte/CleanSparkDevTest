using System.Collections.Generic;

namespace CoffeeMachine.Domain
{
    public class CoffeeOrderItem
    {
        public Coffee Coffee { get; set; }
        public List<CoffeeAddOn> AddOns { get; set; } = new List<CoffeeAddOn>();

    }

    public class Order
    {
        public List<CoffeeOrderItem> OrderItems { get; set; } = new List<CoffeeOrderItem>();
    }
}
