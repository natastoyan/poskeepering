using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.CustomModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.CustomModelConfiguration
{
    public class CurrencyPositionConfiguration : IEntityTypeConfiguration<CurrencyPosition>
    {
        public void Configure(EntityTypeBuilder<CurrencyPosition> builder)
        {
            builder.HasKey(e => e.AccountKey);

            builder.Property(e => e.Account).HasColumnName("CACC");
            builder.Property(e => e.AccountTypeCode).HasColumnName("CACCTYPECODE");
            builder.Property(e => e.CurrencyCode).HasColumnName("CCURRCODE");
            builder.Property(e => e.AccountKey).HasColumnName("NACCKEY");
            builder.Property(e => e.Sum).HasColumnName("NSUM");
            builder.Property(e => e.Debit).HasColumnName("ndeb");
            builder.Property(e => e.Credit).HasColumnName("ncred");
            builder.Property(e => e.In).HasColumnName("NIN");
            builder.Property(e => e.Active).HasColumnName("BACTIVE");
        }
    }
}