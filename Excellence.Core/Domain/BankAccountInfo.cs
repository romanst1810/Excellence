using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Excellence.Core.Domain
{
    public class BankAccountInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        //[RegularExpression("[א-]+")]
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
    }
}
