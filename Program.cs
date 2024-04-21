using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters;
using Supermarket_mvp.Properties;
using Supermarket_mvp.View;

namespace Supermarket_mvp
{
    internal static class Program 
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {                                                               
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();   
          //  IPayModeView view = new IPayModeView(); 
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}       