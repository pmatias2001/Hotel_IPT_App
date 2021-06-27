using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_IPT_App.Data.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
