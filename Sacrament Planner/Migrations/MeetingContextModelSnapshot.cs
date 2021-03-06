﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sacrament_Planner.Data;

namespace Sacrament_Planner.Migrations
{
    [DbContext(typeof(MeetingContext))]
    partial class MeetingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("HymnName")
                        .IsRequired();

                    b.Property<int>("PageNumber");

                    b.HasKey("ID");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("Sacrament_Planner.Models.Meetings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingHymn")
                        .IsRequired();

                    b.Property<int>("ClosingHymnNumber");

                    b.Property<string>("ClosingPrayer")
                        .IsRequired();

                    b.Property<string>("Conducting")
                        .IsRequired();

                    b.Property<string>("IntermediateMusicalNumber");

                    b.Property<string>("IntermediateSong");

                    b.Property<int>("IntermediateSongNumber");

                    b.Property<DateTime>("MeetingDate");

                    b.Property<string>("OpeningHymn")
                        .IsRequired();

                    b.Property<int>("OpeningHymnNumber");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired();

                    b.Property<string>("Presiding")
                        .IsRequired();

                    b.Property<string>("SacramentHymn")
                        .IsRequired();

                    b.Property<int>("SacramentHymnNumber");

                    b.Property<string>("Speaker1");

                    b.Property<string>("Speaker1Topic");

                    b.Property<string>("Speaker2");

                    b.Property<string>("Speaker2Topic");

                    b.Property<string>("Speaker3");

                    b.Property<string>("Speaker3Topic");

                    b.Property<string>("Speaker4");

                    b.Property<string>("Speaker4Topic");

                    b.Property<string>("Speaker5");

                    b.Property<string>("Speaker5Topic");

                    b.Property<string>("Speaker6");

                    b.Property<string>("Speaker6Topic");

                    b.Property<string>("Speaker7");

                    b.Property<string>("Speaker7Topic");

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

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsMale");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
