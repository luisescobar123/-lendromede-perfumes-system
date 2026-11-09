using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Dtos
{
    internal class VentaReportesDto
    {
        
    public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; } = "";
        public string Vendedor { get; set; } = "";
        public int Productos { get; set; }      // unidades vendidas
        public decimal Total { get; set; }
    }

}

