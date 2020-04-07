using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_Planner.Models
{
    public class Hymns
    {
        public int ID { get; set; }

        [Display(Name = "Hymn Name")]
        [RegularExpression(@"^[0-9a-zA-Z \-\'!?]+$", ErrorMessage = "Hymn Name cannot include special characters")]
        [Required]
        public string HymnName { get; set; }

        [Display(Name = "Page Number")]
        [Range(0, 341)]
        [Required]
        public int PageNumber { get; set; }

        // A hymn can be in multiple sacrament meetings
        //public ICollection<Meetings> Meeting { get; set; }
    }
}
