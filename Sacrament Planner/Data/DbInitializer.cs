using Sacrament_Planner.Models;
using System;
using System.Linq;

namespace Sacrament_Planner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any members.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            var members = new Members[]
            {
            new Members{FirstName="Joseph",LastName="Smith",Age=38,IsMale=true,Calling="Bishop"},
            new Members{FirstName="Jane",LastName="Manning",Age=94,IsMale=false,Calling="Primary Teacher"},
            new Members{FirstName="David",LastName="Archuleta",Age=29,IsMale=true,Calling="Sunday School Teacher"},
            new Members{FirstName="Brandon",LastName="Flowers",Age=38,IsMale=true,Calling="Choir Director"}

            };
            foreach (Members m in members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();

            var hymns = new Hymns[]
            {
            new Hymns{HymnName="The Spirit of God", PageNumber=2},
            new Hymns{HymnName="While of These Emblems We Partake", PageNumber=174},
            new Hymns{HymnName="God Be with You Until We Meet Again", PageNumber=152},
            new Hymns{HymnName="Did You Think To Pray?", PageNumber=140},
            new Hymns{HymnName="I Stand All Amazed", PageNumber=193}
            };
            foreach (Hymns h in hymns)
            {
                context.Hymns.Add(h);
            }
            context.SaveChanges();

            var meetings = new Meetings[]
            {
            new Meetings{MeetingDate = DateTime.Parse("2020-09-01"), Presiding="Joseph Smith", Conducting="Joseph Smith",IntermediateSong=1}
           
            };
            foreach (Meetings m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();
        }
    }
}