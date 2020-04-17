using ClearBank.DeveloperTest.Data;
using Xunit;

namespace ClearBank.DeveloperTest.Tests
{
    public class DataStoreTests
    {
        [Fact]
        public void ShouldReturnBackupAccountDataStoreForBackupDataStoreType()
        {
            Assert.True(DataStore.GetAccountDataStore("Backup") is BackupAccountDataStore);
        }

        [Fact]
        public void ShouldReturnAccountDataStoreForNonBackupDataStoreType()
        {
            Assert.True(DataStore.GetAccountDataStore("NotBackup") is AccountDataStore);
        }
    }
}