using Login.Forms;
using Lemondromede.Fomrs;
using Lemondromede.Services;
using System;

namespace Lemondromede
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            AuthService.CrearUsuarioInicial();

            using (var login = new FrmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new FmrDashboard());   

        }
    }
}
