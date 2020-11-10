using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rozdzial2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rozdzial2.Models.ModelConfiguration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
           builder.HasKey(e => e.Id);
           builder.Property(e => e.UserName).IsRequired();
           builder.Property(e => e.Email).IsRequired();
           builder.Property(e => e.PasswordHash).IsRequired();
           builder.Property(e => e.IdPaid).IsRequired();
        }
    }
}
