using controle.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace controle.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }

        public DbSet<controle.Models.TipoUsuario> TipoUsuario { get; set; }

        public DbSet<controle.Models.AcessoTipoUsuario> AcessoTipoUsuario { get; set; }

        public DbSet<controle.Models.PerfilUsuario> PerfilUsuario { get; set; }

        public DbSet<ApplicationUser> Usuario { get; set; }
    }
}
