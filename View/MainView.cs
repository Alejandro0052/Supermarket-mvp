using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.View
{
    public partial class MainView : Form
    {
     //   int IMainView.ShowProvidersView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MainView()
        {
            InitializeComponent();
            BtnPayMode.Click += delegate { ShowPayModeView?.Invoke(this, EventArgs.Empty); };
            BtnExit.Click += delegate { this.Close(); };
            BtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
        }                                                   
        event EventHandler ShowPayModeView;
        event EventHandler ShowProductView;
        public event EventHandler ShowProvidersView;
        public event EventHandler ShowCategoriesView;

        event EventHandler ShowCustomerView;


        //ACA HICE LOS CAMBIOS PARA QUE EJECUTARA
/*        event EventHandler IMainView.ShowPayModeView
        {
            add
            {
                //throw new NotImplementedException();
            }

            remove
            {
                //    throw new NotImplementedException();
            }
        }

        event EventHandler IMainView.ShowProductView
        {
            add
            {
                //    throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler IMainView.ShowCustomerView
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        */
        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void BtnPayMode_Click(object sender, EventArgs e)
        {
            PayModeView payModeView = new PayModeView();

            payModeView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView();

            productView.Show();
        }

        private void BtnProviders_Click(object sender, EventArgs e)
        {
            ProvidersView providersView = new ProvidersView();
            providersView.Show();   
        }
    }
}

