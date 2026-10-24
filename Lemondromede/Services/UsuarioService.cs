using Lemondromede.Data;
using Lemondromede.Models;
using Microsoft.EntityFrameworkCore;

namespace Lemondromede.Services
{
    public class UsuarioService
    {
        public List<Usuario> ObtenerUsuarios(string? filtro = null)
        {
            using var context = new LendromedeContext();
            var consulta = context.Usuarios.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim();
                consulta = consulta.Where(usuario =>
                    usuario.Nombre.Contains(filtro) ||
                    usuario.Correo.Contains(filtro) ||
                    usuario.Rol.Contains(filtro));
            }

            return consulta
                .OrderBy(usuario => usuario.Nombre)
                .ToList();
        }

        public void CrearUsuario(Usuario usuario)
        {
            using var context = new LendromedeContext();
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            using var context = new LendromedeContext();
            var usuarioExistente = context.Usuarios.Find(usuario.IdUsuario)
                ?? throw new InvalidOperationException("El usuario seleccionado ya no existe.");

            usuarioExistente.Nombre = usuario.Nombre;
            usuarioExistente.Correo = usuario.Correo;
            usuarioExistente.Rol = usuario.Rol;
            usuarioExistente.Estado = usuario.Estado;

            if (!string.IsNullOrWhiteSpace(usuario.Contrasena))
            {
                usuarioExistente.Contrasena = usuario.Contrasena;
            }

            context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            using var context = new LendromedeContext();
            var usuario = context.Usuarios.Find(id)
                ?? throw new InvalidOperationException("El usuario seleccionado ya no existe.");

            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
    }
}
