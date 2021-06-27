using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class b : Migration
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
                values: new object[] { "ebc1392f-732d-4d97-b60a-fb117ee9e3e0", "a23ddb6e-2627-435d-a5ae-37f47bb65fa9" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5c3a477-f8ea-4880-a580-76dd7716016e", "9b4208c0-18f2-4c5e-ae16-21ab6eded292" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64107cf1-63c3-4acf-a403-547a9f46de35", "11c7e20b-f575-45d9-89bd-729a4842dbdb" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad5f542f-bc53-4ae2-98d9-df2c83d7ab53", "6aa928cd-aab2-48c0-ae66-9b9c1ee659b7" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed2b7f3d-9acf-4b93-9559-37b8b1b5aa50", "8429b976-b362-452c-9979-f64714520de6" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b130888-f978-4d9f-9b34-04a439b6eebe", "7cba4b0f-a057-4513-86a0-b398034840ac" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e1e81bb-408e-4ca0-ad66-71e05c963562", "0388bdc8-abf7-4ad0-842f-503215f05a70" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cc577c9-4b3e-42b6-9890-3cca9bd8f56c", "fa4c4b3c-7a1d-4deb-9f1f-27712bf05806" });

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6daffa6f-b568-42e6-a1f5-163bac49988f", "5c7ddb81-9400-4345-9b04-ddd3265cb084" });
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
    }
}
