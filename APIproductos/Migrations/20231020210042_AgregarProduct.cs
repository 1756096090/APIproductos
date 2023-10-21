using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIproductos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Cantidad", "Descripcion", "Nombre" },
                values: new object[] { 1, 12, "Descripcion del producto1", "Producto1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1);
        }
    }
}
