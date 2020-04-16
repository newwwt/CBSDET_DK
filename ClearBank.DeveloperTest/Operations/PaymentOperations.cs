namespace ClearBank.DeveloperTest.Types
{
    public static class PaymentOperations
    {
        public static bool ExecutePayment(PaymentScheme scheme, Account account, MakePaymentRequest request)
        {
            switch (scheme)
            {
                case PaymentScheme.Bacs:
                    if (account == null)
                    {
                        return false;
                    }
                    else if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Bacs))
                    {
                        return false;
                    }
                    break;

                case PaymentScheme.FasterPayments:
                    if (account == null)
                    {
                        return false;
                    }
                    else if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.FasterPayments))
                    {
                        return false;
                    }
                    else if (account.Balance < request.Amount)
                    {
                        return false;
                    }
                    break;

                case PaymentScheme.Chaps:
                    if (account == null)
                    {
                        return false;
                    }
                    else if (!account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Chaps))
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

            return false;
        }
    }
}