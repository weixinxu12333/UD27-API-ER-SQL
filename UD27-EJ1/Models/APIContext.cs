using Microsoft.EntityFrameworkCore;

namespace UD27_EJ1.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        //Listas
        public DbSet<Pieza> Piezas { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Suministra> Suministra { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pieza>(pieza => 
            {
                pieza.ToTable("Piezas");

                //Columna codigo y Primary key
                pieza.Property(e => e.Codigo)
                    .HasColumnName("Codigo")
                    .IsRequired();
                pieza.HasKey(e => e.Codigo);

                //Columnas y caracteristicas
                pieza.Property(e => e.Nombre)
                    .IsRequired()
                    .IsUnicode()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Proveedor>(proveedor =>
            {
                proveedor.ToTable("Proveedores");

                //Columna codigo y Primary key
                proveedor.Property(e => e.Id)
                    .HasColumnName("Id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsRequired();
                proveedor.HasKey(e => e.Id);

                //Columnas y caracteristicas
                proveedor.Property(e => e.Nombre)
                    .IsUnicode(false)
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Suministra>(suministra =>
            {
                suministra.ToTable("Suministra");

                //Columna codigo y Primary key
                suministra.Property(e => e.CodigoPieza)
                    .HasColumnName("CodigoPieza")
                    .IsRequired();
                suministra.HasKey(e => e.CodigoPieza);

                suministra.Property(e => e.IdProveedor)
                    .HasColumnName("IdProveedor")
                    .HasMaxLength(4)
                    .IsRequired();
                suministra.HasKey(e => e.IdProveedor);

                suministra.Property(e => e.Precio)
                    .HasColumnName("Precio");

                //Relaciones de las tablas
                suministra.HasOne(p => p.Pieza)
                    .WithMany(s => s.Suministras)
                    .HasForeignKey(f => f.CodigoPieza)
                    .HasConstraintName("CodigoPieza_fk");

                suministra.HasOne(p => p.Proveedor)
                   .WithMany(s => s.Suministras)
                   .HasForeignKey(f => f.IdProveedor)
                   .HasConstraintName("IdProveedor_fk");
            });

        }

    }
}
