using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sacrament_Planner.Models
{
    public class TopicAssignment
    {
        //TODO: Finish creating foreign keys
        //primary key
        public int TopicID { get; set; }

        //foreign key to Meetings Model
        public int MeetingID { get; set; }

        //foreign key to Members Model
        public int MemberID { get; set; }

        public string Topic { get; set; }
    }
}
