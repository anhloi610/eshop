using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appconfigs",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appconfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Catergories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortOrder = table.Column<int>(nullable: false),
                    IsShowOnHome = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catergories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    Message = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 11, 28, 1, 56, 42, 303, DateTimeKind.Local).AddTicks(7121)),
                    UserId = table.Column<Guid>(nullable: false),
                    ShipName = table.Column<string>(maxLength: 200, nullable: false),
                    ShipAddress = table.Column<string>(maxLength: 200, nullable: false),
                    ShipEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ShipPhoneNumber = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false, defaultValue: 0),
                    Viewcount = table.Column<int>(nullable: false, defaultValue: 0),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SeoAlias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    ApplyForAll = table.Column<bool>(nullable: false),
                    DiscountPercent = table.Column<int>(nullable: true),
                    DiscountAmount = table.Column<decimal>(nullable: true),
                    ProductIds = table.Column<string>(nullable: true),
                    ProductCategoryIds = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ExternalTransactionId = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    Result = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Provider = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTranslations_Catergories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catergories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderInOrderdetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInOrderdetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderInOrderdetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderInOrderdetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCatergory",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCatergory", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCatergory_Catergories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catergories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCatergory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Details = table.Column<string>(maxLength: 500, nullable: true),
                    SeoDescription = table.Column<string>(nullable: true),
                    SeoTitle = table.Column<string>(nullable: true),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false),
                    LanguageId = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appconfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "THIS IS HOME PAGE OF SOLUTION" },
                    { "HomeDescription", "THIS IS DESCRIPTION  OF SOLUTION" },
                    { "HomeKeyWord", "THIS IS KEYWORD  OF SOLUTION" }
                });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder" },
                values: new object[,]
                {
                    { 1, true, null, 1 },
                    { 2, true, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "DateCreated", "OriginalPrice", "Price", "SeoAlias" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 28, 1, 56, 42, 311, DateTimeKind.Local).AddTicks(8147), 100000m, 200000m, null },
                    { 2, new DateTime(2022, 11, 28, 1, 56, 42, 311, DateTimeKind.Local).AddTicks(9030), 100000m, 200000m, null }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, "vi-VN", "Áo Nam sơ mi CPBAOLAM", "Áo Nam sơ mi CPBAOLAM", "Áo Nam sơ mi CPBAOLAM", "Áo Nam sơ mi CPBAOLAM" },
                    { 3, 2, "vi-VN", "Áo Nữ sơ mi CPBAOLAM", "Áo Nữ sơ mi CPBAOLAM", "Áo Nữ sơ mi CPBAOLAM", "Áo Nữ sơ mi CPBAOLAM" },
                    { 2, 1, "en-US", "Men Shirt ", "", "The Shirt for the man", "" },
                    { 4, 2, "en-US", "Women of Shirt ", "women-shirt", "The Shirt for the women", "women-shirt" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCatergory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, "...", "Mô tả sản phẩm", "vi-VN", "Áo Nam", 1, "", "Áo thời trang Nam", "Sản phẩm áo thời trang nam" },
                    { 2, "...", "Description for the products", "en-US", "Men Shirt", 1, "", "The Shirt for the man", "The shirt for the man" },
                    { 3, null, null, "vi-VN", "Áo Nữ sơ mi CPBAOLAM", 2, "Áo Nữ sơ mi CPBAOLAM", "Áo Nữ sơ mi CPBAOLAM", "Áo Nữ sơ mi CPBAOLAM" },
                    { 4, null, null, "en-US", "Women of Shirt ", 2, "women-shirt", "The Shirt for the women", "women-shirt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_CategoryId",
                table: "CategoryTranslations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInOrderdetails_ProductId",
                table: "OrderInOrderdetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCatergory_ProductId",
                table: "ProductInCatergory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_LanguageId",
                table: "ProductTranslations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductId",
                table: "ProductTranslations",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appconfigs");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CategoryTranslations");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "OrderInOrderdetails");

            migrationBuilder.DropTable(
                name: "ProductInCatergory");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Catergories");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
