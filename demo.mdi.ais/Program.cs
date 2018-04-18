using demo.mdi.ais.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.mdi.ais
{
    static class Program
    {
        private static ChildWindowsHistoryController controller;
        public static ChildWindowsHistoryController Controller { get => controller; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMdiMain main = new FormMdiMain();
            controller = new ChildWindowsHistoryController(main);
            Application.Run(main);
        }
    }
}
