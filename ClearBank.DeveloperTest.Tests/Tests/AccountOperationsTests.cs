using ClearBank.DeveloperTest.Types;
using Xunit;

namespace ClearBank.DeveloperTest.Tests
{
    public class AccountOperationsTests
    {
        [Fact]
        public void ShouldUpdateBalanceForValidTransaction()
        {
            var account = new Account();
            account.Balance = 100;
            MakePaymentRequest request = new MakePaymentRequest();
            request.Amount = 50;
            request.DebtorAccountNumber = "12345679";
            AccountOperations.DeductBalanceAndUpdateAccount("dataStore", account, request);
            Assert.Equal(account.Balance, 50);
        }
    }
}