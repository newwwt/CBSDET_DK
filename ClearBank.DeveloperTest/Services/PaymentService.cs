using ClearBank.DeveloperTest.Data;
using ClearBank.DeveloperTest.Types;
using System.Configuration;

namespace ClearBank.DeveloperTest.Services
{
    public class PaymentService : IPaymentService
    {
        public MakePaymentResult MakePayment(MakePaymentRequest request)
        {
            var dataStoreType = ConfigurationManager.AppSettings["DataStoreType"];
            var account = DataStore.GetAccount(dataStoreType, request);

            var result = new MakePaymentResult();
            result.Success = PaymentOperations.ExecutePayment(request.PaymentScheme, account, request);
            if (result.Success) AccountOperations.DeductBalanceAndUpdateAccount(dataStoreType, account, request);

            return result;
        }
    }
}
