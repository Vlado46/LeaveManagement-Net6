using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f222fe3-b66c-1ce2-ba21-323678d3b3a2",
                column: "ConcurrencyStamp",
                value: "88cf02ce-3159-4542-8007-56f5083fe98e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f451fe1-b32c-4ce8-ba33-760777a3c6a2",
                column: "ConcurrencyStamp",
                value: "9f751030-dc89-4a00-bcf1-78fc3866666b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f416fe1-b80c-4ce8-ba74-760742a3c7a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd9d3914-eb8f-49eb-8f12-8c3ccbefd711", "AQAAAAEAACcQAAAAEEdDE5qaBOf2u87+jDM/KQPcsd8SpFIJRLKWF7sHxaKb3gpcWp1/ELQht46CphjUwA==", "b5a553f8-c9ce-4458-8ac1-776f0bf16d5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c44d5636-a79b-4c37-ac30-82a2ceb84e70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6b3fa0a-ea58-4a0e-96c1-0db1493db85f", "AQAAAAEAACcQAAAAEMblO4XSAqeJsXXzLGA43Ho4/l0W+POkWPBq/1kot4y2Fce6oBwkZ59wrQKms2waRg==", "6e99cc16-6703-4446-a226-ac3860f718ae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90666607-038e-4bf2-8596-b64e1861ffce", "AQAAAAEAACcQAAAAEIij2G8qNkdIM0FpvVIwVNXDkzb2CjZK8EnAuOcH82jIHAOL/dvBXrcvEadSftD0WQ==", "4dda573c-3161-4fea-b6a7-fc4e38213d4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c44d5636-a79b-4c37-ac30-82a2ceb84e70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c165394d-cd2d-4bde-b1b2-beb56098250e", "AQAAAAEAACcQAAAAEEpOq4zsbZ8fxbPnouFaX6+d82yvvuAgNdP8aK53BnR+f+056mKxQSfeOb2gfC52aA==", "22385b1a-1d25-4f9e-985a-6e0ffc13aaf6" });
        }
    }
}
