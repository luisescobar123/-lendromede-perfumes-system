using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Usuario
    {
        public Usuario()
        { Nombre = string.Empty; Correo = string.Empty; Contrasena = string.Empty; Rol = string.Empty;  }
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Correo { get; set; }
        [Required]
        [StringLength(50)]
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }

        // De uno a muchos
        public List<Pedido> Pedidos { get; set; } = new();
        public List<Venta> Ventas { get; set; } = new();
        public List<Producto> Productos { get; set; } = new();
    }
}
