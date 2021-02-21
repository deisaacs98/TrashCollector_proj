using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class UpdatingControllerNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4ab2a1ff-a326-4ecb-a5e9-fa81501ce536", "710a1151-635b-47bf-93ec-966f10d69a5c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2267f8a1-c766-4a4c-a2f6-690623a9a052", "2ccb11e6-d10d-459f-9e8a-60a0ebca8969", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2267f8a1-c766-4a4c-a2f6-690623a9a052");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ab2a1ff-a326-4ecb-a5e9-fa81501ce536");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bbb3c507-fecc-4037-9a90-28ae235538be", "34465068-8d25-46b9-8055-37dcbfbda788", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24018235-35b5-46e3-8d0e-299a5d026fc7", "175f0f72-7828-429d-afe7-78aafc3a2f5d", "Employee", "EMPLOYEE" });
        }
    }
}
