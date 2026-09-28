using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Producto
    {
        public Producto()
        { Nombre = string.Empty; Aroma = string.Empty; Tamano = string.Empty; Categoria = string.Empty; }
        public int IdProducto { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        
        [StringLength(100)]
        public string Aroma { get; set; }

        [StringLength(60)]
        public string Tamano { get; set; }
        public string Categoria { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
        public bool Estado { get; set; }

        //llave foraneas
        public int IdCategoria { get; set; }
        public Categoria Categorias { get; set; }

    }
}
