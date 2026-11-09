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
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            QuestPDF.Settings.License = LicenseType.Community;

            
                ApplicationConfiguration.Initialize();


                AuthService.CrearUsuarioInicial();

            while (true)
            {
                Sesion.VolverAlLogin = false;

                using (var login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;
                }

                using (var dashboard = new FmrDashboard())
                {
                    Application.Run(dashboard);
                }

                if (!Sesion.VolverAlLogin)
                    break;
            }


        }
    }
}