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
    public partial class PayModeView : Form, IPayModeView
    {
        // ERRORES EN ESTA CLASE AL AGREGAR MANUALMENTE LAS PROPIEDADES,
        // LO HICE COMO APARECE EN LA GUIA PERO PERO MUESTRA 13 ERRORES
        // PUNTO 3.6
        // Voy en el punto 5.10
        //private object txtSearch;
        //private object txtPayModeId;
        //private string payModeId; 
        private string payModeName;
        private bool isEdit;
        private string message;
        private string payModeObservation;
        private string searchValue;
        private bool isSuccessfulM;
        //private object DgPayMode;
        //private object TxtPayModeId;

        //private object txtPayModeId;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //throw new NotImplementedException();
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }


            };

        }



       // private string PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      // public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
      public string PayModebservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       /// <summary>
       //public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       /// </summary>
     //  public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public bool IsSuccesful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public string Mesage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

     





        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancellEvent;

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }

        }

        
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }

        }


        public string PayModeObservation
        {
            get { return TxtModeObservation.Text; }
            set { TxtModeObservation.Text = value; }

        }


        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }

        }


        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }

        }


        public bool IsSuccessful
        {
            get { return IsSuccesful; }

            set { IsSuccesful = value; }
        }

        public string Message
        {
            get { return Message; }
            set { Message = value; }

        }

        public string PayModeObservación { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPayModeView.PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

         public void SetPayModeListBildingSource(BindingSource payModeList)
         {

          DgPayMode.DataSource = payModeList;

         }

       /* public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            throw new NotImplementedException();
        }*/



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPayModeName_TextChanged(object sender, EventArgs e)
        {

        }

        public void SerPayModeListBildingSource(BindingSource payModeBindingSource)
        {
      //      throw new NotImplementedException();   
        }


        private static PayModeView instance;
        private static Form? parentContainer;

        public static PayModeView GetInstance() 
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
                instance.MdiParent = parentContainer;

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

        internal class GetInstance : IPayModeView
        {
            private MainView mainView;

            public GetInstance(MainView mainView)
            {
                this.mainView = mainView;
            }
        }
    }
}
