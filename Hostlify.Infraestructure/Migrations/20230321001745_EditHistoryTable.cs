using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostlify.Infraestructure.Migrations
{
    public partial class EditHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "History");

            migrationBuilder.RenameColumn(
                name: "roomName",
                table: "History",
                newName: "flatName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(4483),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(9825),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(4983),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(7770),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Flats",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(2304),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4124));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "flatName",
                table: "History",
                newName: "roomName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(1539),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(3218),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(508),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 653, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4920),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "History",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(5841),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Flats",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 15, 3, 23, 391, DateTimeKind.Local).AddTicks(4124),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 19, 17, 45, 654, DateTimeKind.Local).AddTicks(2304));
        }
    }
}
