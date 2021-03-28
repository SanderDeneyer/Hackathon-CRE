using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hackaton.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First name can't be empty")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name can't be empty")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public List<RiskStatus> RiskStatus { get; set; }
        
    }
}
