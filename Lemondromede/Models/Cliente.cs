using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lemondromede.Models
{
    public class Cliente
    {
        public Cliente()
        { Nombre = string.Empty; Correo = string.Empty; Numero = string.Empty; Direccion = string.Empty; }

        public int IdCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        
        [StringLength(15)]
        [RegularExpression(@"^\+?[0-9]\s\-]+$")]
         public string Numero { get; set; }

        [EmailAddress]
        public string Correo { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        //de uno a muchos
        public List<Pedido> Pedidos { get; set; } = new();
        public List<Venta> Ventas { get; set; } = new();
    }
}
