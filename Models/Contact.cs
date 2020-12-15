using System;
using System.ComponentModel.DataAnnotations;


namespace EvolentDemo.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public bool Status { get; set; }
    }
}
