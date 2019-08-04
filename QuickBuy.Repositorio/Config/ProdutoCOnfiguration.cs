﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoCOnfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.id);

            builder
                .Property(p => p.nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.descricao)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(p => p.preco)
                .IsRequired();
        }
    }
}
