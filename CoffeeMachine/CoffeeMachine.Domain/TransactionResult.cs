using System.Collections.Generic;

namespace CoffeeMachine.Domain
{
    public class TransactionResult
    {
        public bool Success { get; set; }
        public List<TransactionErrorBase> TransactionErrors { get; set; } = new List<TransactionErrorBase>();
    }

    public abstract class TransactionErrorBase 
    {
        public int ErrorNumber { get; private set; }
        public string FriendlyMessage { get; protected set; }
        public TransactionErrorBase(int errorNumber) 
        {
            ErrorNumber = errorNumber;
        }
    }

    public class AboveMaximumCreditAmountTransactionError : TransactionErrorBase
    {
        public AboveMaximumCreditAmountTransactionError(decimal threshold) : base(TransactionResultError.CREDIT_AMOUNT_TOO_HIGH)
        {
            FriendlyMessage = $"Provided credit amount is above maximum threshold of {threshold}";
        }
    }

    public class BelowMinimumCreditAmountTransactionError : TransactionErrorBase 
    {
        public BelowMinimumCreditAmountTransactionError(decimal threshold) : base(TransactionResultError.CREDIT_AMOUNT_TOO_LOW) 
        {
            FriendlyMessage = $"Provided credit amount is below minimum threshold of {threshold}";
        }
    }

    public class InvalidCreditDenominationTransactionError : TransactionErrorBase 
    {
        public InvalidCreditDenominationTransactionError(decimal requiredIncrement) : base(TransactionResultError.INVALID_CREDIT_DENOMINATION) 
        {
            FriendlyMessage = $"The credit provided is not in a permitted denomination. Must be an increment of {requiredIncrement}";
        }
    }

    public class InsufficientFundsTransactionError : TransactionErrorBase 
    {
        public InsufficientFundsTransactionError() : base(TransactionResultError.INSUFFICIENT_FUNDS) 
        {
            FriendlyMessage = "There are insufficient funds for the requested transaction.";
        }
    }

    public static class TransactionResultError 
    {
        public static int INSUFFICIENT_FUNDS = 1;
        public static int INVALID_CREDIT_DENOMINATION = 2;
        public static int CREDIT_AMOUNT_TOO_LOW = 3;
        public static int CREDIT_AMOUNT_TOO_HIGH = 4;
    }

}
