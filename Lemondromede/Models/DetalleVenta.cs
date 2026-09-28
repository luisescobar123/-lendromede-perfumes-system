using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class DetalleVenta
    {
        public int IdDetalleV { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Subtotal { get; set; }
        //llave foraneas
        public int IdVenta { get; set; }
        public Venta Venta { get; set; }
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
    }
}
