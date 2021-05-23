using Excellence.Core.Domain;
using System.Collections.Generic;

namespace ViewBag
{
    internal class BankAccountViewModel
    {
        public List<CitiesInfo> Cities { get; set; } = new List<CitiesInfo>();
        public List<BankInfo> Banks { get; set; } = new List<BankInfo>();
        public List<BankBranchesInfo> Branches { get; set; } = new List<BankBranchesInfo>();
    }
}