using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Pedido
    {
        public Pedido()
        {
            DireccionEntrega = string.Empty;
        }
        [Key]
        public int IdPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        [Required]
        [StringLength(200)]
        public string DireccionEntrega { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
        public bool Estado { get; set; }
        //Llave foraneas
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        // Relación con DetallePedido
        public List<DetallePedido> Dpedidos { get; set; } = new();
    }
}
