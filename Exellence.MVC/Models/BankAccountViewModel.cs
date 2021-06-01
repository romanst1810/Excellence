using Excellence.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Exellence.MVC.Models
{
    public class BankAccountViewModel
    {
        [Required]
        [StringLength(20)]
        [RegularExpression("[א-ת]+")]
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
        public string BankCode { get; set; }

        [Required]
        public string BranchNumber { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("[0-9]{1,10}")]
        public string AccountNumber { get; set; }

        public List<SelectListItem> Cities { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Banks { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> BankBranches { get; } = new List<SelectListItem>();
    }
}
