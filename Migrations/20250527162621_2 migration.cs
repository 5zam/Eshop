using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceDay1.Migrations
{
    /// <inheritdoc />
    public partial class _2migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageURL",
                table: "products_tb");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "products_tb",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products_tb",
                newName: "Product_ID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "products_tb",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(10)",
                oldPrecision: 10,
                oldScale: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "products_tb",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "products_tb",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Category_tb",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_tb", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer_tb_",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email_address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contact_Information = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_tb_", x => x.Customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInformation_tb_",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInformation_tb_", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_PaymentInformation_tb__Customer_tb__Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer_tb_",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review_tb_",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review_tb_", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Review_tb__Customer_tb__Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer_tb_",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_tb__products_tb_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "products_tb",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_ShippingAddress_Customer_tb__Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer_tb_",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_tb_",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    Address_ID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_tb_", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_tb__Customer_tb__Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customer_tb_",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_tb__ShippingAddress_Address_ID",
                        column: x => x.Address_ID,
                        principalTable: "ShippingAddress",
                        principalColumn: "AddressID");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem_tb_",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem_tb_", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItem_tb__Order_tb__OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order_tb_",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_tb__products_tb_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "products_tb",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_tb_CategoryID",
                table: "products_tb",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_tb__Address_ID",
                table: "Order_tb_",
                column: "Address_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_tb__Customer_ID",
                table: "Order_tb_",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_tb__OrderID",
                table: "OrderItem_tb_",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_tb__Product_ID",
                table: "OrderItem_tb_",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInformation_tb__Customer_ID",
                table: "PaymentInformation_tb_",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_tb__Customer_ID",
                table: "Review_tb_",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_tb__Product_ID",
                table: "Review_tb_",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddress_Customer_ID",
                table: "ShippingAddress",
                column: "Customer_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_tb_Category_tb_CategoryID",
                table: "products_tb",
                column: "CategoryID",
                principalTable: "Category_tb",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_tb_Category_tb_CategoryID",
                table: "products_tb");

            migrationBuilder.DropTable(
                name: "Category_tb");

            migrationBuilder.DropTable(
                name: "OrderItem_tb_");

            migrationBuilder.DropTable(
                name: "PaymentInformation_tb_");

            migrationBuilder.DropTable(
                name: "Review_tb_");

            migrationBuilder.DropTable(
                name: "Order_tb_");

            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.DropTable(
                name: "Customer_tb_");

            migrationBuilder.DropIndex(
                name: "IX_products_tb_CategoryID",
                table: "products_tb");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "products_tb",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "Product_ID",
                table: "products_tb",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "products_tb",
                type: "float(10)",
                precision: 10,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "products_tb",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "products_tb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "imageURL",
                table: "products_tb",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
