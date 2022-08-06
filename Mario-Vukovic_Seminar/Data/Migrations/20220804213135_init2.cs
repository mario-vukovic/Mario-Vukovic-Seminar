using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mario_Vukovic_Seminar.Data.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d7a4217-e9e1-4881-a033-a7f7ce7f804c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4965f1a4-d675-4b8a-a53e-d745a513d0ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "81a39c0b-6992-4f67-b41c-64ff7032a64c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "4f8941c9-93b4-4207-ad4f-0669932efc16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7beea52-394d-4528-8ccf-d8cd6d06af87", "AQAAAAEAACcQAAAAELgNz9TqsBTIstNInt92TEuo+W/5X7OOKPD1ZZMir5djpOHLs8OPCRhs0PhsuTKrug==", "174d9d22-6d19-4634-8da4-91e55a561a71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b0e1164-9616-437b-8b0c-00f85e494d63", "AQAAAAEAACcQAAAAEKcvsbIWuD1w0nmy8A+FNsb1jpAMLqYy64ojECTgMXoWIf/15nZLXYDn5USzDcnG8Q==", "57fd48fc-3a5f-4f87-9d14-1eae5503800b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "01eeceb3-4a1a-434b-8080-f8ccabfd7363");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2560bbf9-be74-4ede-9ca2-c34b2eb5a7aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fde6cca2-fe21-454b-89fb-6eb3937270af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "2a20548d-5cae-4ba3-a81a-d8baaef76088");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "631d911c-844e-4ac7-a86a-da56d6b25b1f", "AQAAAAEAACcQAAAAEK7NUM3wBJ4Va2jWbTzMtYXFjP/fTOn67/YE+mAYTtKGrFn9WVYC8VLQBl2Ky9U02Q==", "a0fc0bf5-3f02-440a-92ab-a5585d26c5c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf12a6ef-24ef-4822-90fc-eb75dd8339e4", "AQAAAAEAACcQAAAAEIXLhdDvxg8flCnEM3mG/y2oE/ermNOINIxQN776NyYzXVKOiQstPpmEIOptJFlcxA==", "8f8b3e21-4b0f-41c5-9ffe-eabed73b9aba" });
        }
    }
}
