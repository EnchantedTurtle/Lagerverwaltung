using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    static class Program
    {
        public static BindingList<Produkt> ProduktListe = new BindingList<Produkt>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        
        }
    }
}
