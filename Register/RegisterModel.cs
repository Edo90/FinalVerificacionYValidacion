using System;
using System.ComponentModel.DataAnnotations;

namespace Register
{
    public class RegisterModel
    {
        [MaxLength(25)]
        [MinLength(2)]
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [MaxLength(25)]
        [MinLength(2)]
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(40)]
        [Required]
        public string PlaceOfBirth { get; set; }
        [Required]
        public char Gender { get; set; }
        [MaxLength(1)]
        [Required]
        public int TypeOfIdentification { get; set; }
        [MaxLength(11)]
        [MinLength(5)]
        [Required]
        public string Identification { get; set; }
        [MaxLength(2)]
        [Required]
        public int CountryFrom { get; set; }
        [Required]
        public int Province { get; set; }
        [Required]
        public int Municipality { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        public int HomeNumber { get; set; }


    }
}