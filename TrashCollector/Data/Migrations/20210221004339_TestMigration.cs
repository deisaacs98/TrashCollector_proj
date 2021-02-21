using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bbb3c507-fecc-4037-9a90-28ae235538be", "34465068-8d25-46b9-8055-37dcbfbda788", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24018235-35b5-46e3-8d0e-299a5d026fc7", "175f0f72-7828-429d-afe7-78aafc3a2f5d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24018235-35b5-46e3-8d0e-299a5d026fc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb3c507-fecc-4037-9a90-28ae235538be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c5803c3-8e89-45bc-abfe-b26a9254ff34", "6508e6f6-eed9-4285-969d-c3348d42b1c1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a5615bd-f17e-4aa9-8a95-0c7fd221c89f", "9411cedf-93b2-4d49-93c6-fbc8d0a5863e", "Employee", "EMPLOYEE" });
        }
    }
}
