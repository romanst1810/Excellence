using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Excellence.Core.Domain;
using Excellence.Core.Repository;
using Excellence.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Excellence.Data
{
    public class BankAccountRepository: IBankAccountRepository
    {
        public BankAccountRepository()
        {
            try
            {
                var context = new BankAccountContext();
                context.Database.Migrate(); // apply all migrations
            }
            catch (Exception ex)
            {
            }
        }

        public async Task CreateAsync(BankAccountInfo item)
        {
            item = item ?? throw new ArgumentNullException(nameof(item));

            using (var context = CreateContext())
            {
                context.BankAccounts.Add(item);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IReadOnlyCollection<BankAccountInfo>> FetchAsync()
        {
            using (var context = CreateContext())
            {
                return await context.BankAccounts.ToArrayAsync();
            }
        }


        private static BankAccountContext CreateContext()
        {
            return new BankAccountContext();
        }
    }
}
