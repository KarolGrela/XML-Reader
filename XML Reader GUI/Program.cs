using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_Reader_GUI.Secondary_Forms;
using S7.Net;

namespace XML_Reader_GUI
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
            Application.Run(new mainMenuForm());
        }
    }

    static class Global
    {
        private static Plc mainPlc;

        public static Plc MainPlc
        {
            get { return mainPlc; }
            set { mainPlc = value; }
        }
    }

}
