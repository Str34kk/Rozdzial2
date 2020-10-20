using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Rozdzial2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Bill> Bill { get; set; }
    }

    public class ApplicationUser
    {
        public bool IdPaid { get; set; }
        public IEnumerable<Bill> Bills { get; set; }
        public IEnumerable<Information> Informations { get; set; }
    }

    public class Bill
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string January { get; set; }
        public string February { get; set; }
        public string March { get; set; }
        public string April { get; set; }
        public string May { get; set; }
        public string June { get; set; }
        public string July { get; set; }
        public string August { get; set; }
        public string September { get; set; }
        public string October { get; set; }
        public string November { get; set; }
        public string December { get; set; }
        public ApplicationUser User { get; set; }
    }

    public class Information
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public ApplicationUser User { get; set; }
    }


}
