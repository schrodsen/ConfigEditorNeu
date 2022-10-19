using System;
using System.Windows.Forms;
using Autofac;

namespace ConfigEditor.Ui
{
    internal static class Program
    {
        public static ILifetimeScope AutofacContainer { get; set; }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutofacContainer = DiRegistration.Build();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
