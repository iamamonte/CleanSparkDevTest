using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Domain
{
    public enum CoffeeAddOnEnum 
    {
        Creamer,
        Sugar
    }
    public abstract class CoffeeAddOn : OrderBase
    {
        public CoffeeAddOnEnum AddOnType { get; }
        public CoffeeAddOn(CoffeeAddOnEnum addOnType, double price) : base(price) 
        {
            AddOnType = addOnType;
        }
    }
}
