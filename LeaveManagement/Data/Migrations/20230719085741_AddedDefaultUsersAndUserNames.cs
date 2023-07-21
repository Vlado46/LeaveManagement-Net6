using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f222fe3-b66c-1ce2-ba21-323678d3b3a2",
                column: "ConcurrencyStamp",
                value: "bab96625-ae49-4f96-999f-ce3f62952021");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f451fe1-b32c-4ce8-ba33-760777a3c6a2",
                column: "ConcurrencyStamp",
                value: "28cf069c-530a-44cd-9caf-fe2e8af35eaf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f416fe1-b80c-4ce8-ba74-760742a3c7a2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "90666607-038e-4bf2-8596-b64e1861ffce", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEIij2G8qNkdIM0FpvVIwVNXDkzb2CjZK8EnAuOcH82jIHAOL/dvBXrcvEadSftD0WQ==", "4dda573c-3161-4fea-b6a7-fc4e38213d4e", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c44d5636-a79b-4c37-ac30-82a2ceb84e70",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c165394d-cd2d-4bde-b1b2-beb56098250e", true, "ADMIN2@TEST.COM", "AQAAAAEAACcQAAAAEEpOq4zsbZ8fxbPnouFaX6+d82yvvuAgNdP8aK53BnR+f+056mKxQSfeOb2gfC52aA==", "22385b1a-1d25-4f9e-985a-6e0ffc13aaf6", "admin2@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f222fe3-b66c-1ce2-ba21-323678d3b3a2",
                column: "ConcurrencyStamp",
                value: "4bb28b62-f362-4c50-ab06-3f6c6c8f483d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f451fe1-b32c-4ce8-ba33-760777a3c6a2",
                column: "ConcurrencyStamp",
                value: "679cde36-dd8e-4b12-864d-10fb7015237d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f416fe1-b80c-4ce8-ba74-760742a3c7a2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3030c04b-352f-4378-acc2-3f8cee18f230", false, null, "AQAAAAEAACcQAAAAEH3kd+cbtagStGNQxEYhNo5NQJTqu8YZkdIm4JddTsfBQ26otIeFaplscmpgM93c6g==", "856a03f3-ba4b-4b3e-ab41-9ea07eb21352", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c44d5636-a79b-4c37-ac30-82a2ceb84e70",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d4f7c6e2-e4db-4358-abe6-d127e2c73fbf", false, null, "AQAAAAEAACcQAAAAEOlwywgiC70ro3eg2WTw2j0uIFAQjML8msTarzte1kbaywn0J9tAGZtQVN447NCiPQ==", "c807eab2-28f2-4b97-a6d4-ee0d3c926390", null });
        }
    }
}
