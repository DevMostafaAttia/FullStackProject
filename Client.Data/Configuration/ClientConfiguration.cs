using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Client.Data
{
    class ClientConfiguration : IEntityTypeConfiguration<Client.Model.Client>
    {
        public void Configure(EntityTypeBuilder<Client.Model.Client> builder)
        {
            builder.ToTable("Client");
            builder.Property(a => a.ClientId).IsRequired();
            builder.Property(a => a.ClientName).HasMaxLength(500);
            builder.Property(a => a.ClientEmail).HasMaxLength(500);
            builder.Property(a => a.Address).HasMaxLength(500);
            builder.Property(a => a.Mobile).HasMaxLength(50);
        }
    }
}
