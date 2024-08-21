using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agendamento.Migrations
{
    public partial class Adicaodatabeladepermissãoparausuário : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    display = table.Column<string>(type: "text", nullable: false),
                    elemento = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPermissao",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uuid", nullable: false),
                    IdPermissao = table.Column<Guid>(type: "uuid", nullable: false),
                    permissaoobjID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermissao", x => x.objID);
                    table.ForeignKey(
                        name: "FK_UsuarioPermissao_Permissao_permissaoobjID",
                        column: x => x.permissaoobjID,
                        principalTable: "Permissao",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPermissao_Usuario_IdPermissao",
                        column: x => x.IdPermissao,
                        principalTable: "Usuario",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_display",
                table: "Permissao",
                column: "display",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_elemento",
                table: "Permissao",
                column: "elemento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermissao_IdPermissao",
                table: "UsuarioPermissao",
                column: "IdPermissao");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermissao_permissaoobjID",
                table: "UsuarioPermissao",
                column: "permissaoobjID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuarioPermissao");

            migrationBuilder.DropTable(
                name: "Permissao");
        }
    }
}
