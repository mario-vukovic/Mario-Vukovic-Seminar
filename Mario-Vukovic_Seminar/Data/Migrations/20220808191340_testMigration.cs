using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mario_Vukovic_Seminar.Data.Migrations
{
    public partial class testMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7f56ebf1-194e-4472-aa59-be7c6b8daa3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "73b5dfe4-d020-42a1-9896-e49acf7a6e81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "328a65f0-70c1-434f-a569-4f6ec9cfeae2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "cb8c0cdb-5460-4a2c-a6f1-8ae1ff4df610");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2413d584-6c71-4ad4-99ea-86713bf99421", "AQAAAAEAACcQAAAAEF+ZgPzlIf+zmjfkuxPjBmuFWvwJjd+d0a+4/ccKUbmmfyyzproddTAnrDAoOnNJRA==", "778aecac-eba0-437a-9a78-f659cb65e351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a122177-6eeb-4dda-8075-1e4c3a884cc5", "AQAAAAEAACcQAAAAEB1/4oNaBwHjuJSvFP9D9r9NIimp/YHcYpZnrq2Zi6dm5IGjaqV2qmxKgmlLD/UJaA==", "3b8778f9-14de-4f4d-872d-85358767e0f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1bca2f98-7e19-4522-9603-e4134ce92a1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "66092c63-b394-45f5-8ec4-cf44fdef7b09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "d8f7a8a5-4141-44c8-942d-3b9ae6a497cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "df08ce0d-7a13-4b37-81ea-92a3ab141be3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9e5444a-08c9-4d0d-ae7a-d6486e347799", "AQAAAAEAACcQAAAAEOfwlbpwZCRjThDAN5mxUHvyq9VbVF1gMJ/Q+YCbxD1UYsGpliN6qXexQkIe7gUC5Q==", "535ae0e0-d123-4057-b1b2-85105d0fd8c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af886725-8572-4e9b-a14f-ddfc020c54b9", "AQAAAAEAACcQAAAAEGbjRXRUuUuefdNvhnG7cw3tMMu2QengDt3fph0oC0su+C8qVvYciYmLU/a5L7CiTQ==", "f3f8028a-c3c4-4ce1-8ac1-da926fb90cc7" });
        }
    }
}
