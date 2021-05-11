using Excellence.Core.Domain;

namespace Excellence.Data.XnesApi
{
    public class XnesData
    {
        public BankInfo[] Banks { get; set; } = new BankInfo[0];
        public BankBranchesInfo[] BankBranches { get; set; } = new BankBranchesInfo[0];

    }
}