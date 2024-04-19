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
        // 
        // 
        //private object txtSearch;
        //private object txtPayModeId;
        private string payModeId; 
        private string payModeName;
        private bool isEdit;
        private string message;
        private string payModeObservation;
        private string searchValue;
        //   private bool isSuccessful;
        //private object DgPayMode;
        //private object TxtPayModeId;

        //private object txtPayModeId;

        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);
            BtnClose.Click += delegate { this.Close(); };
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
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add New Pay Mode";

            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add New Pay Mode";


            };
            BtnDelete.Click += delegate
            {
                // DeleteEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Pay Mode," +
                    "Warning"
                                           // AQUI HAY UN ERROR punto 7.2  MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                                           );

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);

                }

            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccesful)
                {
                    tabControl1.TabPages.Remove(tabPagePayModeDetail);
                    tabControl1.TabPages.Add(tabPagePayModeList);


                }
                MessageBox.Show(Mesage);


            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeDetail);
                tabControl1.TabPages.Add(tabPagePayModeList);


            };

        }
        private void AddNewPayMode(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo clic en el boton nuevo");

            //ERROR PUNTO 7.3     view.IsEdit = false;
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        public event EventHandler CancelEvent;
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
        private TabPage tabPagePayModeList;
        private bool isSuccesful;
        private object view;

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



        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            // ACA HAY ERRORES PUNTO 7.3
    //        var payMode = (PayModeModel) payModeBindingSource.Current;


       //     view.PayModeId = payMode.Id.ToString();                         
         //   view.PayModeName = payMode.Name;
           // view.PayModeObservation = payMode.Observation;

            // view.IsEdit = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void DgPayMode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
