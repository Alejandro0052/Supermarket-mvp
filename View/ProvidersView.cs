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
    public partial class ProvidersView : Form
    {
        private object TxtProvidersId;
        private object TxtProvidersName;
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        private bool isSuccesful;
        private TabPage tabPageProvidersDetail;

        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProvidersDetail);
        }

        
    public string ProviderId 
        {
         get => throw new NotImplementedException();
          set => throw new NotImplementedException();
        }
    

        public string ProviderName
        {
           get => throw new NotImplementedException();
           set => throw new NotImplementedException();

        }


        /* public string ProviderObservation
         {
             get => throw new NotImplementedException();
             set => throw new NotImplementedException();
         } */

        public string SearchValue
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        

      /*  public bool IsEdit
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        */
      /*  public bool IsSuccesful
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
      */

       /* public string Message
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        */
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProvidersListBildingSource(BindingSource providersList)
        {
            DgProviders.DataSource = providersList;
        }

   /*   public string ProviderId
        {
            get { return TxtProvidersId.Text; }
            set { TxtProvidersId.Text = value; } 
         }
      public string ProviderName
        {
            get { return TxtProvidersName.Text; }
            set { TxtProvidersName.Text = value; }
         }
     */

     /*  public string ProviderObservation
       {      
           get { return TxtProvidersObservation.Text; }
           set { TxtProvidersObservation.Text = value; }
       }
     */
    /*  public string SearchValue
       {
          get { return TxtSearch.Text; }
          set { TxtSearch.Text = value; }
        }
    */

       /* public bool IsEdit
         {
           get { return isEdit; }
           set { isEdit = value; }
         }
       */
     public bool IsSuccesful
      {
          get { return isSuccesful; }
          set { isSuccesful = value; }
      }
       public string Message
        {
           get { return message; }
           set { message = value; }
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }






    }
}
