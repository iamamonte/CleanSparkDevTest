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
        void AddToOrder(CoffeeOrderItem orderItem);
        /// <summary>
        /// Adds currency to the store. Check <see cref="TransactionResult.Success"/> and <see cref="TransactionResult.TransactionErrors"/> in return value for information on success of transaction.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns><see cref="TransactionResult"/></returns>
        TransactionResult AddCredits(decimal amount);
        /// <summary>
        /// Verifies necessary funds, transacts and clears the order. Follow up with <see cref="DispenseCredits"/>
        /// </summary>
        /// <param name="order"></param>
        /// <returns><see cref="TransactionResult"/></returns>
        TransactionResult TransactOrder();
        /// <summary>
        /// Exposes current order
        /// </summary>
        /// <returns></returns>
        Order GetOrder();
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

        /// <summary>
        /// Displays the order in a string format.
        /// </summary>
        /// <returns></returns>
        string DisplayOrder();

    }
}
