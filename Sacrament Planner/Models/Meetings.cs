using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sacrament_Planner.Models
{
    public class Meetings
    {
        //TODO: Add Topics to specific speakers
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        public string Presiding { get; set; }
        public string Conducting { get; set; }

        // In our logic, if IntermediateSong == 0, then there is none
        [Display(Name = "Intermediate Song")]
        public int IntermediateSong { get; set; }

        // If this is null, then there is no intermediate musical number
        [Display(Name = "Intermediate Musical Number")]
        public string IntermediateMusicalNumber { get; set; }

        // Going to have multiple speakers, so we'll need to add them to a list
        public List <Members> Speakers { get; set; }

        public string Speaker1 { get; set; }

        public string Speaker2 { get; set; }

        public string Speaker3 { get; set; }

        public string Speaker4 { get; set; }

        public string Speaker5 { get; set; }

        public string Speaker6 { get; set; }

        public string Speaker7 { get; set; }


        // Going to have multiple hymns as well
        //public List <Hymns> Hymns { get; set; }

        public string OpeningHymn { get; set; }

        public string SacramentHymn { get; set; }

        public string ClosingHymn { get; set; }

        // Will need multiple people for prayers
        //public List <Members> Prayers { get; set; }

        public string OpeningPrayer { get; set; }

        public string ClosingPrayer { get; set; }

    }
}
