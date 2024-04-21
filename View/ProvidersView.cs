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
        private static PayModeView instance;
        private TabPage tabPageProvidersList;

        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProvidersDetail);
            BtnClose.Click += delegate { this.Close(); };
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

            BtnNew.Click += delegate {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Add New Provider";

            };

            BtnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Edit Provider";

            };

            BtnDelete.Click += delegate {
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Provider",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProvidersDetail);
                    tabControl1.TabPages.Add(tabPageProvidersList);
                }
                MessageBox.Show(Message);

            };

            BtnCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersDetail);
                tabControl1.TabPages.Add(tabPageProvidersList);
            };

        }

        private void DgProviders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}
