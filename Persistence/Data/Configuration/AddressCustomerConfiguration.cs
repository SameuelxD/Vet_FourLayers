using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class AddressCustomerConfiguration : IEntityTypeConfiguration<AddressCustomer>
    {
        public void Configure(EntityTypeBuilder<AddressCustomer> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");
            builder.Property(e => e.RouteType)
                            .IsRequired()
                            .HasMaxLength(20)
                            .HasColumnType("string")
                            .HasColumnName("RouteType");
            
            builder.Property(e => e.PriNumber)
                            .IsRequired()
                            .HasColumnType("int")
                            .HasColumnName("PriNumber");

            builder.Property(e => e.Letter)
                            .IsRequired()
                            .HasMaxLength(1)
                            .HasColumnType("string")
                            .HasColumnName("Letter");
            builder.Property(e => e.Bis)
                            .IsRequired()
                            .HasMaxLength(1)
                            .HasColumnType("string")
                            .HasColumnName("Bis");
            builder.Property(e => e.SecLetter)
                            .IsRequired()
                            .HasMaxLength(1)
                            .HasColumnType("string")
                            .HasColumnName("SecLetter");

            builder.Property(e => e.Cardinal)
                            .IsRequired()
                            .HasMaxLength(50)
                            .HasColumnType("string")
                            .HasColumnName("Cardinal");            
        }
    }
}