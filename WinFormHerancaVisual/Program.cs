using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormHerancaVisual.Model;

namespace WinFormHerancaVisual
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SisDBContext sisDBContext = new SisDBContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormPrincipal());           
            Application.Run(new FormPrincipal(sisDBContext));
        }
    }
}
