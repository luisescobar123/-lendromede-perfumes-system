using Login.Forms;
using Lemondromede.Fomrs;
using Lemondromede.Services;

using System;

namespace Lemondromede
{
    using QuestPDF.Infrastructure;

    internal static class Program
    {
       
        
        
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            QuestPDF.Settings.License = LicenseType.Community;

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
