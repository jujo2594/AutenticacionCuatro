using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direccion_Persona_IdPersonaFk",
                table: "Direccion");

            migrationBuilder.DropIndex(
                name: "IX_Direccion_IdPersonaFk",
                table: "Direccion");

            migrationBuilder.DropColumn(
                name: "IdPersonaFk",
                table: "Direccion");

            migrationBuilder.AddColumn<int>(
                name: "IdDireccionFk",
                table: "Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdDireccionFk",
                table: "Persona",
                column: "IdDireccionFk",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Direccion_IdDireccionFk",
                table: "Persona",
                column: "IdDireccionFk",
                principalTable: "Direccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Direccion_IdDireccionFk",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdDireccionFk",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "IdDireccionFk",
                table: "Persona");

            migrationBuilder.AddColumn<string>(
                name: "IdPersonaFk",
                table: "Direccion",
                type: "varchar(20)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_IdPersonaFk",
                table: "Direccion",
                column: "IdPersonaFk",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Direccion_Persona_IdPersonaFk",
                table: "Direccion",
                column: "IdPersonaFk",
                principalTable: "Persona",
                principalColumn: "Id");
        }
    }
}
