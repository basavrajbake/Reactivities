using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Venue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    CutID = table.Column<string>(type: "TEXT", nullable: true),
                    CustFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    CustLastName = table.Column<string>(type: "TEXT", nullable: true),
                    ContactNo = table.Column<string>(type: "TEXT", nullable: true),
                    MailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    CardAssigned = table.Column<string>(type: "TEXT", nullable: true),
                    IDProof = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HotelServices",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    RoomNo = table.Column<string>(type: "TEXT", nullable: true),
                    Roomtype = table.Column<string>(type: "TEXT", nullable: true),
                    Services = table.Column<string>(type: "TEXT", nullable: true),
                    SubService = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelServices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomBookingStatuses",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    RoomID = table.Column<string>(type: "TEXT", nullable: true),
                    RoomNo = table.Column<string>(type: "TEXT", nullable: true),
                    RoomStatus = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBookingStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TotalRooms",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    RoomID = table.Column<string>(type: "TEXT", nullable: true),
                    RoomNo = table.Column<string>(type: "TEXT", nullable: true),
                    RoomType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalRooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTableforUserAction",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    CustFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    CustLastName = table.Column<string>(type: "TEXT", nullable: true),
                    CustRoomNo = table.Column<string>(type: "TEXT", nullable: true),
                    CustRoomType = table.Column<string>(type: "TEXT", nullable: true),
                    CustCardIssued = table.Column<string>(type: "TEXT", nullable: true),
                    CustServiceUsed = table.Column<string>(type: "TEXT", nullable: true),
                    CustServicePrice = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTableforUserAction", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "CustomerDetails");

            migrationBuilder.DropTable(
                name: "HotelServices");

            migrationBuilder.DropTable(
                name: "RoomBookingStatuses");

            migrationBuilder.DropTable(
                name: "TotalRooms");

            migrationBuilder.DropTable(
                name: "TransactionTableforUserAction");
        }
    }
}
