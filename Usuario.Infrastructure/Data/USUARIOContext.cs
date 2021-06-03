using Microsoft.EntityFrameworkCore;
using Usuario.Domain.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Usuario.Infrastructure.Data
{
    public partial class USUARIOContext : DbContext
    {
        public USUARIOContext()
        {
        }

        public USUARIOContext(DbContextOptions<USUARIOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__Persona__A4788141B2F767FD");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("idPersona")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DireccionPersona)
                    .HasColumnName("direccionPersona")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.NamePersona)
                    .HasColumnName("namePersona")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

        }

    }
}
