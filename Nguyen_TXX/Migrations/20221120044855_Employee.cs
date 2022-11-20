using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenTXX.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmPloyee",
                columns: table => new
                {
                    EmPloyeeID = table.Column<string>(type: "TEXT", nullable: false),
                    EmPloyeeName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    sdt = table.Column<string>(type: "TEXT", nullable: true),
                    GioiTinh = table.Column<string>(type: "TEXT", nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmPloyee", x => x.EmPloyeeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmPloyee");
        }
    }
}
