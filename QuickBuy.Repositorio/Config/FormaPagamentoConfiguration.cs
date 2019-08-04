using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.id);

            builder
                .Property(f => f.nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(f => f.nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
