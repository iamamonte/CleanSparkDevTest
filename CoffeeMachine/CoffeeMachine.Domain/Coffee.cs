using System;

namespace CoffeeMachine.Domain
{
    public enum CoffeeSize 
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// Base class for any items comprising an Order. Ensures a fixed price on each item.
    /// </summary>
    public abstract class OrderBase
    {
        private readonly double _price;
        public virtual double Price { get { return _price; } }
        public OrderBase(double price)
        {
            _price = price;
        }

    }


    public class Coffee : OrderBase
    {
        private readonly double _sizeUpCharge = 0;
        private readonly CoffeeSize _size;
        public CoffeeSize Size { get { return _size; } }
        public override double Price { get { return base.Price + _sizeUpCharge; } }
        public Coffee(CoffeeSize size) : base(1.75)
        {
            _size = size;
            switch (Size) 
            {
                case CoffeeSize.Large:
                    _sizeUpCharge = 0.5;
                    break; 
                case CoffeeSize.Medium:
                    _sizeUpCharge = 0.25;
                    break;
                case CoffeeSize.Small:
                    break;
                default:
                    throw new ArgumentException("Unexpected coffee size.");
            }
        }
    }

    public class Creamer : CoffeeAddOn 
    {
        public Creamer() : base( CoffeeAddOnEnum.Creamer,0.5) { }
    }

    public class Sugar : CoffeeAddOn 
    {
        public Sugar() : base(CoffeeAddOnEnum.Sugar, 0.25){ }
    }

   


}
