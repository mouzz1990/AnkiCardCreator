using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AnkiCardCreator.Model;

namespace AnkiCardCreator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model.Model model = new Model.Model();
            //WinFormView form = new WinFormView();
            MetroFormView form = new MetroFormView();
            
            Presenter presenter = new Presenter(model, form);

            Application.Run(form);
        }
    }
}
