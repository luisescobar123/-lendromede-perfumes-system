using Lemondromede.Data;
using Lemondromede.Models;
using Microsoft.EntityFrameworkCore;

namespace Lemondromede.Services
{
    public class CategoriaService
    {
        private readonly LendromedeContext _context;

        public CategoriaService()
        {
            _context = new LendromedeContext();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _context.Categorias
                .AsNoTracking()
                .ToList();
        }

        public Categoria? ObtenerCategoria(int id)
        {
            return _context.Categorias
                .FirstOrDefault(c => c.IdCategoria == id);
        }

        public void CrearCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
        }

        public void EliminarCategoria(int id)
        {
            var categoria = ObtenerCategoria(id);

            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
            }
        }
    }
}