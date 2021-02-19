using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CheckIfMigrated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04c05a87-dff9-4280-8174-198a5b52b7ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfa66c65-4709-486f-b1a7-fb324b45bdfb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8be6297c-1dfb-4111-9553-c51b9261019c", "5fe38521-ca42-4121-ad1d-2e142aafe550", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "528608aa-6c94-490c-af8c-25f2177e3c66", "21bb3b04-097a-499b-8191-dd538c35be79", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "528608aa-6c94-490c-af8c-25f2177e3c66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8be6297c-1dfb-4111-9553-c51b9261019c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfa66c65-4709-486f-b1a7-fb324b45bdfb", "32119c9f-3918-4f7f-a21c-8278c9599ed4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04c05a87-dff9-4280-8174-198a5b52b7ff", "f5127c4a-3333-4771-9694-2a3916c831b2", "Employee", "EMPLOYEE" });
        }
    }
}
