using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class ListaUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Utilizadores");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Utilizadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Utilizadores",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cbea9c8-0500-4d92-976c-5bb4363ad8e7", "d359350e-477a-4925-be93-14ed42100fc2" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97270c74-8490-4e41-b4fd-7b832e9690d7", "dd191f1a-f393-4ed5-bd08-9ee657ed8e93" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6305d61c-ea07-4289-a054-cdba7f4672e0", "b22001d6-1caa-46ac-a205-432b417d0c45" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55f38a3e-2f0c-4231-afb3-0b33f5be8401", "dd1df798-07b8-4174-bfe5-e151275f5ebb" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e7843b5-89c8-42a7-8f8a-db2bf3978771", "d1af753c-7984-472a-befd-5eb785f3c4d1" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49f720b8-1ac0-4fae-a6ce-c948cb1ec871", "d2376715-1122-4431-bb2d-56c8c7dd0cef" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16fc0d76-6f78-4c01-8ac9-daaf86c8ba91", "ebe0f8d5-b393-49c1-ae4b-8b8450604316" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f124495d-80f1-47a3-9123-6cdb0a80fe20", "4990ee34-a336-4ec2-b6f7-6fc892e24bc5" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "439ab11e-d774-409a-9fe9-06c1d34398db", "67d51cd2-52f2-4352-ba52-c69715130225" });
        }
    }
}
