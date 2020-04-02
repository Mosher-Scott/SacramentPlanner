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
            new Members{FirstName="Emma",LastName="Smith",Age=30,IsMale=false,Calling="RS President"},
            new Members{FirstName="Sidney",LastName="Rigdon",Age=40,IsMale=true,Calling="1st Counselor"},
            new Members{FirstName="Frederick",LastName="Williams",Age=37,IsMale=true,Calling="2nd Counselor"},
            new Members{FirstName="Jane",LastName="Manning",Age=94,IsMale=false,Calling="Primary Teacher"},
            new Members{FirstName="David",LastName="Archuleta",Age=29,IsMale=true,Calling="Sunday School Teacher"},
            new Members{FirstName="Brandon",LastName="Flowers",Age=38,IsMale=true,Calling="Choir Director"},
            new Members{FirstName="Jack",LastName="Hill",Age=12,IsMale=true},
            new Members{FirstName="Jill",LastName="Hill",Age=13,IsMale=false}

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
            new Meetings{MeetingDate = DateTime.Parse("2020-09-01"), Presiding="Joseph Smith", Conducting="Joseph Smith",IntermediateSong="Did You Think To Pray?", OpeningPrayer="Jack Hill", ClosingPrayer="Jane Manning", Speaker1="Jill Hill", Speaker2="Emma Smith", OpeningHymn="The Spirit of God", SacramentHymn="While of These Emblems We Partake", ClosingHymn="God Be with You Until We Meet Again"},
            new Meetings{MeetingDate = DateTime.Parse("2020-09-01"), Presiding="Joseph Smith", Conducting="Sidney Rigdon",IntermediateSong="Did You Think To Pray?", OpeningPrayer="David Archuleta", ClosingPrayer="Jack Hill", Speaker1="Joseph Smith", Speaker2="Emma Smith", OpeningHymn="Did You Think To Pray?", SacramentHymn="I Stand All Amazed", ClosingHymn="God Be with You Until We Meet Again"}
            };
            foreach (Meetings m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();
        }
    }
}