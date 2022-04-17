using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infrustructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 65535, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(320)", maxLength: 320, nullable: false),
                    Message = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    FacebookUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    InstagramUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    LinkedinUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(320)", maxLength: 320, nullable: false),
                    WelcomeText = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    AboutUsText = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    FacebookUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    InstagramUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    LinkedinUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "VARCHAR(8000)", maxLength: 8000, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Text = table.Column<string>(type: "VARCHAR(4000)", maxLength: 4000, nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slides_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(320)", maxLength: 320, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(64)", maxLength: 64, nullable: false),
                    Photo = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "TEXT", maxLength: 4000, nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    NewId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_News_NewId",
                        column: x => x.NewId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Content from activity 1", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9663), "ImageActivities1.jpg", false, "Activity 1" },
                    { 2, "Content from activity 2", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9671), "ImageActivities2.jpg", false, "Activity 2" },
                    { 3, "Content from activity 3", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9677), "ImageActivities3.jpg", false, "Activity 3" },
                    { 4, "Content from activity 4", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9681), "ImageActivities4.jpg", false, "Activity 4" },
                    { 5, "Content from activity 5", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9690), "ImageActivities5.jpg", false, "Activity 5" },
                    { 6, "Content from activity 6", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9696), "ImageActivities6.jpg", false, "Activity 6" },
                    { 7, "Content from activity 7", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9701), "ImageActivities7.jpg", false, "Activity 7" },
                    { 8, "Content from activity 8", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9706), "ImageActivities8.jpg", false, "Activity 8" },
                    { 9, "Content from activity 9", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9711), "ImageActivities9.jpg", false, "Activity 9" },
                    { 10, "Content from activity 10", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9717), "ImageActivities10.jpg", false, "Activity 10" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9752), "Description for Category 1", "ImageCategories1.jpg", false, "Activity 1" },
                    { 2, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9760), "Description for Category 2", "ImageCategories2.jpg", false, "Activity 2" },
                    { 3, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9765), "Description for Category 3", "ImageCategories3.jpg", false, "Activity 3" },
                    { 4, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9770), "Description for Category 4", "ImageCategories4.jpg", false, "Activity 4" },
                    { 5, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9774), "Description for Category 5", "ImageCategories5.jpg", false, "Activity 5" },
                    { 6, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9837), "Description for Category 6", "ImageCategories6.jpg", false, "Activity 6" },
                    { 7, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9843), "Description for Category 7", "ImageCategories7.jpg", false, "Activity 7" },
                    { 8, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9848), "Description for Category 8", "ImageCategories8.jpg", false, "Activity 8" },
                    { 9, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9853), "Description for Category 9", "ImageCategories9.jpg", false, "Activity 9" },
                    { 10, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9876), "Description for Category 10", "ImageCategories10.jpg", false, "Activity 10" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedAt", "Email", "IsDeleted", "Message", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(41), "Email for contact 1", false, "Message from contact 1", "Contact 1", 382 },
                    { 2, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(46), "Email for contact 2", false, "Message from contact 2", "Contact 2", 383 },
                    { 3, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(51), "Email for contact 3", false, "Message from contact 3", "Contact 3", 384 },
                    { 4, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(56), "Email for contact 4", false, "Message from contact 4", "Contact 4", 385 },
                    { 5, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(61), "Email for contact 5", false, "Message from contact 5", "Contact 5", 386 },
                    { 6, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(66), "Email for contact 6", false, "Message from contact 6", "Contact 6", 387 },
                    { 7, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(71), "Email for contact 7", false, "Message from contact 7", "Contact 7", 388 },
                    { 8, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(75), "Email for contact 8", false, "Message from contact 8", "Contact 8", 389 },
                    { 9, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(80), "Email for contact 9", false, "Message from contact 9", "Contact 9", 390 },
                    { 10, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(86), "Email for contact 10", false, "Message from contact 10", "Contact 10", 391 }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "CreatedAt", "Description", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(100), "Description for member 1", "FacebookURL for member 1", "ImageMembers1.jpg", "InstagramURL for member 1", false, "LinkdInURL for member 1", "Member 1" },
                    { 2, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(136), "Description for member 2", "FacebookURL for member 2", "ImageMembers2.jpg", "InstagramURL for member 2", false, "LinkdInURL for member 2", "Member 2" },
                    { 3, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(144), "Description for member 3", "FacebookURL for member 3", "ImageMembers3.jpg", "InstagramURL for member 3", false, "LinkdInURL for member 3", "Member 3" },
                    { 4, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(150), "Description for member 4", "FacebookURL for member 4", "ImageMembers4.jpg", "InstagramURL for member 4", false, "LinkdInURL for member 4", "Member 4" },
                    { 5, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(156), "Description for member 5", "FacebookURL for member 5", "ImageMembers5.jpg", "InstagramURL for member 5", false, "LinkdInURL for member 5", "Member 5" },
                    { 6, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(162), "Description for member 6", "FacebookURL for member 6", "ImageMembers6.jpg", "InstagramURL for member 6", false, "LinkdInURL for member 6", "Member 6" },
                    { 7, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(168), "Description for member 7", "FacebookURL for member 7", "ImageMembers7.jpg", "InstagramURL for member 7", false, "LinkdInURL for member 7", "Member 7" },
                    { 8, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(174), "Description for member 8", "FacebookURL for member 8", "ImageMembers8.jpg", "InstagramURL for member 8", false, "LinkdInURL for member 8", "Member 8" },
                    { 9, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(179), "Description for member 9", "FacebookURL for member 9", "ImageMembers9.jpg", "InstagramURL for member 9", false, "LinkdInURL for member 9", "Member 9" },
                    { 10, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(187), "Description for member 10", "FacebookURL for member 10", "ImageMembers10.jpg", "InstagramURL for member 10", false, "LinkdInURL for member 10", "Member 10" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "AboutUsText", "Address", "CreatedAt", "Email", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name", "Phone", "WelcomeText" },
                values: new object[,]
                {
                    { 1, "AboutUsText for Organization 1", "Address for Organization 1", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(204), "Email for Organization 1", "FacebookUrl1", "ImageOrganizations1.jpg", "InstagramUrl1", false, "InstragramUrl1", "Organization 1", 382, "WelcomeText for Organization 1" },
                    { 2, "AboutUsText for Organization 2", "Address for Organization 2", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(213), "Email for Organization 2", "FacebookUrl2", "ImageOrganizations2.jpg", "InstagramUrl2", false, "InstragramUrl2", "Organization 2", 383, "WelcomeText for Organization 2" }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "AboutUsText", "Address", "CreatedAt", "Email", "FacebookUrl", "Image", "InstagramUrl", "IsDeleted", "LinkedinUrl", "Name", "Phone", "WelcomeText" },
                values: new object[,]
                {
                    { 3, "AboutUsText for Organization 3", "Address for Organization 3", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(248), "Email for Organization 3", "FacebookUrl3", "ImageOrganizations3.jpg", "InstagramUrl3", false, "InstragramUrl3", "Organization 3", 384, "WelcomeText for Organization 3" },
                    { 4, "AboutUsText for Organization 4", "Address for Organization 4", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(256), "Email for Organization 4", "FacebookUrl4", "ImageOrganizations4.jpg", "InstagramUrl4", false, "InstragramUrl4", "Organization 4", 385, "WelcomeText for Organization 4" },
                    { 5, "AboutUsText for Organization 5", "Address for Organization 5", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(262), "Email for Organization 5", "FacebookUrl5", "ImageOrganizations5.jpg", "InstagramUrl5", false, "InstragramUrl5", "Organization 5", 386, "WelcomeText for Organization 5" },
                    { 6, "AboutUsText for Organization 6", "Address for Organization 6", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(270), "Email for Organization 6", "FacebookUrl6", "ImageOrganizations6.jpg", "InstagramUrl6", false, "InstragramUrl6", "Organization 6", 387, "WelcomeText for Organization 6" },
                    { 7, "AboutUsText for Organization 7", "Address for Organization 7", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(276), "Email for Organization 7", "FacebookUrl7", "ImageOrganizations7.jpg", "InstagramUrl7", false, "InstragramUrl7", "Organization 7", 388, "WelcomeText for Organization 7" },
                    { 8, "AboutUsText for Organization 8", "Address for Organization 8", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(318), "Email for Organization 8", "FacebookUrl8", "ImageOrganizations8.jpg", "InstagramUrl8", false, "InstragramUrl8", "Organization 8", 389, "WelcomeText for Organization 8" },
                    { 9, "AboutUsText for Organization 9", "Address for Organization 9", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(324), "Email for Organization 9", "FacebookUrl9", "ImageOrganizations9.jpg", "InstagramUrl9", false, "InstragramUrl9", "Organization 9", 390, "WelcomeText for Organization 9" },
                    { 10, "AboutUsText for Organization 10", "Address for Organization 10", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(333), "Email for Organization 10", "FacebookUrl10", "ImageOrganizations10.jpg", "InstagramUrl10", false, "InstragramUrl10", "Organization 10", 391, "WelcomeText for Organization 10" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(8715), "Description User Admin", false, "Administrator" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description User Standard", false, "Standard" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Contetnt for Testimonial 1", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(377), "Image for testimonial 1", false, "Organization 1" },
                    { 2, "Contetnt for Testimonial 2", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(386), "Image for testimonial 2", false, "Organization 2" },
                    { 3, "Contetnt for Testimonial 3", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(392), "Image for testimonial 3", false, "Organization 3" },
                    { 4, "Contetnt for Testimonial 4", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(397), "Image for testimonial 4", false, "Organization 4" },
                    { 5, "Contetnt for Testimonial 5", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(402), "Image for testimonial 5", false, "Organization 5" },
                    { 6, "Contetnt for Testimonial 6", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(408), "Image for testimonial 6", false, "Organization 6" },
                    { 7, "Contetnt for Testimonial 7", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(413), "Image for testimonial 7", false, "Organization 7" },
                    { 8, "Contetnt for Testimonial 8", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(418), "Image for testimonial 8", false, "Organization 8" },
                    { 9, "Contetnt for Testimonial 9", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(423), "Image for testimonial 9", false, "Organization 9" },
                    { 10, "Contetnt for Testimonial 10", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(430), "Image for testimonial 10", false, "Organization 10" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Content for New 1", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9889), "Image for New 1", false, "New 1" },
                    { 2, 2, "Content for New 2", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9895), "Image for New 2", false, "New 2" },
                    { 3, 3, "Content for New 3", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9901), "Image for New 3", false, "New 3" },
                    { 4, 4, "Content for New 4", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9906), "Image for New 4", false, "New 4" },
                    { 5, 5, "Content for New 5", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9911), "Image for New 5", false, "New 5" },
                    { 6, 6, "Content for New 6", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9916), "Image for New 6", false, "New 6" },
                    { 7, 7, "Content for New 7", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9921), "Image for New 7", false, "New 7" },
                    { 8, 8, "Content for New 8", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9925), "Image for New 8", false, "New 8" },
                    { 9, 9, "Content for New 9", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9930), "Image for New 9", false, "New 9" },
                    { 10, 10, "Content for New 10", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9936), "Image for New 10", false, "New 10" }
                });

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsDeleted", "Order", "OrganizationId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(441), "ImageUrl for Slide 1", false, 1, 1, "Text for Slide 1" },
                    { 2, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(447), "ImageUrl for Slide 2", false, 2, 2, "Text for Slide 2" },
                    { 3, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(453), "ImageUrl for Slide 3", false, 3, 3, "Text for Slide 3" },
                    { 4, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(458), "ImageUrl for Slide 4", false, 4, 4, "Text for Slide 4" },
                    { 5, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(463), "ImageUrl for Slide 5", false, 5, 5, "Text for Slide 5" },
                    { 6, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(469), "ImageUrl for Slide 6", false, 6, 6, "Text for Slide 6" },
                    { 7, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(474), "ImageUrl for Slide 7", false, 7, 7, "Text for Slide 7" },
                    { 8, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(479), "ImageUrl for Slide 8", false, 8, 8, "Text for Slide 8" },
                    { 9, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(512), "ImageUrl for Slide 9", false, 9, 9, "Text for Slide 9" },
                    { 10, new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(519), "ImageUrl for Slide 10", false, 10, 10, "Text for Slide 10" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Photo", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9070), "Email for user 1", "User1", false, "LastName for user 1", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 1", 1 },
                    { 2, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9156), "Email for user 2", "User2", false, "LastName for user 2", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 2", 1 },
                    { 3, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9241), "Email for user 3", "User3", false, "LastName for user 3", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 3", 2 },
                    { 4, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9290), "Email for user 4", "User4", false, "LastName for user 4", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 4", 2 },
                    { 5, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9343), "Email for user 5", "User5", false, "LastName for user 5", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 5", 2 },
                    { 6, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9391), "Email for user 6", "User6", false, "LastName for user 6", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 6", 2 },
                    { 7, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9466), "Email for user 7", "User7", false, "LastName for user 7", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 7", 2 },
                    { 8, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9513), "Email for user 8", "User8", false, "LastName for user 8", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 8", 2 },
                    { 9, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9557), "Email for user 9", "User9", false, "LastName for user 9", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 9", 2 },
                    { 10, new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9638), "Email for user 10", "User10", false, "LastName for user 10", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92", "Photo for user 10", 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Body", "CreatedAt", "IsDeleted", "NewId", "UserId" },
                values: new object[,]
                {
                    { 1, "Body from Comment 1", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9952), false, 1, 1 },
                    { 2, "Body from Comment 2", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9959), false, 2, 2 },
                    { 3, "Body from Comment 3", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9964), false, 3, 3 },
                    { 4, "Body from Comment 4", new DateTime(2022, 4, 16, 3, 15, 36, 903, DateTimeKind.Local).AddTicks(9998), false, 4, 4 },
                    { 5, "Body from Comment 5", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(3), false, 5, 5 },
                    { 6, "Body from Comment 6", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(8), false, 6, 6 },
                    { 7, "Body from Comment 7", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(13), false, 7, 7 },
                    { 8, "Body from Comment 8", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(18), false, 8, 8 },
                    { 9, "Body from Comment 9", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(22), false, 9, 9 },
                    { 10, "Body from Comment 10", new DateTime(2022, 4, 16, 3, 15, 36, 904, DateTimeKind.Local).AddTicks(28), false, 10, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewId",
                table: "Comments",
                column: "NewId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Slides_OrganizationId",
                table: "Slides",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
