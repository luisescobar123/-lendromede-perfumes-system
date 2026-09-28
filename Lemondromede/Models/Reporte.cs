using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Models
{
    public class Reporte
    {
        public int IdReporte { get; set; }

        public string TipoReporte { get; set; } = string.Empty;
        public DateTime FechaGenerado { get; set; }
        //Llave foraneas
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

    }
}
