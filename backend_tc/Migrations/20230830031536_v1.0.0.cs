using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_tc.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TarjetaCredito",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numTarjeta = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cvv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetaCredito", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarjetaCredito");
        }
    }
}
