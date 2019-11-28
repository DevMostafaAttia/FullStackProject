using Client.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Data
{
    class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branch");
            builder.Property(a => a.BranchId).IsRequired();
            builder.Property(a => a.BranchName).HasMaxLength(500);
            builder.Property(a => a.Location).HasMaxLength(500);
            
        }
    }
}
