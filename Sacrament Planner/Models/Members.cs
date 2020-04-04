﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_Planner.Models
{
    public class Members
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Can use this to decide automatically whether the speaker is a youth speaker or not
        public int Age { get; set; }

        // We can use this to check if the user is M or F to add "Brother" or "Sister" in front of the name
        public bool IsMale { get; set; }
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
                if(IsMale)
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
