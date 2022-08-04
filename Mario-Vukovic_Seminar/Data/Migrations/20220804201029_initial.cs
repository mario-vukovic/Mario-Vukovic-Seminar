using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mario_Vukovic_Seminar.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FileStorage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhysicalPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileStorage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "19fd3204-3852-4f84-bfde-5066d96b16a1", "Admin", "ADMIN" },
                    { "2", "d83ad035-5423-4588-a21b-0e6cd6c039e1", "BasicUser", "BASICUSER" },
                    { "3", "753252a1-0fd5-4c2d-933d-cdc6dff26b12", "Employee", "EMPLOYEE" },
                    { "4", "f666b37a-b4c5-43e1-9957-37f4a1ee5417", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "48bf90fa-dff7-432f-890a-3ba4b5fee5ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", true, "Admin", null, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", null, "AQAAAAEAACcQAAAAEJJzWPbBtrGl5/xx/AHUjPOVyP1NHiAWhjwTjVAcKG24IC+UaXRIs2/v/15cMktjwg==", null, false, "d81cc8ad-32ba-4dbf-b376-0b094363acaf", false, "admin@admin.com" },
                    { "2", 0, "5c3ae266-7616-432f-b4e6-6ec1fb8d32fa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", true, "BasicUser", null, false, null, "USER@USER.COM", "USER@USER.COM", null, "AQAAAAEAACcQAAAAEJecbfwIHO2TxdeqKQX93J0h6/qDNzuTgE7PjgTRC+z1fZj8CtlIfQHDNrPDrnFtAQ==", null, false, "78fe48c0-26ae-4c5d-b1fc-edd7a0b0d6e4", false, "user@user.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Created", "Description", "ProductId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shoes best worn during the winter to keep you warm", 0, "Winter shoes" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shoes best worn during the summer, although who am I to tell you what to do, if you want to be cold; You be cold", 0, "Summer shoes" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "For some reason people thing these look good and won't stop wearing them. Fashion, wow.", 0, "Ugly shoes" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I like black...that's it", 0, "Shoes I like" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Damn, those are big", 0, "Shoes your mom wears" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Created", "Description", "Name", "Price", "ProductCategoryId", "ProductImgUrl", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown, made of real deer skin, used to cut down tree the picture was taken on", "Wonderful Winter Boots", 320m, 1, "https://www.hotter.com/blog/wp-content/uploads/2016/11/RUBY_SL-RT-300x200.jpg", 19m },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snow not included", "Rain and winter Boots", 120m, 1, "https://capitaliron.ca/wp-content/uploads/2021/02/Boots-snow-300x200.jpeg", 7m },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I have no idea what this is, but it sure is stylish", "Barefoot Winter Shoes", 560m, 1, "https://lh4.googleusercontent.com/uKiSMORQwKFcFD6mmxTLQKOJYzDnfa1SI-t4kUkZU0ctklvkYovubYe8YlXhmBLCYwHaM0VBvTuD2j68ODBCanhIY_nJteVdkPl6CtfVV2QQUvTf3wa4nukJsuB0NHrQWezwFjRI", 1m },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved by the Saviour himself", "Brown Summer Sandals", 540m, 2, "https://i.ebayimg.com/thumbs/images/g/brcAAOSw9k5XQKi5/s-l300.jpg", 67m },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It's free, just take your shoes off", "Bare feet", 0m, 2, "https://images.squarespace-cdn.com/content/v1/5b6c9532cc8fed0c2edbc0cc/1562095212390-Y0VENOYPZFPWLUY24FDA/adult-bare-feet-barefoot-1249546.jpg", 999m },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is the first thing that appears when I google for 'summer shoes', you tell me", "Some sort of white shoes", 90m, 2, "https://www.shoes.hr/site/assets/files/21725/carl-perf_mephisto_white_leather_shoe-sneaker_for_summer_for_men_perforated_5136957_3.300x0.jpg", 7m },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diarrhea coloured", "Timberlands", 117m, 3, "https://i.ebayimg.com/thumbs/images/g/GwQAAOSwpOdi4qjF/s-l300.jpg", 35m },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Not actually made of crocodiles, surprisingly comfy", "Crocs", 220m, 3, "https://www.abcrafty.com/wp-content/uploads/2021/10/tie-dye-crocs_20-300x200.jpg", 76m },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pretty damn uggly", "Ugg Boots", 780m, 3, "https://cdn.shopify.com/s/files/1/1327/1087/products/ugg-boots-ta-cadence-women-short-ugg-boots-inner-zipper-1_300x.jpg?v=1621910505", 12m },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UltraBOOST, what does that even MEAN", "Addidas black", 870m, 4, "https://mangosneakers.com/wp-content/uploads/2021/01/f5ffefac-300x200.jpg", 51m },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Told you it's all black", "Allstar Converse Black", 170m, 4, "https://repsneakers.net/wp-content/uploads/2021/01/bc31d3c0-300x200.jpg", 14m },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I don't really like anything else", "Nothing", 300m, 4, "https://conejovet.com/wp-content/uploads/2017/10/Blank-300x200-300x300.jpg", 42m },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perfect for the office Christmas party", "Pink...shoes", 310m, 5, "https://static.vecteezy.com/system/resources/thumbnails/008/623/000/small/pair-of-female-natural-leather-shoe-hand-made-beige-medium-heel-shoes-decorated-with-wooden-element-women-s-shoes-concept-leather-high-quality-and-exclusive-footwear-photo.jpg", 22m },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I've never actually seen anyone wear these", "Pink Nike Sneakers", 30m, 5, "https://i.pinimg.com/564x/d3/f0/fe/d3f0fe393d619f2d87933afbf5623038.jpg", 57m },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I used to get my ass whopped by these", "IKona Sw005 Fawn", 420m, 5, "https://shoeslylo.pk/wp-content/uploads/2019/08/Buy-Beautiful-IKona-Sw005-Fawn-Color-Shoes-300x200.jpeg", 69m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileStorage");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");
        }
    }
}
