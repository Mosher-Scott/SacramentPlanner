using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_Planner.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // We can use this to check if the user is M or F to add "Brother" or "Sister" in front of the name
        public bool IsMale { get; set; }
        public string Calling { get; set; }

        // Hold all the speaking assignments since a member could speak in more than 1 sacrament meeting
        public ICollection<Meetings> SpeakingAssignments { get; set; }
    }
}
