using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Domain
{
    public interface ICoffeeVendorService
    {

      
      
        /// <summary>
        /// Adds an item to the internally tracked order. 
        /// </summary>
        /// <param name="orderItem"></param>
        /// <exception cref="ArgumentOutOfRangeException">Number of creamers or sugars is out of bounds.</exception>
        void AddToOrder(CoffeeOrderItem orderItem);
        /// <summary>
        /// Adds currency to the store. Must be an increment of $0.05 with a max of $20.
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException">Credit increment invalid or out of bounds.</exception>
        void AddCredits(decimal amount);
        /// <summary>
        /// Verifies necessary funds, transacts and clears the order. Follow up with <see cref="DispenseCredits"/>
        /// </summary>
        /// <param name="order"></param>
        /// <exception cref="Exception">Insufficient funds are available.</exception>
        void TransactOrder();
        /// <summary>
        /// Exposes current order
        /// </summary>
        /// <returns></returns>
        Order ViewOrder();
        /// <summary>
        /// Dispenses credits back to the user (clears store)
        /// </summary>
        /// <returns></returns>
        decimal DispenseCredits();

        /// <summary>
        /// Exposes the amount of cash in credit.
        /// </summary>
        /// <returns></returns>
        decimal GetCredits();
        /// <summary>
        /// Returns the total cost of the current order.
        /// </summary>
        /// <returns></returns>
        decimal TotalOrder();

    }
}
