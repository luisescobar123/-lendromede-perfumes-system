using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lemondromede.Models;



namespace Lemondromede.Data
{
    public class LendromedeContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetallePedido>Dpedidos { get; set; }
        public DbSet<DetalleVenta> Dventas { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        

        public LendromedeContext() { }
        public LendromedeContext(DbContextOptions<LendromedeContext>options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //definir la cadena de conexion
            /*
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConfiguracionApp.ObtenerCadenaConexion());
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                
        }
        */
    }
}
