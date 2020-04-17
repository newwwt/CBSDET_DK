using System;
using ClearBank.DeveloperTest.Data;

namespace ClearBank.DeveloperTest.Types
{
    public static class AccountOperations
    {
        public static void DeductBalanceAndUpdateAccount(String dataStoreType, Account account, MakePaymentRequest request)
        {
            account.Balance -= request.Amount;
            var accountDataStore = DataStore.GetAccountDataStore(dataStoreType);
            accountDataStore.UpdateAccount(account);
        }
    }
}