using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mario_Vukovic_Seminar.Data.Migrations
{
    public partial class roleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5c3219be-c6a6-4f2e-8045-5b4c30597c68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7e87acdd-3b1d-43dd-a8f7-431abcd22388");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "773f7174-b358-4d95-9344-7860b5f4e2eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "59375f54-25f9-4ae2-9b01-2574d8e910d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97fa820-c201-4537-9904-e1eee3bb6c41", "AQAAAAEAACcQAAAAEOtbdXoO2gad8LpP7ZlQ3KtnrEDn2xgnlDmr942JoBmuuH6LRvrpsmJDNCGYlTryFg==", "f6bcc52d-98dc-44a9-8665-4e2ffe48b504" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce7db29-c574-48a0-a0b0-251b58a65e61", "AQAAAAEAACcQAAAAEE4JSarENvZzLOsaVIog/qcnlzKHh2tQuR8hphnRIyeJhjeSOommmSlL+JP/lHEFAA==", "5166d200-2514-433f-a394-d3d9b89e6572" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

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
