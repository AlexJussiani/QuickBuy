using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
     public class QuickBuyContexto: DbContext
     {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Produto> produtos { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<ItemPedido> itensPedidos { get; set; }
        public DbSet<FormaPagamento> formaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioCOnfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoCOnfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
