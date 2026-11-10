using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lemondromede.Migrations
{
    /// <inheritdoc />
    public partial class Seeliminoinventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    IdInventario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    FechaActual = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.IdInventario);
                    table.ForeignKey(
                        name: "FK_Inventarios_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_IdProducto",
                table: "Inventarios",
                column: "IdProducto");
        }
    }
}
