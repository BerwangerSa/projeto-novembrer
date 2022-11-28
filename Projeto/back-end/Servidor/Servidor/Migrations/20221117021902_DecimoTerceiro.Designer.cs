﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Servidor.DataAcess;

#nullable disable

namespace Servidor.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221117021902_DecimoTerceiro")]
    partial class DecimoTerceiro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Servidor.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Nota")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("Servidor.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Servidor.Models.Questionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RespostaId")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.Property<int?>("VendaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RespostaId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VendaId");

                    b.ToTable("Questionamentos");
                });

            modelBuilder.Entity("Servidor.Models.Resposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Imagem")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Respostas");
                });

            modelBuilder.Entity("Servidor.Models.StatusVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StatusVendas");
                });

            modelBuilder.Entity("Servidor.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Servidor.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AvaliacaoId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer");

                    b.Property<int?>("CompradorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataCancelamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataExpiracao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LocalVenda")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Preco")
                        .HasColumnType("double precision");

                    b.Property<int>("StatusVendaId")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VendedorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("CompradorId");

                    b.HasIndex("StatusVendaId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Servidor.Models.Avaliacao", b =>
                {
                    b.HasOne("Servidor.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Servidor.Models.Questionamento", b =>
                {
                    b.HasOne("Servidor.Models.Resposta", "Resposta")
                        .WithMany()
                        .HasForeignKey("RespostaId");

                    b.HasOne("Servidor.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Servidor.Models.Venda", null)
                        .WithMany("Questionamentos")
                        .HasForeignKey("VendaId");

                    b.Navigation("Resposta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Servidor.Models.Venda", b =>
                {
                    b.HasOne("Servidor.Models.Avaliacao", "Avaliacao")
                        .WithMany()
                        .HasForeignKey("AvaliacaoId");

                    b.HasOne("Servidor.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Servidor.Models.Usuario", "Comprador")
                        .WithMany()
                        .HasForeignKey("CompradorId");

                    b.HasOne("Servidor.Models.StatusVenda", "StatusVenda")
                        .WithMany()
                        .HasForeignKey("StatusVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Servidor.Models.Usuario", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avaliacao");

                    b.Navigation("Categoria");

                    b.Navigation("Comprador");

                    b.Navigation("StatusVenda");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("Servidor.Models.Usuario", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Servidor.Models.Venda", b =>
                {
                    b.Navigation("Questionamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
