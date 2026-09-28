using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public int CantidadDisponible { get; set; }
        [Required]
        public int Stock { get; set; }
        public DateTime FechaActual { get; set; }
        public int IdProducto { get; set; }

        public Producto Producto { get; set; }

    }
}
