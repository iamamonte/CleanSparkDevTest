using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeMachine.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachine.Test
{
    [TestClass]
    public class CoffeeVenderServiceTests
    {
        [TestMethod]
        public void COFFEESERVICE_Can_add_credits()
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            decimal addedCredits = 15.25M;
            service.AddCredits(addedCredits);
            decimal dispensedChange = service.DispenseCredits();
            Assert.AreEqual(dispensedChange, addedCredits);
            decimal emptiedCredits = service.DispenseCredits();
            Assert.AreEqual(0, emptiedCredits);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void COFFEESERVICE_Does_reject_invalid_credit_minimum() 
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            service.AddCredits(0.01M);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void COFFEESERVICE_Does_reject_invalid_credit_increment()
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            service.AddCredits(5.01M);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void COFFEESERVICE_Does_reject_invalid_credit_maximum()
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            service.AddCredits(20.01M);
        }

        [TestMethod]
        public void COFFEESERVICE_Can_add_order_item() 
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            Order currentOrder = null;
            var orderItem = new CoffeeOrderItem
            {
                AddOns = new List<CoffeeAddOn> { new Creamer(), new Creamer() }
                , Coffee = new Coffee(CoffeeSize.Medium)
            };
            service.AddToOrder(orderItem);
            currentOrder = service.GetOrder();
            Assert.AreEqual(currentOrder.OrderItems.Count, 1);
            var orderItem2 = new CoffeeOrderItem
            {
                AddOns= new List<CoffeeAddOn> { new Creamer(), new Sugar(), new Sugar() }
                ,Coffee = new Coffee(CoffeeSize.Small)
            };
            service.AddToOrder(orderItem2);
            currentOrder = service.GetOrder();
            Assert.AreEqual(currentOrder.OrderItems.Count, 2);
            Assert.AreEqual(currentOrder.OrderItems.Sum(x => x.AddOns.Count(y=>y.GetType() == typeof(Creamer))), 3);
            Assert.AreEqual(currentOrder.OrderItems.Sum(x => x.AddOns.Count(y=>y.GetType() == typeof(Sugar))), 2);
            Assert.IsTrue(currentOrder.OrderItems.Where(x => x.Coffee.Size == CoffeeSize.Small).Count() == 1);
            
        }

        [TestMethod]
        public void COFFEESERVICE_Can_calculate_order_cost()
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            var orderItem1 = new CoffeeOrderItem
            {
                AddOns = new List<CoffeeAddOn> { new Creamer(), new Creamer() }
                ,
                Coffee = new Coffee(CoffeeSize.Medium)
            };

            var orderItem2 = new CoffeeOrderItem
            {
                AddOns = new List<CoffeeAddOn> { new Creamer(), new Sugar(), new Sugar() }
                ,Coffee = new Coffee(CoffeeSize.Small)
            };
            service.AddToOrder(orderItem1);
            service.AddToOrder(orderItem2);
            Order transation = new Order { OrderItems = new List<CoffeeOrderItem> { orderItem1, orderItem2 } };
            var orderCost = transation.OrderItems.Sum(orderItem => orderItem.Coffee.Price + orderItem.AddOns.Sum(y=>y.Price));
            Assert.AreEqual((decimal)orderCost, service.TotalOrder());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void COFFEESERVICE_Does_reject_invalid_order_items() 
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            var invalidOrderItem = new CoffeeOrderItem
            {
                AddOns = new List<CoffeeAddOn> { new Creamer(), new Creamer(), new Creamer(), new Creamer(), new Sugar(), new Sugar() }  
           
            };
            service.AddToOrder(invalidOrderItem);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void COFFEESERVICE_Does_reject_insufficient_fund_transaction() 
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            service.AddCredits(6.75M);
            service.AddToOrder(new CoffeeOrderItem { Coffee = new Coffee(CoffeeSize.Large) });
            service.AddToOrder(new CoffeeOrderItem { Coffee = new Coffee(CoffeeSize.Large) });
            service.AddToOrder(new CoffeeOrderItem { Coffee = new Coffee(CoffeeSize.Large) });
            service.AddToOrder(new CoffeeOrderItem { Coffee = new Coffee(CoffeeSize.Large) });
            service.TransactOrder();
        }
        [TestMethod]
        public void COFFEESERVICE_Can_transact_order() 
        {
            ICoffeeVendorService service = new CoffeeVendorService();
            service.AddCredits(10.75M);
            service.AddToOrder(new CoffeeOrderItem { Coffee = new Coffee(CoffeeSize.Medium) });
            service.AddToOrder(new CoffeeOrderItem
            {
                Coffee = new Coffee(CoffeeSize.Medium)
                , AddOns = new List<CoffeeAddOn> { new Creamer(), new Sugar() }
            });
            Assert.AreEqual(4.75M, service.TotalOrder());
            service.TransactOrder();
            decimal change = service.DispenseCredits();
            Assert.AreEqual(change, 6);
        }
    }
}
