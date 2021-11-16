using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MVP.Model;
using WindowsFormsApp1.MVP.Presenter;
using WindowsFormsApp1.MVP.View;
using XML;

namespace WindowsFormsApp1
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
            var view = new Form1();
            var repository = new DbRepository(Application.StartupPath);
            var userData = new DataRepository(Application.StartupPath);
            var mealsRepo = new MealsRepository(Application.StartupPath);
            var presenter = new MainPresenter(view, repository, userData);
            var mealsPresenter = new MealsPresenter(view, mealsRepo, presenter);
            Application.Run(view);
        }
    }
}