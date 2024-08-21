using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agendamento.Migrations
{
    public partial class GenerateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    tipo = table.Column<bool>(type: "boolean", nullable: false),
                    cpf_cnpj = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    descricao = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    fabricante = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    senha = table.Column<string>(type: "text", nullable: true),
                    acesso = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.objID);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdCategoria = table.Column<Guid>(type: "uuid", nullable: false),
                    custo = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    tempo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.objID);
                    table.ForeignKey(
                        name: "FK_Servico_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    telefone = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    celular = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    email = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.objID);
                    table.ForeignKey(
                        name: "FK_Contato_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    numero = table.Column<string>(type: "text", nullable: true),
                    logradouro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    bairro = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cep = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.objID);
                    table.ForeignKey(
                        name: "FK_Endereco_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mecanico",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdEspecialidade = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanico", x => x.objID);
                    table.ForeignKey(
                        name: "FK_Mecanico_Especialidade_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    ano = table.Column<string>(type: "text", nullable: true),
                    CorobjID = table.Column<Guid>(type: "uuid", nullable: false),
                    ModeloobjID = table.Column<Guid>(type: "uuid", nullable: false),
                    MarcaobjID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.objID);
                    table.ForeignKey(
                        name: "FK_Veiculo_Cor_CorobjID",
                        column: x => x.CorobjID,
                        principalTable: "Cor",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculo_Marca_MarcaobjID",
                        column: x => x.MarcaobjID,
                        principalTable: "Marca",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Veiculo_Modelo_ModeloobjID",
                        column: x => x.ModeloobjID,
                        principalTable: "Modelo",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgendarServico",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdServico = table.Column<Guid>(type: "uuid", nullable: false),
                    IdMecanico = table.Column<Guid>(type: "uuid", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uuid", nullable: false),
                    DataAgendamento = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendarServico", x => x.objID);
                    table.ForeignKey(
                        name: "FK_AgendarServico_Mecanico_IdMecanico",
                        column: x => x.IdMecanico,
                        principalTable: "Mecanico",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgendarServico_Servico_IdServico",
                        column: x => x.IdServico,
                        principalTable: "Servico",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgendarServico_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteVeiculo",
                columns: table => new
                {
                    objID = table.Column<Guid>(type: "uuid", nullable: false),
                    IdCliente = table.Column<Guid>(type: "uuid", nullable: false),
                    IdVeiculo = table.Column<Guid>(type: "uuid", nullable: false),
                    placa_veiculo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ServicoobjID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteVeiculo", x => x.objID);
                    table.ForeignKey(
                        name: "FK_ClienteVeiculo_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteVeiculo_Servico_ServicoobjID",
                        column: x => x.ServicoobjID,
                        principalTable: "Servico",
                        principalColumn: "objID");
                    table.ForeignKey(
                        name: "FK_ClienteVeiculo_Veiculo_IdVeiculo",
                        column: x => x.IdVeiculo,
                        principalTable: "Veiculo",
                        principalColumn: "objID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendarServico_IdMecanico",
                table: "AgendarServico",
                column: "IdMecanico");

            migrationBuilder.CreateIndex(
                name: "IX_AgendarServico_IdServico",
                table: "AgendarServico",
                column: "IdServico");

            migrationBuilder.CreateIndex(
                name: "IX_AgendarServico_IdUsuario",
                table: "AgendarServico",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteVeiculo_IdCliente",
                table: "ClienteVeiculo",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteVeiculo_IdVeiculo",
                table: "ClienteVeiculo",
                column: "IdVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteVeiculo_ServicoobjID",
                table: "ClienteVeiculo",
                column: "ServicoobjID");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_IdCliente",
                table: "Contato",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Cor_descricao",
                table: "Cor",
                column: "descricao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdCliente",
                table: "Endereco",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_fabricante",
                table: "Marca",
                column: "fabricante",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mecanico_IdEspecialidade",
                table: "Mecanico",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_descricao",
                table: "Modelo",
                column: "descricao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servico_IdCategoria",
                table: "Servico",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_acesso",
                table: "Usuario",
                column: "acesso",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_CorobjID",
                table: "Veiculo",
                column: "CorobjID");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_MarcaobjID",
                table: "Veiculo",
                column: "MarcaobjID");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_ModeloobjID",
                table: "Veiculo",
                column: "ModeloobjID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendarServico");

            migrationBuilder.DropTable(
                name: "ClienteVeiculo");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Mecanico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Modelo");
        }
    }
}
