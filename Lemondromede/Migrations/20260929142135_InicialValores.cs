using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lemondromede.Migrations
{
    /// <inheritdoc />
    public partial class InicialValores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categoria_CategoriasIdCategoria",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CategoriasIdCategoria",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameColumn(
                name: "CategoriasIdCategoria",
                table: "Productos",
                newName: "Stock");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "IdCategoria");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "IdCategoria", "Descripcion", "NombreCategoria" },
                values: new object[,]
                {
                    { 1, "Aromas florales", "Florales" },
                    { 2, "Aromas dulces", "Dulces" },
                    { 3, "Aromas cítricos", "Cítricos" },
                    { 4, "Aromas amaderados", "Amaderados" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Aroma", "Estado", "IdCategoria", "Nombre", "Precio", "Stock", "Tamano", "UsuarioIdUsuario" },
                values: new object[,]
                {
                    { 1, "toques de agua", true, 1, "Une touche deau", 143.94m, 19, "15.2cm", null },
                    { 2, "olor a venas dulces", true, 2, "Cœur rouge", 133.22m, 14, "13.7cm", null }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Aroma", "IdCategoria", "Nombre", "Precio", "Stock", "Tamano", "UsuarioIdUsuario" },
                values: new object[,]
                {
                    { 3, "aroma a dulce", 3, "Dague jaune", 167.94m, 0, "18.1cm", null },
                    { 4, "aroma a realeza real", 4, "Couronne royale", 2490.61m, 0, "15.6cm", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos",
                column: "IdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_IdCategoria",
                table: "Productos",
                column: "IdCategoria",
                principalTable: "Categorias",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_IdCategoria",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_IdCategoria",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "IdCategoria",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Productos",
                newName: "CategoriasIdCategoria");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoriasIdCategoria",
                table: "Productos",
                column: "CategoriasIdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categoria_CategoriasIdCategoria",
                table: "Productos",
                column: "CategoriasIdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
