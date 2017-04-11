using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Model
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Valid email only")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Provide Phone")]
        public string Phone { get; set; }

        [Required (ErrorMessage ="Tell yes or no")]
        public bool? WillAttend { get; set; }

    }
}
