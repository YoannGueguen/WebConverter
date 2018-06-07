using DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Mapping
{
    internal class ConverterMapping : IEntityTypeConfiguration<Converter>
    {
        public void Configure(EntityTypeBuilder<Converter> builder)
        {
            builder.HasKey(c => c.ConvertId)
                .HasName("ConvertId");

            builder.Property(c => c.ConvertId)
                .UseSqlServerIdentityColumn();

        }
    }
}
