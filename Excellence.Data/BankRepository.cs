using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;
using Excellence.Core.Extensions;
using Excellence.Core.Repository;
using Excellence.Data.XnesApi;

namespace Excellence.Data
{
    public class BankRepository: IBankRepository
    {
        private static Lazy<XnesData> _data = new Lazy<XnesData>(FetchData);

        private static XnesData FetchData()
        {
            var client = XnesClientFactory.Create();
            var response = AsyncHelper.RunSync(async () => await client.GetGenerealInfo());

            return response.Data;
        }

        public Task<IReadOnlyCollection<BankInfo>> GetBanksAsync()
        {
            return Task.FromResult((IReadOnlyCollection<BankInfo>) _data.Value.Banks);
        }

        public Task<IReadOnlyCollection<BankBranchesInfo>> GetBranchesAsync(int bankCode)
        {
            var branches = _data.Value.BankBranches
                .Where(x => x.BankCode == bankCode)
                .ToArray();
            return Task.FromResult((IReadOnlyCollection<BankBranchesInfo>) branches);
        }
    }
}
