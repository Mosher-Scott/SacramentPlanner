using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        // In the future, if we want to save the IDs and use multiple tables
        //public int PresidingId { get; set; }

        public string Conducting { get; set; }

        // In our logic, if IntermediateSong == 0, then there is none
        [Display(Name = "Intermediate Song")]
        public string IntermediateSong { get; set; }

        // If this is null, then there is no intermediate musical number
        [Display(Name = "Intermediate Musical Number")]
        public string IntermediateMusicalNumber { get; set; }

        // Going to have multiple speakers, so we'll need to add them to a list
        //public List <Members> Speakers { get; set; }

        [Display(Name = "Speaker 1")]
        public string Speaker1 { get; set; }

        [Display(Name = "Speaker 1 Topic")]
        public string Speaker1Topic { get; set; }

        [Display(Name = "Speaker 2")]
        public string Speaker2 { get; set; }

        [Display(Name = "Speaker 2 Topic")]
        public string Speaker2Topic { get; set; }

        [Display(Name = "Speaker 3")]
        public string Speaker3 { get; set; }

        [Display(Name = "Speaker 3 Topic")]
        public string Speaker3Topic { get; set; }

        [Display(Name = "Speaker 4")]
        public string Speaker4 { get; set; }

        [Display(Name = "Speaker 4 Topic")]
        public string Speaker4Topic { get; set; }

        [Display(Name = "Speaker 5")]
        public string Speaker5 { get; set; }

        [Display(Name = "Speaker 5 Topic")]
        public string Speaker5Topic { get; set; }

        [Display(Name = "Speaker 6")]
        public string Speaker6 { get; set; }

        [Display(Name = "Speaker 6 Topic")]
        public string Speaker6Topic { get; set; }

        [Display(Name = "Speaker 7")]
        public string Speaker7 { get; set; }

        [Display(Name = "Speaker 7 Topic")]
        public string Speaker7Topic { get; set; }

        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

    }
}
