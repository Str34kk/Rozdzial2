using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rozdzial2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.Models.ModelConfiguration
{
    public class InformationsConfiguration : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Content).IsRequired();
            builder.HasOne<ApplicationUser>(a => a.User)
                .WithMany(b => b.Informations)
                .HasForeignKey(b => b.UserId);
        }
    }
}
