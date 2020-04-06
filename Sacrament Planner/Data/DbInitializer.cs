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
            new Members{FirstName="Joseph",LastName="Smith",Age=38,Gender="Male",Calling="Bishop"},
            new Members{FirstName="Emma",LastName="Smith",Age=30,Gender="Female",Calling="RS President"},
            new Members{FirstName="Sidney",LastName="Rigdon",Age=40,Gender="Male",Calling="1st Counselor"},
            new Members{FirstName="Frederick",LastName="Williams",Age=37,Gender="Male",Calling="2nd Counselor"},
            new Members{FirstName="Jane",LastName="Manning",Age=94,Gender="Female",Calling="Primary Teacher"},
            new Members{FirstName="David",LastName="Archuleta",Age=29,Gender="Male",Calling="Sunday School Teacher"},
            new Members{FirstName="Brandon",LastName="Flowers",Age=38,Gender="Male",Calling="Choir Director"},
            new Members{FirstName="Jack",LastName="Hill",Age=12,Gender="Male"},
            new Members{FirstName="Jill",LastName="Hill",Age=13,Gender="Female"}

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
            new Meetings{MeetingDate = DateTime.Parse("2020-09-01"), Presiding="Joseph Smith", Conducting="Joseph Smith",IntermediateSong="Did You Think To Pray?",IntermediateSongNumber=5, OpeningPrayer="Jack Hill", ClosingPrayer="Jane Manning", Speaker1="Jill Hill", Speaker1Topic="Easter", Speaker2="Emma Smith", Speaker2Topic="Easter", OpeningHymn="The Spirit of God",OpeningHymnNumber=5, SacramentHymn="While of These Emblems We Partake",SacramentHymnNumber=99, ClosingHymn="God Be with You Until We Meet Again", ClosingHymnNumber=30},
            new Meetings{MeetingDate = DateTime.Parse("2020-09-01"), Presiding="Joseph Smith", Conducting="Sidney Rigdon",IntermediateSong="Did You Think To Pray?",IntermediateSongNumber=2, OpeningPrayer="David Archuleta", ClosingPrayer="Jack Hill", Speaker1="Joseph Smith", Speaker1Topic="Atonement", Speaker2="Emma Smith", Speaker2Topic="Temples", OpeningHymn="Did You Think To Pray?",OpeningHymnNumber=5, SacramentHymn="I Stand All Amazed", SacramentHymnNumber=50, ClosingHymn="God Be with You Until We Meet Again", ClosingHymnNumber=20}
            };
            foreach (Meetings m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();
        }
    }
}