using System;
using System.Linq;
using System.Text;

namespace CoffeeMachine.Domain
{
    public class CoffeeVendorService : ICoffeeVendorService
    {
        private readonly int _maxCreamerCount, _maxSugarCount;
        private decimal _creditStore;
        private Order _transation = new Order();
        public CoffeeVendorService(int maxCreamerCount = 3, int maxSugarCount = 3) 
        {
            _maxCreamerCount = maxCreamerCount;
            _maxSugarCount = maxSugarCount;
        }
        public void AddCredits(decimal amount)
        {
            if (amount % 0.05M != 0) throw new ArgumentException("Invalid amount increment. Must be an increment of 0.05");
            if (amount < 0.05M || amount > 20.0M) 
            {
                throw new ArgumentException("Amount provided is out of bounds (0.05-20.00)");
            }
            _creditStore += amount;
        }

        public void AddToOrder(CoffeeOrderItem orderItem)
        {
            if (orderItem.AddOns.Where(x=>x.AddOnType == CoffeeAddOnEnum.Creamer ).Count() > _maxCreamerCount 
                || orderItem.AddOns.Where(x=>x.AddOnType == CoffeeAddOnEnum.Sugar).Count() > _maxSugarCount) throw new ArgumentOutOfRangeException();
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

        public void TransactOrder()
        {
            //validate funds
            if (TotalOrder() > _creditStore) throw new Exception("Insufficient funds for the requested transaction.");
            //"transact" order  (subtract cost and clear order)
            _creditStore -= TotalOrder();
            _transation = new Order();

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
