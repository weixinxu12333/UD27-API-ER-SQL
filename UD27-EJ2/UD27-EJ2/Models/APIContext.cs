using Microsoft.EntityFrameworkCore;

namespace UD27_EJ2.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        //Listas
        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Asignado_a> Asignado_as { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cientifico>(cientifico =>
            {
                cientifico.ToTable("Cientificos");

                //Columna codigo y Primary key
                cientifico.Property(e => e.Dni)
                    .HasColumnName("Dni")
                    .HasMaxLength(8)
                    .IsRequired();
                cientifico.HasKey(e => e.Dni);

                //Columnas y caracteristicas
                cientifico.Property(e => e.NomApels)
                    .HasColumnName("NomApels")
                    .IsUnicode(true)
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Proyecto>(proyecto =>
            {
                proyecto.ToTable("Proyectos");

                //Columna codigo y Primary key
                proyecto.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasMaxLength(4)
                    .IsUnicode(true)
                    .IsRequired();
                proyecto.HasKey(e => e.Id);

                //Columnas y caracteristicas
                proyecto.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .IsUnicode(true)
                    .HasMaxLength(255);

                proyecto.Property(e => e.Horas)
                    .HasColumnName("Horas")
                    .HasMaxLength(255);

            });

            modelBuilder.Entity<Asignado_a>(asignado_a =>
            {
                asignado_a.ToTable("Asignado_a");

                //Columna codigo y Primary key
                asignado_a.Property(e => e.Cientifico)
                    .HasColumnName("Cientifico")
                    .IsRequired()
                    .IsUnicode(true);
                asignado_a.HasKey(e => e.Cientifico);

                asignado_a.Property(e => e.Proyecto)
                    .HasColumnName("Proyecto")
                    .HasMaxLength(4)
                    .IsRequired()
                    .IsUnicode(true);
                asignado_a.HasKey(e => e.Proyecto);

                //Relaciones de las tablas
                asignado_a.HasOne(c => c.Cientificos)
                    .WithMany(a => a.Asignado_As)
                    .HasForeignKey(cc => cc.Cientifico)
                    .HasConstraintName("Cientifico_fk");

                asignado_a.HasOne(p => p.Proyectos)
                   .WithMany(a => a.Asignado_As)
                   .HasForeignKey(pr => pr.Proyecto)
                   .HasConstraintName("Proyecto_fk");
            });

        }

    }
}
