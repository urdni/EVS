using EVH.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVH.Models
{
            public class HealthRecords
        {
            public int Id { get; set; }

            [Required]
            public string FirstName { get; set; }

          [Required]
          public string LastName { get; set; }

            [Required]
            [EmailValidate(Allowed = new string[] { "@" }, ErrorMessage = "You Email are invalid")]
            public string Email { get; set; }

            [Range(9, 11)]
            public  int PhoneNumber { get; set; }

            [Required]
            public string Status { get; set; }

            public DateTime AddedOn { get; set; }
        }
    
}
