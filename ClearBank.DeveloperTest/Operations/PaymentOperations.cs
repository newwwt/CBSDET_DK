namespace ClearBank.DeveloperTest.Types
{
    public static class PaymentOperations
    {
        public static bool ExecutePayment(PaymentScheme scheme, Account account, MakePaymentRequest request)
        {
            if (account != null)
            {
                switch (scheme)
                {
                    case PaymentScheme.Bacs:
                        if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Bacs))
                        {
                            return false;
                        }
                        break;

                    case PaymentScheme.FasterPayments:
                        if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.FasterPayments) || account.Balance < request.Amount)
                        {
                            return false;
                        }
                        break;

                    case PaymentScheme.Chaps:
                        if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Chaps))
                        {
                            return false;
                        }
                        else if (account.Status != AccountStatus.Live)
                        {
                            return false;
                        }
                        break;
                    default:
                        return false;
                }
            }
            return false;
        }
    }
}