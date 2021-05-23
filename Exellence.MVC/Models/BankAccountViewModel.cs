using Excellence.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exellence.MVC.Models
{
    public class BankAccountViewModel
    {
        [Required]
        [StringLength(20)]
        [RegularExpression("[\u0590-\u05FF\uFB1D-\uFB4F]")]
        public string NameLocal { get; set; }

        [Required]
        [StringLength(15)]
        [RegularExpression("[a-zA-Z]+")]
        public string NameEnglish { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        [StringLength(9)]
        [RegularExpression("[0-9]{9,9}")]
        public string SocialId { get; set; }

        [Required]
        [StringLength(20)]
        public string CityCode { get; set; }

        [Required]
        public int BankCode { get; set; }

        [Required]
        public int BranchNumber { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("[0-9]{1,10}")]
        public int AccountNumber { get; set; }

        public List<CitiesInfo> Cities { get; set; } = new List<CitiesInfo>();
        public List<BankInfo> Banks { get; set; } = new List<BankInfo>();
        public List<BankBranchesInfo> Branches { get; set; } = new List<BankBranchesInfo>();
    }
}
