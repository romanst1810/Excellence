using System;
using System.Threading.Tasks;
using Excellence.Core.Domain;
using Excellence.Core.Repository;
using Excellence.Data;
using Xunit;

namespace Excellence.Tests_
{
    public class BankAccountRepositoryTest
    {
        [Fact]
        public async Task AddAccountAsyncAsync_Test()
        {
            var item = new BankAccountInfo()
            {
                AccountNumber = 123456,
                SocialId = "123456789",
                BankCode = 31,
                BranchNumber = 1,
                BirthDay = new DateTime(1972, 1, 1),
                CityCode = "CityCode",
                NameEnglish = "NameEnglish",
                NameLocal = "NameLocal"
            };

            IBankAccountRepository bankRepository = new BankAccountRepository();
            await bankRepository.CreateAsync(item);

            Assert.True(item.Id > 0);
        }

        [Fact]
        public async Task GetBranchesAsync_Test()
        {
            IBankAccountRepository bankRepository = new BankAccountRepository();
            var items = await bankRepository.FetchAsync();

            Assert.True(items.Count >= 0);
        }

    }
}
