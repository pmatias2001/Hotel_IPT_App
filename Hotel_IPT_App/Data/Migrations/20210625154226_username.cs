using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class username : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRegisto",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "fb45e4e6-0919-4367-a449-7fea4125d048", "3457bb89-cc89-4987-9098-95bb0cbbae0a", "eb8c0a35-2f8b-4685-b378-7c55356b76c3" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "0d98aab3-3481-4af8-b0f3-4423315a8616", "ed121f2c-dde0-486b-8dec-fb2fcb88fabe", "2afb0840-4a32-408c-9fbb-16f8543087f7" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "a427e9ce-ffd2-4337-8e53-5012aa3a3c7a", "48ac6f00-dfab-4c65-97e7-4f57bbdb9fd3", "51c94dd7-e6cf-4224-b3e8-cb4712c1515f" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "e11aa619-3a1f-4a80-b48f-9804ad56e90b", "b2427c6b-c376-4949-82f0-a3fcad7a4a97", "dea6e9de-ae9c-4762-9790-52390e7e014d" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "f471d35c-9ca3-4834-b478-78e35134a0d4", "4e60ba24-c269-4a10-9c2c-abdef40b2479", "37f3f3c6-040c-47e4-8627-bec3121d7031" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "93bf7630-ebf1-4ab8-a531-c6b74d0edc13", "ae9e0552-32cc-4749-806d-9fff9ce52f40", "56c02c89-ec50-44ba-ae58-1eb9fa1d559c" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "ecb7b0ec-a3de-4ab0-9f20-deb0a50ebce2", "badce9ae-a93a-44b7-8b0d-0b6512288fd2", "d2abc043-5019-405b-94c0-11e18450afc1" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "baee3e3a-8c21-4372-9383-9d01424463fd", "728a6931-f8d3-47bf-ae95-f6cd95df7fea", "48d5365e-2025-469d-99d3-484ffb7ca09f" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "IdUser",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "2d6cea47-09d6-43d8-b5b8-9d410a3e4af3", "54ed9e45-1e0e-4748-9098-dec674300ceb", "42d74b4c-b3b1-486a-9d84-007566070aa7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Id",
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

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Utilizadores");

            migrationBuilder.DropColumn(
                name: "DataRegisto",
                table: "AspNetUsers");
        }
    }
}
