using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class OfferProductConfiguration : IEntityTypeConfiguration<OfferProduct>
{
    public void Configure(EntityTypeBuilder<OfferProduct> builder)
    {
       builder.Property(x => x.Quantity).HasColumnType("decimal(18,2)");
       builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
    }
}
