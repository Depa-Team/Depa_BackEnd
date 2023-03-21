using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostlify.Infraestructure.Migrations
{
    public partial class newFlatTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(1539),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(3218),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(508),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 267, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4920),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(5841),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    flatName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuestId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    Initialdate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EndDate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4124)),
                    DateUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flats");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(1227),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(2748),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 267, DateTimeKind.Local).AddTicks(9929),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(4498),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(5841));
        }
    }
}
