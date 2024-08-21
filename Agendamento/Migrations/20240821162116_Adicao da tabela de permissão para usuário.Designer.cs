﻿// <auto-generated />
using System;
using Agendamento.Services.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Agendamento.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240821162116_Adicao da tabela de permissão para usuário")]
    partial class Adicaodatabeladepermissãoparausuário
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.AgendarServico", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("timestamp");

                    b.Property<Guid>("IdMecanico")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdServico")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uuid");

                    b.HasKey("objID");

                    b.HasIndex("IdMecanico");

                    b.HasIndex("IdServico");

                    b.HasIndex("IdUsuario");

                    b.ToTable("AgendarServico");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Categoria", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("descricao")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("objID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("cpf_cnpj")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("nome")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("tipo")
                        .HasColumnType("boolean");

                    b.HasKey("objID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.ClienteVeiculo", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdVeiculo")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ServicoobjID")
                        .HasColumnType("uuid");

                    b.Property<string>("placa_veiculo")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("objID");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdVeiculo");

                    b.HasIndex("ServicoobjID");

                    b.ToTable("ClienteVeiculo");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Contato", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uuid");

                    b.Property<string>("celular")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("telefone")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("objID");

                    b.HasIndex("IdCliente");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Cor", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("descricao")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("objID");

                    b.HasIndex("descricao")
                        .IsUnique();

                    b.ToTable("Cor");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Endereco", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uuid");

                    b.Property<string>("bairro")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("cep")
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("logradouro")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.HasKey("objID");

                    b.HasIndex("IdCliente");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Especialidade", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("descricao")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("objID");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Marca", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("fabricante")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("objID");

                    b.HasIndex("fabricante")
                        .IsUnique();

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Mecanico", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdEspecialidade")
                        .HasColumnType("uuid");

                    b.Property<string>("nome")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("objID");

                    b.HasIndex("IdEspecialidade");

                    b.ToTable("Mecanico");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Modelo", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("descricao")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("objID");

                    b.HasIndex("descricao")
                        .IsUnique();

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Permissao", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("display")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("elemento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("objID");

                    b.HasIndex("display")
                        .IsUnique();

                    b.HasIndex("elemento")
                        .IsUnique();

                    b.ToTable("Permissao");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Servico", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCategoria")
                        .HasColumnType("uuid");

                    b.Property<decimal>("custo")
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("tempo")
                        .HasColumnType("text");

                    b.HasKey("objID");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("acesso")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("objID");

                    b.HasIndex("acesso")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.UsuarioPermissao", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdPermissao")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uuid");

                    b.Property<Guid>("permissaoobjID")
                        .HasColumnType("uuid");

                    b.HasKey("objID");

                    b.HasIndex("IdPermissao");

                    b.HasIndex("permissaoobjID");

                    b.ToTable("UsuarioPermissao");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Veiculo", b =>
                {
                    b.Property<Guid>("objID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdCor")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdMArca")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdModelo")
                        .HasColumnType("uuid");

                    b.Property<string>("ano")
                        .HasColumnType("text");

                    b.HasKey("objID");

                    b.HasIndex("IdCor");

                    b.HasIndex("IdMArca");

                    b.HasIndex("IdModelo");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.AgendarServico", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Mecanico", "Mecanicos")
                        .WithMany("AgendarServicos")
                        .HasForeignKey("IdMecanico")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Servico", "Servicos")
                        .WithMany("AgendarServicos")
                        .HasForeignKey("IdServico")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Usuario", "Usuarios")
                        .WithMany("AgendarServicos")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Mecanicos");

                    b.Navigation("Servicos");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.ClienteVeiculo", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Cliente", "Clientes")
                        .WithMany("ClienteVeiculos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Veiculo", "Veiculos")
                        .WithMany("ClienteVeiculos")
                        .HasForeignKey("IdVeiculo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Servico", null)
                        .WithMany("ClienteVeiculos")
                        .HasForeignKey("ServicoobjID");

                    b.Navigation("Clientes");

                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Contato", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Contatos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Mecanico", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Especialidade", "Especialidade")
                        .WithMany("Mecanicos")
                        .HasForeignKey("IdEspecialidade")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Especialidade");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Servico", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Servicos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.UsuarioPermissao", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Usuario", "usuario")
                        .WithMany("UsuarioPermissao")
                        .HasForeignKey("IdPermissao")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Permissao", "permissao")
                        .WithMany("UsuarioPermissao")
                        .HasForeignKey("permissaoobjID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permissao");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Veiculo", b =>
                {
                    b.HasOne("Agendamento.Services.Domain.Entities.Cor", "Cor")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdCor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Marca", "Marca")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdMArca")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Agendamento.Services.Domain.Entities.Modelo", "Modelo")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdModelo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cor");

                    b.Navigation("Marca");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("ClienteVeiculos");

                    b.Navigation("Contatos");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Cor", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Especialidade", b =>
                {
                    b.Navigation("Mecanicos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Marca", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Mecanico", b =>
                {
                    b.Navigation("AgendarServicos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Modelo", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Permissao", b =>
                {
                    b.Navigation("UsuarioPermissao");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Servico", b =>
                {
                    b.Navigation("AgendarServicos");

                    b.Navigation("ClienteVeiculos");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("AgendarServicos");

                    b.Navigation("UsuarioPermissao");
                });

            modelBuilder.Entity("Agendamento.Services.Domain.Entities.Veiculo", b =>
                {
                    b.Navigation("ClienteVeiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
