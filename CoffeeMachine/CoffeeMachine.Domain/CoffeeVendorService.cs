using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine.Domain
{
    public class CoffeeVendorService : ICoffeeVendorService
    {
        private decimal _creditStore;
        private decimal _minimumCreditAmount = 0.05M;
        private decimal _maximumCreditAmount = 20.0M;
        private decimal _creditIncrement = 0.05M;
        private Order _transation = new Order();
        public CoffeeVendorService() 
        {
           
        }
        public TransactionResult AddCredits(decimal amount)
        {
            TransactionResult retval = new TransactionResult { };
            if (amount % _creditIncrement != 0) retval.TransactionErrors.Add(new InvalidCreditDenominationTransactionError(_creditIncrement));

            if (amount < _minimumCreditAmount) retval.TransactionErrors.Add(new BelowMinimumCreditAmountTransactionError(_minimumCreditAmount));

            if (amount > _maximumCreditAmount) retval.TransactionErrors.Add(new AboveMaximumCreditAmountTransactionError(_maximumCreditAmount));

            if (retval.TransactionErrors.Any()) return retval;
            _creditStore += amount;
            retval.Success = true;
            return retval;
        }

        public void AddToOrder(CoffeeOrderItem orderItem)
        {
            _transation.OrderItems.Add(orderItem);
        }

       
        public decimal DispenseCredits()
        {
            var change = _creditStore;
            _creditStore = 0;
            return change;
        }

        public decimal GetCredits()
        {
            return _creditStore;
        }

        public decimal TotalOrder()
        {
            return (decimal)_transation.OrderItems.Sum(orderItem => orderItem.Coffee.Price + orderItem.AddOns.Sum(y => y.Price));
        }

        public TransactionResult TransactOrder()
        {
            //validate funds
            if (TotalOrder() > _creditStore) return new TransactionResult { TransactionErrors = new List<TransactionErrorBase> { new InsufficientFundsTransactionError() } };

            //"transact" order  (subtract cost and clear order)
            _creditStore -= TotalOrder();
            _transation = new Order();
            return new TransactionResult { Success = true };

        }

        public Order GetOrder()
        {
            return _transation;
        }

        public string DisplayOrder()
        {
            StringBuilder orderAsString = new StringBuilder();
            foreach (var order in _transation.OrderItems) 
            {
                orderAsString.AppendLine($"1 {Enum.GetName(typeof(CoffeeSize), order.Coffee.Size)} Coffee ${order.Coffee.Price}");

                foreach (var addOn in order.AddOns.GroupBy(x => x.AddOnType)
                    .Select(x => new { @Name = Enum.GetName(typeof(CoffeeAddOnEnum), x.Key)
                    , @TotalPrice = x.Sum(y => y.Price)
                    , @Count = x.Count() })) 
                {
                    orderAsString.AppendLine($"\t-{addOn.Count} {addOn.Name} ${addOn.TotalPrice}");
                } 
                
            }

            return orderAsString.ToString();
        }
    }
}
