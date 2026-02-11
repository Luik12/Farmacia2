using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
         {
            // Habilitar DPI Awareness para mejorar la calidad visual
            if (Environment.OSVersion.Version.Major >= 6)       
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LOGIN());
        }

        // Importar la función de la API de Windows para DPI Awareness
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
    }
