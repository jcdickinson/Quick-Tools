using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;

namespace QuickTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var c1 = new AssemblyCatalog(typeof(Program).Assembly);
            var c2 = new DirectoryCatalog(".\\plugins");
            var c = new AggregateCatalog(c1, c2);

            using (var cont = new CompositionContainer(c))
            {
                var ctx = cont.GetExportedValue<QuickToolsContext>();
                Application.Run(ctx);
            }
        }
    }
}
