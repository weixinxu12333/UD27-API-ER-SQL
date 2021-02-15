using Microsoft.EntityFrameworkCore;

namespace UD27_EJ3.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        //Listas
        public DbSet<Cajero> Cajeros { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Maquina_Registradora> Maquina_Registradoras { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cajero>(cajero =>
            {
                cajero.ToTable("Cajeros");

                //Columna codigo y Primary key
                cajero.Property(e => e.Codigo)
                    .HasColumnName("Codigo")
                    .IsRequired();
                cajero.HasKey(e => e.Codigo);

                //Columnas y caracteristicas
                cajero.Property(e => e.NomApels)
                .HasColumnName("NomApels")
                    .IsRequired()
                    .IsUnicode(true)
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Producto>(producto =>
            {
                producto.ToTable("Productos");

                //Columna codigo y Primary key
                producto.Property(e => e.Codigo)
                    .HasColumnName("Codigo")
                    .IsRequired();
                producto.HasKey(e => e.Codigo);

                //Columnas y caracteristicas
                producto.Property(e => e.Nombre)
                    .HasColumnName("Nombre")
                    .IsRequired()
                    .IsUnicode(true)
                    .HasMaxLength(100);

                producto.Property(e => e.Precio)
                    .HasColumnName("Precio")
                    .IsRequired();
            });

            modelBuilder.Entity<Maquina_Registradora>(maquina_registradoras =>
            {
                maquina_registradoras.ToTable("Maquinas_registradoras");

                //Columna codigo y Primary key
                maquina_registradoras.Property(e => e.Codigo)
                    .HasColumnName("Codigo")
                    .IsRequired();
                maquina_registradoras.HasKey(e => e.Codigo);

                //Columnas y caracteristicas
                maquina_registradoras.Property(e => e.Piso)
                    .HasColumnName("Piso")
                    .IsRequired();
            });

            modelBuilder.Entity<Venta>(venta =>
            {
                venta.ToTable("Venta");

                //Columna codigo y Primary key
                venta.Property(e => e.Cajero)
                    .HasColumnName("Cajero")
                    .IsRequired();
                venta.HasKey(e => e.Cajero);

                venta.Property(e => e.Maquina)
                    .HasColumnName("Maquina")
                    .IsRequired();
                venta.HasKey(e => e.Maquina);

                venta.Property(e => e.Producto)
                    .HasColumnName("Producto")
                    .IsRequired();
                venta.HasKey(e => e.Producto);

                //Relaciones de las tablas
                venta.HasOne(c => c.Cajeros)
                    .WithMany(v => v.Ventas)
                    .HasForeignKey(f => f.Cajero)
                    .HasConstraintName("Cajero_fk");

                venta.HasOne(c => c.Productos)
                    .WithMany(v => v.Ventas)
                    .HasForeignKey(f => f.Producto)
                    .HasConstraintName("Producto_fk");

                venta.HasOne(c => c.Maquinas)
                    .WithMany(v => v.Ventas)
                    .HasForeignKey(f => f.Maquina)
                    .HasConstraintName("Maquina_fk");

            });

        }

    }
}