using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(50)]
        public string NombreCategoria { get; set; } = string.Empty;
        [AllowNull]

        public string Descripcion { get; set; }

        //de uno a muchos
        public List<Producto> Productos { get; set; } = new();
    }
}
