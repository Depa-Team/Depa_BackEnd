using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostlify.Infraestructure.Migrations
{
    public partial class newUserPhoneAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(1227),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.AddColumn<int>(
                name: "phoneNumber",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(2748),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 267, DateTimeKind.Local).AddTicks(9929),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(4498),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(9769));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(6348),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8069),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(5282),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 267, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(9769),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 13, 7, 2, 268, DateTimeKind.Local).AddTicks(4498));
        }
    }
}
