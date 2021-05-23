using System;
using System.Threading.Tasks;
using Excellence.Core.Repository;
using Excellence.Data;
using Xunit;

namespace Excellence.Tests_
{
    public class BankRepositoryTest
    {
        [Fact]
        public async Task GetBanksAsync_Test()
        {
            IBankRepository bankRepository = new BankRepository();
            var banks = await bankRepository.GetBanksAsync();
            
            Assert.True(banks.Count > 0);
        }

        [Fact]
        public async Task GetBranchesAsync_Test()
        {
            IBankRepository bankRepository = new BankRepository();
            var branches = await bankRepository.GetBranchesAsync(31);

            Assert.True(branches.Count > 0);
        }

        [Fact]
        public async Task GetCitiesAsync_Test()
        {
            IBankRepository bankRepository = new BankRepository();
            var cities = await bankRepository.GetCitiesAsync();

            Assert.True(cities.Count > 0);
        }

        [Fact]
        public async Task GetAllBranchesAsync_Test()
        {
            IBankRepository bankRepository = new BankRepository();
            var branches = await bankRepository.GetAllBranchesAsync();

            Assert.True(branches.Count > 0);
        }
    }
}
