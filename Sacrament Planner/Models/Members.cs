using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_Planner.Models
{
    public class Members
    {
        public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z \-\']+$", ErrorMessage = "First name cannot include special characters or numbers.")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z \-\']+$", ErrorMessage = "Last name cannot include special characters or numbers.")]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Can use this to decide automatically whether the speaker is a youth speaker or not
        [Range(0, 110)]
        [Required]
        public int Age { get; set; }

        // We can use this to check if the user is M or F to add "Brother" or "Sister" in front of the name
        [Display(Name = "Male")]
        [Required]
        public bool IsMale { get; set; }

        [Required]
        public string Gender { get; set; }

        [RegularExpression(@"^[0-9a-zA-Z \-\']+$", ErrorMessage = "Calling cannot include special characters")]
        public string Calling { get; set; }

        // Hold all the speaking assignments since a member could speak in more than 1 sacrament meeting
        //public ICollection<Meetings> SpeakingAssignments { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string FullNameWithTitle
        {
            get
            {
                if(Gender == "Male")
                {
                    return $"Brother {FirstName} {LastName}";
                } else
                {
                    return $"Sister {FirstName} {LastName}";
                }
            }
        }

        public string FullNameWithCalling
        {
            get
            {
               return $"{Calling} {FirstName} {LastName}";
            }
        }
    }
}
