using System;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Data
{
    public static class DataStore
    {
        public static Account GetAccount(string dataStoreType, MakePaymentRequest request)
        {
            return GetAccountDataStore(dataStoreType).GetAccount(request.DebtorAccountNumber);
        }

        public static IDataStore GetAccountDataStore(string dataStoreType)
        {
            if (dataStoreType == "Backup")
            {
                return new BackupAccountDataStore();
            }
            else
            {
                return new AccountDataStore();
            }
        }
    }
}