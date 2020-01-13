﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Migrations
{
    [DbContext(typeof(QuickBuyContexto))]
    [Migration("20200111170136_AlterarTamanhoPrecoProduto")]
    partial class AlterarTamanhoPrecoProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Pedidoid");

                    b.Property<int>("produtoId");

                    b.Property<int>("quantidade");

                    b.HasKey("id");

                    b.HasIndex("Pedidoid");

                    b.ToTable("itensPedidos");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("dataPedido");

                    b.Property<DateTime>("dataPrecisaoEntrega");

                    b.Property<string>("enderecoCompleto")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("formaPagamentoId");

                    b.Property<int>("numeroEndereco");

                    b.Property<int>("usuarioId");

                    b.HasKey("id");

                    b.HasIndex("formaPagamentoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("nomeArquivo");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimals(19,4)");

                    b.HasKey("id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("sobreNome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("QuickBuy.Dominio.ObjetoDeValor.FormaPagamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descricao");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("id");

                    b.ToTable("formaPagamento");

                    b.HasData(
                        new
                        {
                            id = 1,
                            descricao = "Forma de Pagamento Boleto",
                            nome = "Boleto"
                        },
                        new
                        {
                            id = 2,
                            descricao = "Forma de Pagamento Cartão de Crédito",
                            nome = "Cartão de Crédito"
                        },
                        new
                        {
                            id = 3,
                            descricao = "Forma de Pagamento Depósito",
                            nome = "Depósito"
                        });
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.ItemPedido", b =>
                {
                    b.HasOne("QuickBuy.Dominio.Entidades.Pedido")
                        .WithMany("itensPedidos")
                        .HasForeignKey("Pedidoid");
                });

            modelBuilder.Entity("QuickBuy.Dominio.Entidades.Pedido", b =>
                {
                    b.HasOne("QuickBuy.Dominio.ObjetoDeValor.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("formaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Dominio.Entidades.Usuario", "usuario")
                        .WithMany("pedidos")
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
