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
        // ERRORES EN ESTA CLASE AL AGREGAR MANUALMENTE LAS PROPIEDADES, LO HICE COMO APARECE EN LA GUIA PERO PERO MUESTRA 13 ERRORES
        private string payModeId { get; set; }
        private string payModeName;
        private bool isEdit;
        private string message;
        private string PayModeObservation { get; set; }
        private string SearchValue;
        private bool IsSuccessfulM;
        private object DgPayMode;
        private object TxtSearch;

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



        private string PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public string PayModeObservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
            get { return TxtPaymodeId.Text; }
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

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
        
         DgPayMode.DataSource = payModeList;

        }


   
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

     /*   public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            throw new NotImplementedException();
        }
     */

    }
}
