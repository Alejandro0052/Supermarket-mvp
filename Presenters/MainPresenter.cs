using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.View;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;
        private int ShowProvidersView;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
       //     this.mainView.ShowPayModeView += ShowPayModeView;
         //   this.mainView.ShowProductView += ShowProductView;
     //       this.mainView.ShowProvidersView += ShowProvidersView;
        }
                                                
        private void ShowProductView(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            IProductView view = ProductView.GetInstance((MainView)mainView);
           IProductView views = new ProductView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            IProductRepository epository = new ProductRepository(sqlConnectionString);
 //SOLUCIONAR ERROR!           new ProductPresenter(view, repository);                 
                            

        }
     
        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
           IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
           new PayModePresenter(view, repository);
        }
    }
}
                                                                                                            