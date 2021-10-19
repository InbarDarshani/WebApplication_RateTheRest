﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RateTheRest.Data;

namespace RateTheRest.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211018203552_Restaurant1")]
    partial class Restaurant1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChefRestaurant", b =>
                {
                    b.Property<int>("ChefsChefID")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsRestaurantID")
                        .HasColumnType("int");

                    b.HasKey("ChefsChefID", "RestaurantsRestaurantID");

                    b.HasIndex("RestaurantsRestaurantID");

                    b.ToTable("ChefRestaurant");
                });

            modelBuilder.Entity("RateTheRest.Additional.DayHours", b =>
                {
                    b.Property<int>("DayHoursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Open")
                        .HasColumnType("bit");

                    b.Property<int?>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("DayHoursID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("DayHours");
                });

            modelBuilder.Entity("RateTheRest.Additional.ImageFile", b =>
                {
                    b.Property<int>("ImageFileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantID")
                        .HasColumnType("int");

                    b.HasKey("ImageFileID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("RateTheRest.Additional.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("RateTheRest.Additional.Tag", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RateTheRest.Models.Chef", b =>
                {
                    b.Property<int>("ChefID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AvgRate")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhotoImageFileID")
                        .HasColumnType("int");

                    b.HasKey("ChefID");

                    b.HasIndex("PhotoImageFileID");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("RateTheRest.Models.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumOfVotes")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("RatingID");

                    b.HasIndex("RestaurantID")
                        .IsUnique();

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("RateTheRest.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("LogoImageFileID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingID")
                        .HasColumnType("int");

                    b.HasKey("RestaurantID");

                    b.HasIndex("LocationId");

                    b.HasIndex("LogoImageFileID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("RateTheRest.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("RateTheRest.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RatingID")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RatingID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RestaurantTag", b =>
                {
                    b.Property<int>("RestaurantsRestaurantID")
                        .HasColumnType("int");

                    b.Property<int>("TagsTagID")
                        .HasColumnType("int");

                    b.HasKey("RestaurantsRestaurantID", "TagsTagID");

                    b.HasIndex("TagsTagID");

                    b.ToTable("RestaurantTag");
                });

            modelBuilder.Entity("ChefRestaurant", b =>
                {
                    b.HasOne("RateTheRest.Models.Chef", null)
                        .WithMany()
                        .HasForeignKey("ChefsChefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateTheRest.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsRestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RateTheRest.Additional.DayHours", b =>
                {
                    b.HasOne("RateTheRest.Models.Restaurant", null)
                        .WithMany("OpeningHours")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("RateTheRest.Additional.ImageFile", b =>
                {
                    b.HasOne("RateTheRest.Models.Restaurant", null)
                        .WithMany("Photos")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("RateTheRest.Models.Chef", b =>
                {
                    b.HasOne("RateTheRest.Additional.ImageFile", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoImageFileID");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("RateTheRest.Models.Rating", b =>
                {
                    b.HasOne("RateTheRest.Models.Restaurant", "Restaurant")
                        .WithOne("Rating")
                        .HasForeignKey("RateTheRest.Models.Rating", "RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RateTheRest.Models.Restaurant", b =>
                {
                    b.HasOne("RateTheRest.Additional.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("RateTheRest.Additional.ImageFile", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoImageFileID");

                    b.Navigation("Location");

                    b.Navigation("Logo");
                });

            modelBuilder.Entity("RateTheRest.Models.Review", b =>
                {
                    b.HasOne("RateTheRest.Models.Restaurant", null)
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantID");

                    b.HasOne("RateTheRest.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RateTheRest.Models.User", b =>
                {
                    b.HasOne("RateTheRest.Models.Rating", null)
                        .WithMany("User")
                        .HasForeignKey("RatingID");
                });

            modelBuilder.Entity("RestaurantTag", b =>
                {
                    b.HasOne("RateTheRest.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsRestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateTheRest.Additional.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RateTheRest.Models.Rating", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("RateTheRest.Models.Restaurant", b =>
                {
                    b.Navigation("OpeningHours");

                    b.Navigation("Photos");

                    b.Navigation("Rating")
                        .IsRequired();

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}