using Microsoft.Extensions.DependencyInjection;
using Tool.Main.Forms.SysForms;

namespace Tool.Main
{
    internal static class Program
    {

        public static ServiceProvider ServiceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceProvider = StartUp.Configuration();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}