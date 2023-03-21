using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostlify.Infraestructure.Migrations
{
    public partial class DeleteRoomAndServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodServices");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 474, DateTimeKind.Local).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 474, DateTimeKind.Local).AddTicks(8203),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 475, DateTimeKind.Local).AddTicks(957),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Flats",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 475, DateTimeKind.Local).AddTicks(215),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(2304));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(4483),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 474, DateTimeKind.Local).AddTicks(9268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 474, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(4983),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 475, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Flats",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(2304),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 20, 28, 1, 475, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.CreateTable(
                name: "FoodServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cream = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreamQuantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(7770)),
                    DateUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Dish = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DishQuantity = table.Column<int>(type: "int", nullable: false),
                    Drink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DrinkQuantity = table.Column<int>(type: "int", nullable: false),
                    Instruction = table.Column<string>(type: "varchar(999)", maxLength: 999, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    ManagerID = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodServices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(9825)),
                    DateUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "varchar(999)", maxLength: 999, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Emergency = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    EndDate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuestId = table.Column<int>(type: "int", nullable: true),
                    GuestStayComplete = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Initialdate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: true),
                    RoomName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicePending = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
