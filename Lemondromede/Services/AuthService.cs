using System.Security.Cryptography;
using System.Text;
using Lemondromede.Data;
using Lemondromede.Models;
using Microsoft.EntityFrameworkCore;

namespace Lemondromede.Services
{
    public class AuthService
    {
        public static void CrearUsuarioInicial()
        {
            const string correo = "usuario@lendromede.com";

            using var ctx = new LendromedeContext();
            if (ctx.Usuarios.Any(u => u.Correo == correo))
                return;

            ctx.Usuarios.Add(new Usuario
            {
                Nombre = "Usuario principal",
                Correo = correo,
                Contrasena = HashContrasena("Usuario123!"),
                Rol = "Administrador",
                Estado = true
            });
            ctx.SaveChanges();
        }
        
        public Usuario? Autenticar(string correo, string contrasena)
        {
            string hash = HashContrasena(contrasena);

            using var ctx = new LendromedeContext();
            return ctx.Usuarios
                .AsNoTracking()
                .FirstOrDefault(u => u.Correo == correo
                                  && u.Contrasena == hash
                                  && u.Estado);
        }

   
        public static string HashContrasena(string contrasena)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(contrasena));
            return Convert.ToBase64String(bytes);
        }
    }

  
    public static class Sesion
    {
        public static Usuario? UsuarioActual { get; set; }

        public static bool EsAdministrador =>
            UsuarioActual?.Rol == "Administrador";
    }
}