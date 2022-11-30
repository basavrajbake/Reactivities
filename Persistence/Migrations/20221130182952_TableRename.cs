using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class TableRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TotalRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionTableforUserAction",
                table: "TransactionTableforUserAction");

            migrationBuilder.RenameTable(
                name: "TransactionTableforUserAction",
                newName: "TransactionTableforUserActions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionTableforUserActions",
                table: "TransactionTableforUserActions",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    RoomID = table.Column<string>(type: "TEXT", nullable: true),
                    RoomNo = table.Column<string>(type: "TEXT", nullable: true),
                    RoomType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionTableforUserActions",
                table: "TransactionTableforUserActions");

            migrationBuilder.RenameTable(
                name: "TransactionTableforUserActions",
                newName: "TransactionTableforUserAction");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionTableforUserAction",
                table: "TransactionTableforUserAction",
                column: "ID");

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
        }
    }
}
