﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RateTheRest.Migrations
{
    public partial class Reviews1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    ChefID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvgRate = table.Column<float>(type: "real", nullable: true),
                    NumberOfRestaurants = table.Column<int>(type: "int", nullable: true),
                    SumOfRatings = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.ChefID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantID);
                });

            migrationBuilder.CreateTable(
                name: "Portraits",
                columns: table => new
                {
                    PortraitFileID = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portraits", x => x.PortraitFileID);
                    table.ForeignKey(
                        name: "FK_Portraits_Chefs_PortraitFileID",
                        column: x => x.PortraitFileID,
                        principalTable: "Chefs",
                        principalColumn: "ChefID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChefRestaurant",
                columns: table => new
                {
                    ChefsChefID = table.Column<int>(type: "int", nullable: false),
                    RestaurantsRestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChefRestaurant", x => new { x.ChefsChefID, x.RestaurantsRestaurantID });
                    table.ForeignKey(
                        name: "FK_ChefRestaurant_Chefs_ChefsChefID",
                        column: x => x.ChefsChefID,
                        principalTable: "Chefs",
                        principalColumn: "ChefID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChefRestaurant_Restaurants_RestaurantsRestaurantID",
                        column: x => x.RestaurantsRestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageFileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageFileID);
                    table.ForeignKey(
                        name: "FK_Images_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Restaurants_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logos",
                columns: table => new
                {
                    LogoFileID = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logos", x => x.LogoFileID);
                    table.ForeignKey(
                        name: "FK_Logos_Restaurants_LogoFileID",
                        column: x => x.LogoFileID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHours",
                columns: table => new
                {
                    OpeningHoursID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Open = table.Column<bool>(type: "bit", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: true),
                    To = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHours", x => x.OpeningHoursID);
                    table.ForeignKey(
                        name: "FK_OpeningHours_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    NumOfVotes = table.Column<int>(type: "int", nullable: false),
                    SumOfVotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Ratings_Restaurants_RatingID",
                        column: x => x.RatingID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagID);
                    table.ForeignKey(
                        name: "FK_Tags_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Ratings_RatingID",
                        column: x => x.RatingID,
                        principalTable: "Ratings",
                        principalColumn: "RatingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChefRestaurant_RestaurantsRestaurantID",
                table: "ChefRestaurant",
                column: "RestaurantsRestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_RestaurantID",
                table: "Images",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_RestaurantID",
                table: "OpeningHours",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantID",
                table: "Reviews",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_RestaurantID",
                table: "Tags",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RatingID",
                table: "Users",
                column: "RatingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChefRestaurant");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Logos");

            migrationBuilder.DropTable(
                name: "OpeningHours");

            migrationBuilder.DropTable(
                name: "Portraits");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Chefs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}