using forms_de_el_proyecto_wwwww.Forms;
using Lemondromede.Fomrs;
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

            // El login va primero: ShowDialog espera hasta que el formulario se cierre
            using (var login = new FrmLogin())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;   // canceló o falló 3 veces: la aplicación termina
            }

            Application.Run(new FmrDashboard());   // solo se llega aquí si el login fue OK

        }
    }
}
