using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
     class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(u => u.email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.senha)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(u => u.sobreNome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(u => u.pedidos)  //Relacionamento de um para muitos
                .WithOne(p => p.usuario); //Pedido pode apenas ter um unico usuário
        }
    }
}
