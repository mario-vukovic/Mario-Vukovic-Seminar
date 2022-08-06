using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mario_Vukovic_Seminar.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "19fd3204-3852-4f84-bfde-5066d96b16a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d83ad035-5423-4588-a21b-0e6cd6c039e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "753252a1-0fd5-4c2d-933d-cdc6dff26b12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f666b37a-b4c5-43e1-9957-37f4a1ee5417");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48bf90fa-dff7-432f-890a-3ba4b5fee5ec", "AQAAAAEAACcQAAAAEJJzWPbBtrGl5/xx/AHUjPOVyP1NHiAWhjwTjVAcKG24IC+UaXRIs2/v/15cMktjwg==", "d81cc8ad-32ba-4dbf-b376-0b094363acaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c3ae266-7616-432f-b4e6-6ec1fb8d32fa", "AQAAAAEAACcQAAAAEJecbfwIHO2TxdeqKQX93J0h6/qDNzuTgE7PjgTRC+z1fZj8CtlIfQHDNrPDrnFtAQ==", "78fe48c0-26ae-4c5d-b1fc-edd7a0b0d6e4" });
        }
    }
}
