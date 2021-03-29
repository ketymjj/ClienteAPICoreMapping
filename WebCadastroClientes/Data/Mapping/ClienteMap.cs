using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCadastroClientes.Models;

namespace WebCadastroClientes.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasMaxLength(100).IsRequired();

            builder.Property(x => x.Sobrenome)
                .HasMaxLength(30).IsRequired();

            builder.Property(x => x.Telefone)
                .HasMaxLength(15).IsRequired();

            builder.Property(x => x.CPF)
                .HasMaxLength(15).IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(100).IsRequired();

            builder.Property(x => x.Nacionalidade)
               .HasMaxLength(50).IsRequired();

            builder.Property(x => x.CEP)
                .HasMaxLength(8).IsRequired();

            builder.Property(x => x.Cidade)
               .HasMaxLength(30).IsRequired();

            builder.Property(x => x.Estado)
               .HasMaxLength(2).IsRequired();


            builder.Property(x => x.Logradouro)
              .HasMaxLength(100).IsRequired();

            builder.ToTable("Cliente");

        }
    }
}
