using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostlify.Infraestructure.Migrations
{
    public partial class newUserPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(6348),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8069),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(5282),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(9769),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(8277));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(4802),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Rooms",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(6517),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Plans",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(3733),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "History",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(7355),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "FoodServices",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 20, 34, 59, 647, DateTimeKind.Local).AddTicks(8277),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 3, 20, 12, 35, 53, 572, DateTimeKind.Local).AddTicks(9769));
        }
    }
}
