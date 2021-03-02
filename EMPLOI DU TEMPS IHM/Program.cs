using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOI_DU_TEMPS_IHM
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
            Application.Run(new Form1());


            ServiceReference1.WebService1SoapClient LE_SERVICE = new ServiceReference1.WebService1SoapClient();

            ServiceReference1.C_Cours[] Les_Cours = LE_SERVICE.DonneCours();


        }
    }
}
