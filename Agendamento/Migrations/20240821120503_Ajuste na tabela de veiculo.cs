using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agendamento.Migrations
{
    public partial class Ajustenatabeladeveiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Cor_CorobjID",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Marca_MarcaobjID",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Modelo_ModeloobjID",
                table: "Veiculo");

            migrationBuilder.RenameColumn(
                name: "ModeloobjID",
                table: "Veiculo",
                newName: "IdModelo");

            migrationBuilder.RenameColumn(
                name: "MarcaobjID",
                table: "Veiculo",
                newName: "IdMArca");

            migrationBuilder.RenameColumn(
                name: "CorobjID",
                table: "Veiculo",
                newName: "IdCor");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_ModeloobjID",
                table: "Veiculo",
                newName: "IX_Veiculo_IdModelo");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_MarcaobjID",
                table: "Veiculo",
                newName: "IX_Veiculo_IdMArca");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_CorobjID",
                table: "Veiculo",
                newName: "IX_Veiculo_IdCor");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Cor_IdCor",
                table: "Veiculo",
                column: "IdCor",
                principalTable: "Cor",
                principalColumn: "objID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Marca_IdMArca",
                table: "Veiculo",
                column: "IdMArca",
                principalTable: "Marca",
                principalColumn: "objID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Modelo_IdModelo",
                table: "Veiculo",
                column: "IdModelo",
                principalTable: "Modelo",
                principalColumn: "objID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Cor_IdCor",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Marca_IdMArca",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Modelo_IdModelo",
                table: "Veiculo");

            migrationBuilder.RenameColumn(
                name: "IdModelo",
                table: "Veiculo",
                newName: "ModeloobjID");

            migrationBuilder.RenameColumn(
                name: "IdMArca",
                table: "Veiculo",
                newName: "MarcaobjID");

            migrationBuilder.RenameColumn(
                name: "IdCor",
                table: "Veiculo",
                newName: "CorobjID");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_IdModelo",
                table: "Veiculo",
                newName: "IX_Veiculo_ModeloobjID");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_IdMArca",
                table: "Veiculo",
                newName: "IX_Veiculo_MarcaobjID");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_IdCor",
                table: "Veiculo",
                newName: "IX_Veiculo_CorobjID");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Cor_CorobjID",
                table: "Veiculo",
                column: "CorobjID",
                principalTable: "Cor",
                principalColumn: "objID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Marca_MarcaobjID",
                table: "Veiculo",
                column: "MarcaobjID",
                principalTable: "Marca",
                principalColumn: "objID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Modelo_ModeloobjID",
                table: "Veiculo",
                column: "ModeloobjID",
                principalTable: "Modelo",
                principalColumn: "objID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
