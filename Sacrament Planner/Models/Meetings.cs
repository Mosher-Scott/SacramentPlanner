using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sacrament_Planner.Models
{
    public class Meetings
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{):yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeetingDate { get; set; }

        public string Presiding { get; set; }
        public string Conducting { get; set; }

        // In our logic, if IntermediateSong == 0, then there is none
        public int IntermediateSong { get; set; }

        // If this is null, then there is no intermediate musical number
        public string IntermediateMusicalNumber { get; set; }

        // Going to have multiple speakers, so we'll need to add them to a list
        public List <Members> Speakers { get; set; }

        // Going to have multiple hymns as well
        public List <Hymns> Hymns { get; set; }

        // Will need multiple people for prayers
        public List <Members> Prayers { get; set; }

    }
}
