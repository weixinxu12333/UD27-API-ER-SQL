using Microsoft.EntityFrameworkCore;
using UD27_EJ4.DataLayer.Models;

namespace UD27_EJ4.DataLayer.Context
{
    public class InvestigadoresContext : DbContext
    {
        public InvestigadoresContext(DbContextOptions<InvestigadoresContext> options)
            : base(options) { }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Investigador> Investigadores { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>(equipo =>
            {
                equipo.ToTable("Equipos");

                //Columna numSerie y Primary key
                equipo.Property(e => e.NumSerie)
                    .HasColumnName("NumSerie")
                    .HasMaxLength(4)
                    .IsRequired();
                equipo.HasKey(e => e.NumSerie);

                //Columnas y caracteristicas
                equipo.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .IsUnicode(true)
                    .HasMaxLength(100);

                equipo.HasOne(e => e.Facultad).WithMany(f => f.Equipos).HasForeignKey("facultad");
            });

            modelBuilder.Entity<Reserva>(reserva =>
            {
                reserva.ToTable("Reserva");

                //Columna codigo y Primary key
                reserva.Property(e => e.Investigador_DNI)
                    .HasColumnName("DNI")
                    .HasMaxLength(8)
                    .IsUnicode(true)
                    .IsRequired();

                reserva.Property(e => e.Equipo_NumSerie)
                    .HasColumnName("NumSerie")
                    .HasMaxLength(4)
                    .IsUnicode(true)
                    .IsRequired();

                reserva.HasKey(e => new { e.Investigador_DNI, e.Equipo_NumSerie });

                //Columnas y caracteristicas
                reserva.Property(e => e.Comienzo)
                    .HasColumnName("Comienzo");

                reserva.Property(e => e.Fin)
                    .HasColumnName("Fin");

                reserva.HasOne(e => e.Investigador)
                    .WithMany(i => i.Reservas)
                    .HasForeignKey(e => e.Investigador_DNI);

                reserva.HasOne(e => e.Equipo)
                    .WithMany(i => i.Reservas)
                    .HasForeignKey(e => e.Equipo_NumSerie);

            });

            modelBuilder.Entity<Facultad>(facultad =>
            {
                facultad.ToTable("Facultad"); 
                facultad.Property(e => e.Codigo)
                     .HasColumnName("Codigo")
                     .IsRequired();
                facultad.HasKey(e => e.Codigo);

                facultad.Property(f => f.Nombre)
                    .HasColumnName("Nombre")
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .IsRequired();
            });

            modelBuilder.Entity<Investigador>(investigador =>
            {
                investigador.ToTable("Investigadores");

                //Columna codigo y Primary key
                investigador.Property(e => e.DNI)
                    .HasColumnName("DNI")
                    .HasMaxLength(8)
                    .IsRequired()
                    .IsUnicode(true);
                investigador.HasKey(e => e.DNI);

                investigador.Property(e => e.NomApels)
                    .HasColumnName("NomApels")
                    .HasMaxLength(255)
                    .IsRequired()
                    .IsUnicode(true);

                investigador.HasOne(e => e.Facultad).WithMany(f => f.Investigadores).HasForeignKey("facultad");
            });

        }
    }
}
