﻿// <auto-generated />
using System;
using MeetupAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeetupAPI.Migrations
{
    [DbContext(typeof(MeetupContext))]
    [Migration("20210406215318_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeetupAPI.Entities.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<int>("MeetupId");

                    b.Property<string>("Topic");

                    b.HasKey("Id");

                    b.HasIndex("MeetupId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("MeetupAPI.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<int>("MeetupId");

                    b.Property<string>("PostCode");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("MeetupId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MeetupAPI.Entities.Meetup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name");

                    b.Property<string>("Organizer");

                    b.HasKey("Id");

                    b.ToTable("Meetups");
                });

            modelBuilder.Entity("MeetupAPI.Entities.Lecture", b =>
                {
                    b.HasOne("MeetupAPI.Entities.Meetup", "Meetup")
                        .WithMany("Lectures")
                        .HasForeignKey("MeetupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeetupAPI.Entities.Location", b =>
                {
                    b.HasOne("MeetupAPI.Entities.Meetup", "Meetup")
                        .WithOne("Location")
                        .HasForeignKey("MeetupAPI.Entities.Location", "MeetupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
