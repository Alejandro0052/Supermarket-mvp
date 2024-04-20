using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace Supermarket_mvp.View
{
    public partial class ProductView : Form, IProductView

    {
        private void CleanViewFields()
        {
          /*  view.ProductId = "0";
            view.ProductName = "";
            view.ProductObservation = "";
          */

        }
        private void CancelAction(object? sendeder, object? sender, EventArgs e)
        {
            CleanViewFields();

        }

        //  public string ProductId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IProductView.ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetProductObservation()
        {
            throw new NotImplementedException();
        }

        public void SetProductObservation(string value)
        {
            throw new NotImplementedException();
        }

        //    public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //   public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //    public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //   public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private TabPage tabPageProductDetail;

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            //        tabControl1.TabPages.Remove(tabPageProductDetail);
            BtnClose.Click += delegate { this.Close(); };



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
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                //   tabControl1.TabPages.Remove(tabPageProductList);
                //    tabControl1.TabPages.Add(tabPageProductDetail);
                //      tabPageProductDetail.Text = "Add New Product";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                // tabControl1.TabPages.Remove(tabPageProductList);
                //    tabControl1.TabPages.Add(tabPageProductDetail);
                //     tabPageProductDetail.Text = "Edit Product";
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                //    tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);

            };
            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Product", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Product WHERE Product_Id =@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }


        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductObservation
        {
            get { return TxtProductObservation.Text; }
            set { TxtProductObservation.Text = value; }
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
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { Message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {

            /*  var product = (ProductModel)productBindingSource.Current;
              view.ProductId = product.Id.ToString();
              view.ProductName = product.Name;
              view.ProductObservation = product.Observation;
              view.IsEdit = true;
            */
        }


        public void SetProductListBildingSource(BindingSource productList)
        {
            DgProduct.DataSource = productList;
        }
        private static ProductView instance;
        private TabPage tabPageProductList;
        private object view;
        private string connectionString;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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

        private void AddNewProduct(object? sender, EventArgs e)
        {
            //  view.isEdit = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
          /*  var product = new ProductModel();
            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductName;
            product.Observation = view.ProductObservation;
            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.edit(product);
                    view.Message = "Product edited Successfuly";

                }
                else

                {
                    repository.Add(product);
                    view.Message = "Product added successfuly";

                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
          */



        }
    }
}
