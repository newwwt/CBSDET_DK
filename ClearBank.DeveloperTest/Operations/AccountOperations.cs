using System;
using ClearBank.DeveloperTest.Data;

namespace ClearBank.DeveloperTest.Types
{
    public static class AccountOperations
    {
        public static void DeductBalanceAndUpdateAccount(String dataStoreType, Account account, MakePaymentRequest request)
        {
            account.Balance -= request.Amount;

            if (dataStoreType == "Backup")
            {
                var accountDataStore = new BackupAccountDataStore();
                accountDataStore.UpdateAccount(account);
            }
            else
            {
                var accountDataStore = new AccountDataStore();
                accountDataStore.UpdateAccount(account);
            }
        }
    }
}