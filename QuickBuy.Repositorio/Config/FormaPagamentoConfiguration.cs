using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    class FormaPagamentoConfiguration : IEntityTypeConfiguration<UsuaFormaPagamento>
    {
        public void Configure(EntityTypeBuilder<UsuaFormaPagamento> builder)
        {
            throw new NotImplementedException();
        }
    }
}
