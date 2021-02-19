using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class ChangedViewNamesToSingular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7c5803c3-8e89-45bc-abfe-b26a9254ff34", "6508e6f6-eed9-4285-969d-c3348d42b1c1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a5615bd-f17e-4aa9-8a95-0c7fd221c89f", "9411cedf-93b2-4d49-93c6-fbc8d0a5863e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c5803c3-8e89-45bc-abfe-b26a9254ff34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a5615bd-f17e-4aa9-8a95-0c7fd221c89f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8be6297c-1dfb-4111-9553-c51b9261019c", "5fe38521-ca42-4121-ad1d-2e142aafe550", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "528608aa-6c94-490c-af8c-25f2177e3c66", "21bb3b04-097a-499b-8191-dd538c35be79", "Employee", "EMPLOYEE" });
        }
    }
}
