using Sacrament_Planner.Models;
using Microsoft.EntityFrameworkCore;

namespace Sacrament_Planner.Data
{
    public class MeetingContext : DbContext
    {
        internal readonly object meetings;

        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Members> Members { get; set; }
        public DbSet<Meetings> Meetings { get; set; }
        public DbSet<Hymns> Hymns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>().ToTable("Member");
            modelBuilder.Entity<Meetings>().ToTable("Meeting");
            modelBuilder.Entity<Hymns>().ToTable("Hymn");
        }
    }
}
