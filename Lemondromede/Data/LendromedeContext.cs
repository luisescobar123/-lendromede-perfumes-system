using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lemondromede.Models;
using Lemondromede.Config;



namespace Lemondromede.Data
{
    public class LendromedeContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetallePedido>Dpedidos { get; set; }
        public DbSet<DetalleVenta> Dventas { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
      

        

        public LendromedeContext() { }
        public LendromedeContext(DbContextOptions<LendromedeContext>options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //definir la cadena de conexion
            
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConfiguracionApp.ObtenerCadenaConexion());
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Pedidos)
                .HasForeignKey(p => p.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Producto>()
                .Property(p => p.Estado)
                .HasDefaultValue(true);

            
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categorias)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.IdCategoria)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)            
                .WithMany(c => c.Ventas)          
                .HasForeignKey(v => v.IdCliente)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Usuario) 
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.Dventas)
                .HasForeignKey(dv => dv.IdVenta)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Producto)
                .WithMany()
                .HasForeignKey(dv => dv.IdProducto)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetallePedido>()
                .HasOne(dp => dp.Pedido)
                .WithMany(p => p.Dpedidos)
                .HasForeignKey(dp => dp.IdPedido)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetallePedido>()
                .HasOne(dp => dp.Producto)
                .WithMany()
                .HasForeignKey(dp => dp.IdProducto)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Producto)
                .WithMany()
                .HasForeignKey(i => i.IdProducto)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Producto>().HasData(
    
    );

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { IdCategoria = 1, NombreCategoria = "Florales", Descripcion = "Aromas florales" },
                new Categoria { IdCategoria = 2, NombreCategoria = "Dulces", Descripcion = "Aromas dulces" },
                new Categoria { IdCategoria = 3, NombreCategoria = "Cítricos", Descripcion = "Aromas cítricos" },
                new Categoria { IdCategoria = 4, NombreCategoria = "Amaderados", Descripcion = "Aromas amaderados" }
            );

            modelBuilder.Entity<Producto>().HasData(
                new Producto { IdProducto = 1, Nombre = "Une touche deau", Aroma = "toques de agua", Tamano = "15.2cm", Precio = 143.94m, Stock = 19, Estado = true, IdCategoria = 1 },
                new Producto { IdProducto = 2, Nombre = "Cœur rouge", Aroma = "olor a venas dulces", Tamano = "13.7cm", Precio = 133.22m, Stock = 14, Estado = true, IdCategoria = 2 },
                new Producto { IdProducto = 3, Nombre = "Dague jaune", Aroma = "aroma a dulce", Tamano = "18.1cm", Precio = 167.94m, Stock = 0, Estado = false, IdCategoria = 3 },
                new Producto { IdProducto = 4, Nombre = "Couronne royale", Aroma = "aroma a realeza real", Tamano = "15.6cm", Precio = 2490.61m, Stock = 0, Estado = false, IdCategoria = 4 }
            );


        }
        
    }
}
