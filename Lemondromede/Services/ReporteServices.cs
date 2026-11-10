using Lemondromede.Data;
using Lemondromede.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondromede.Services
{
    internal class ReporteServices
    {
        public List<VentaReportesDto> VentasPorRango(DateTime desde, DateTime hasta)
        {
            DateTime inicio = desde.Date;             
            DateTime fin = hasta.Date.AddDays(1);   

            using var ctx = new LendromedeContext();
            return ctx.Ventas.AsNoTracking()
                      .Where(v => v.Fecha >= inicio && v.Fecha < fin)
                      .OrderBy(v => v.Fecha)
                      .Select(v => new VentaReportesDto
                      {
                          Id = v.IdVenta,
                          Fecha = v.Fecha,
                          Cliente = v.Cliente.Nombre,          
                          Vendedor = v.Usuario.Nombre,  
                          Productos = v.Dventas.Sum(d => d.Cantidad),
                          Total = v.Total
                      })
                      .ToList();

        }
    }
}   
