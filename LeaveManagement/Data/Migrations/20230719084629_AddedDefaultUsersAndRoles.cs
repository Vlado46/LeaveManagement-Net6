using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f222fe3-b66c-1ce2-ba21-323678d3b3a2", "4bb28b62-f362-4c50-ab06-3f6c6c8f483d", "User", "USER" },
                    { "2f451fe1-b32c-4ce8-ba33-760777a3c6a2", "679cde36-dd8e-4b12-864d-10fb7015237d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6f416fe1-b80c-4ce8-ba74-760742a3c7a2", 0, "3030c04b-352f-4378-acc2-3f8cee18f230", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEH3kd+cbtagStGNQxEYhNo5NQJTqu8YZkdIm4JddTsfBQ26otIeFaplscmpgM93c6g==", null, false, "856a03f3-ba4b-4b3e-ab41-9ea07eb21352", null, false, null },
                    { "c44d5636-a79b-4c37-ac30-82a2ceb84e70", 0, "d4f7c6e2-e4db-4358-abe6-d127e2c73fbf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2@test.com", false, "System", "User", false, null, "ADMIN2@TEST.COM", null, "AQAAAAEAACcQAAAAEOlwywgiC70ro3eg2WTw2j0uIFAQjML8msTarzte1kbaywn0J9tAGZtQVN447NCiPQ==", null, false, "c807eab2-28f2-4b97-a6d4-ee0d3c926390", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2f451fe1-b32c-4ce8-ba33-760777a3c6a2", "6f416fe1-b80c-4ce8-ba74-760742a3c7a2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2f222fe3-b66c-1ce2-ba21-323678d3b3a2", "c44d5636-a79b-4c37-ac30-82a2ceb84e70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f451fe1-b32c-4ce8-ba33-760777a3c6a2", "6f416fe1-b80c-4ce8-ba74-760742a3c7a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f222fe3-b66c-1ce2-ba21-323678d3b3a2", "c44d5636-a79b-4c37-ac30-82a2ceb84e70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f222fe3-b66c-1ce2-ba21-323678d3b3a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f451fe1-b32c-4ce8-ba33-760777a3c6a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f416fe1-b80c-4ce8-ba74-760742a3c7a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c44d5636-a79b-4c37-ac30-82a2ceb84e70");
        }
    }
}
