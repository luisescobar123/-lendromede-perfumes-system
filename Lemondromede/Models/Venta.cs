using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Venta
    {
        public Venta()
        { TipoVenta = string.Empty; }
        [Key] 
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
        public string TipoVenta { get; set; }
        public bool Estado { get; set; }
        //Llave foraneas
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        //Relacion con detalleventa
        public List<DetalleVenta> Dventas { get; set; } = new();
    } 

    
}
