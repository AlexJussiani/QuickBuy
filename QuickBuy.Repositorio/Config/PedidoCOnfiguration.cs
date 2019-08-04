using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.id);

            builder
                .Property(p => p.dataPedido)
                .IsRequired();

            builder
                .Property(p => p.dataPrecisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(p => p.cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.enderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.numeroEndereco)
                .IsRequired();
        }
    }
}
