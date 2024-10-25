using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Price_Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book_Price",
                columns: table => new
                {
                    Partner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientName = table.Column<string>(name: "Client Name", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    POLICYNUMBER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductProvider = table.Column<string>(name: "Product Provider", type: "nvarchar(70)", maxLength: 70, nullable: true),
                    AdjustedRevenue = table.Column<decimal>(name: "Adjusted Revenue", type: "decimal(18,2)", nullable: true),
                    AdjustedAssetValue = table.Column<decimal>(name: "Adjusted Asset Value", type: "decimal(29,3)", nullable: true),
                    BookPrice = table.Column<decimal>(name: "Book Price", type: "decimal(10,2)", nullable: true),
                    STATEMENTDATE = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Price");
        }
    }
}
