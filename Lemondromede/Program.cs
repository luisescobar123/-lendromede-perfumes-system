using forms_de_el_proyecto_wwwww.Forms;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form formularioInicial = args.Contains("--usuarios", StringComparer.OrdinalIgnoreCase)
                ? new FmrUsuarios()
                : new FmrVentas();
            Application.Run(formularioInicial);
        }
    }
}