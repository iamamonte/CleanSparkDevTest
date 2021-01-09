using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Domain
{
    public class CoffeeAddOnValidationError : IValidationError
    {
        public string Message { get; set; }
    }
    public interface IValidationError 
    {
        string Message { get; set; }

    }
    public interface ICoffeeValidationStrategy
    {
        /// <summary>
        /// If any validation errors occur, the order is marked as invalid. Check the type of returned <see cref="IValidationError"/> for the scope of the validation error.
        /// </summary>
        /// <param name="orderItem"></param>
        /// <returns>Validation errors</returns>
       List<IValidationError> ValidateOrder(CoffeeOrderItem orderItem);
    }

    public class CoffeeAddOnValidationStrategy : ICoffeeValidationStrategy
    {
        private Dictionary<CoffeeAddOnEnum, int> maxAddOnMap = new Dictionary<CoffeeAddOnEnum, int>();

        public CoffeeAddOnValidationStrategy() 
        {
            maxAddOnMap.Add(CoffeeAddOnEnum.Creamer, 3);
            maxAddOnMap.Add(CoffeeAddOnEnum.Sugar, 3);
        }

        public List<IValidationError> ValidateOrder(CoffeeOrderItem orderItem)
        {
            List<IValidationError> retval = new List<IValidationError>();
            foreach (var addOnGroup in orderItem.AddOns.GroupBy(x => x.AddOnType).Select(x => new {
                @AddOnType = x.Key,@Count = x.Count()
            })) 
            {
                if (maxAddOnMap.ContainsKey(addOnGroup.AddOnType)) 
                {
                    var max = maxAddOnMap[addOnGroup.AddOnType];
                    if (addOnGroup.Count > max) 
                    {
                        retval.Add(new CoffeeAddOnValidationError { Message = $"{Enum.GetName(typeof(CoffeeAddOnEnum), addOnGroup.AddOnType)} count exceeds maximum allowed threshold of {max}." });
                    }
                }
            }
            if (retval.Any()) orderItem.IsValid = false;
            return retval;
            
        }
    }
}
