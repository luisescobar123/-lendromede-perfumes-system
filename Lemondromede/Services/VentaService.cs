using Lemondromede.Data;
using Lemondromede.Models;
using Microsoft.EntityFrameworkCore;

namespace Lemondromede.Services
{
    public class VentaService
    {
        private readonly LendromedeContext _context;

        public VentaService()
        {
            _context = new LendromedeContext();
        }

        // ----- Listados para llenar los combos del formulario -----

        public List<Cliente> ObtenerClientes()
        {
            return _context.Clientes
                .AsNoTracking()
                .ToList();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return _context.Usuarios
                .AsNoTracking()
                .Where(u => u.Estado)
                .ToList();
        }

        public List<Producto> ObtenerProductosActivos()
        {
            return _context.Productos
                .AsNoTracking()
                .Where(p => p.Estado && p.Stock > 0)
                .ToList();
        }

        // ----- Lectura de ventas -----

        public List<Venta> ObtenerVentas()
        {
            // Include trae Cliente y Usuario junto con cada Venta,
            // porque EF Core no los carga automáticamente.
            return _context.Ventas
                .AsNoTracking()
                .Include(v => v.Cliente)
                .Include(v => v.Usuario)
                .OrderByDescending(v => v.Fecha)
                .ToList();
        }

        public Venta? ObtenerVentaConDetalle(int id)
        {
            return _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.Usuario)
                .Include(v => v.Dventas)
                    .ThenInclude(d => d.Producto)
                .FirstOrDefault(v => v.IdVenta == id);
        }

        // ----- Crear una venta completa (encabezado + líneas) -----

        public void CrearVenta(Venta venta)
        {
            // venta ya debe traer su lista Dventas llena en memoria.
            // EF Core detecta el grafo completo (Venta + Dventas) e
            // inserta todo dentro de una sola transacción.
            _context.Ventas.Add(venta);
            _context.SaveChanges();

            // Descuenta el stock de cada producto vendido.
            foreach (var detalle in venta.Dventas)
            {
                var producto = _context.Productos.Find(detalle.IdProducto);
                if (producto != null)
                {
                    producto.Stock -= detalle.Cantidad;
                }
            }
            _context.SaveChanges();
        }

        // ----- Anular venta (eliminación lógica) -----

        // Nota: Venta -> DetalleVenta está configurada como Restrict
        // en LendromedeContext, así que SQL Server rechaza un Remove()
        // directo si ya tiene detalles guardados. Por eso se usa el
        // campo Estado como "anulada" en vez de borrar físicamente.
        public void AnularVenta(int id)
        {
            var venta = _context.Ventas.FirstOrDefault(v => v.IdVenta == id);
            if (venta != null)
            {
                venta.Estado = false;
                _context.Ventas.Update(venta);
                _context.SaveChanges();
            }
        }
    }
}
