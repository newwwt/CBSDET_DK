using Xunit;
using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Tests
{
    public class PaymentOperationsTests
    {
        
        [Fact]
        public void ShouldReturnFalseWhenAccountIsNull()
        {
            Assert.False(PaymentOperations.ExecutePayment(PaymentScheme.Bacs, null, new MakePaymentRequest()));
        }
        
    }
}