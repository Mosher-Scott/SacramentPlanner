﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sacrament_Planner.Data;

namespace Sacrament_Planner.Migrations
{
    [DbContext(typeof(MeetingContext))]
    [Migration("20200331204004_AddSpeakers")]
    partial class AddSpeakers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sacrament_Planner.Models.Hymns", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HymnName");

                    b.Property<int>("PageNumber");

                    b.HasKey("ID");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("Sacrament_Planner.Models.Meetings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingHymn");

                    b.Property<string>("ClosingPrayer");

                    b.Property<string>("Conducting");

                    b.Property<string>("IntermediateMusicalNumber");

                    b.Property<int>("IntermediateSong");

                    b.Property<DateTime>("MeetingDate");

                    b.Property<string>("OpeningHymn");

                    b.Property<string>("OpeningPrayer");

                    b.Property<string>("Presiding");

                    b.Property<string>("SacramentHymn");

                    b.Property<string>("Speaker1");

                    b.Property<string>("Speaker2");

                    b.Property<string>("Speaker3");

                    b.Property<string>("Speaker4");

                    b.Property<string>("Speaker5");

                    b.Property<string>("Speaker6");

                    b.Property<string>("Speaker7");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("Sacrament_Planner.Models.Members", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Calling");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsMale");

                    b.Property<string>("LastName");

                    b.Property<int?>("MeetingsID");

                    b.HasKey("ID");

                    b.HasIndex("MeetingsID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Sacrament_Planner.Models.Members", b =>
                {
                    b.HasOne("Sacrament_Planner.Models.Meetings")
                        .WithMany("Speakers")
                        .HasForeignKey("MeetingsID");
                });
#pragma warning restore 612, 618
        }
    }
}