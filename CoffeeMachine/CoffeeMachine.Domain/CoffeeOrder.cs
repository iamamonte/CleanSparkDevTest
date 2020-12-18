using System.Collections.Generic;

namespace CoffeeMachine.Domain
{
    public class CoffeeOrderItem
    {
        public Coffee Coffee { get; set; }
        public List<Creamer> Creamers { get; set; } = new List<Creamer>();
        public List<Sugar> Sugars { get; set; } = new List<Sugar>();

    }

    public class Order
    {
        public List<CoffeeOrderItem> OrderItems { get; set; } = new List<CoffeeOrderItem>();
    }
}
