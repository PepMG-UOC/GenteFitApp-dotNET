﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenteFitApp.Vistas;

namespace GenteFitApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogging logging = new frmLogging();
            logging.Show();
            //frmImportExportXML importa = new frmImportExportXML();
            //importa.Show();
            Application.Run();
        }
    }
}
