using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.CustomModels;
using ApplicationCore.Models;
using Infrastructure.Data.CustomModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CustomModelContext: DbContext
    {
        public CustomModelContext(DbContextOptions<CustomModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CurrencyPosition> CurrencyPositions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:DefaultSchema", "POSKEEPER");

            modelBuilder.ApplyConfiguration(new CurrencyPositionConfiguration());
            

        }
    }
}
