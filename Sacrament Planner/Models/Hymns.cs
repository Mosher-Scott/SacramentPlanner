﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_Planner.Models
{
    public class Hymns
    {
        public int ID { get; set; }
        public string HymnName { get; set; }

        public int PageNumber { get; set; }

        [NotMapped]
        public SelectList HymnList { get; set; }

        // A hymn can be in multiple sacrament meetings
        public ICollection<Meetings> Meeting { get; set; }
    }
}
