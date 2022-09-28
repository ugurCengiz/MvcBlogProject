using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig_Natification_add_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Natifications",
                columns: table => new
                {
                    NatificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NatificationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatificationTypeSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatificationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatificationStatus = table.Column<bool>(type: "bit", nullable: false),
                    NatificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Natifications", x => x.NatificationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Natifications");
        }
    }
}
