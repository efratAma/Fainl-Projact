using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    LastName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    InvestmentAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Investor__3214EC07B49F5B5C", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProjactName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    NumberOfApartments = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "SQL_Latin1_General_CP1_CI_AS"),
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Projects__3214EC07022465CE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SquareMeter = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    NumberOfRooms = table.Column<double>(type: "float", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    InvesterId = table.Column<int>(type: "int", nullable: true),
                    Profit = table.Column<int>(type: "int", nullable: true),
                    ProjectNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Apartmen__3214EC070C62DEB7", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartment_ToTable",
                        column: x => x.InvesterId,
                        principalTable: "Investor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Apartment_ToTable_1",
                        column: x => x.ProjectNumber,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_InvesterId",
                table: "Apartment",
                column: "InvesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_ProjectNumber",
                table: "Apartment",
                column: "ProjectNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "Investor");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
