using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp;
using Supermarket_mvp.Models;
using Supermarket_mvp.View;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;
        private IMainView view1;
        private string sqlConnectionString;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {                                                                               
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SaveEvent += SearcPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelelctedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancellEvent += CancelAction;
            this.view.SerPayModeListBildingSource(payModeBindingSource);
            loadAllPayModeList();
            this.view.Show();
        }

        public PayModePresenter(IMainView view1, string sqlConnectionString)
        {
            this.view1 = view1;
            this.sqlConnectionString = sqlConnectionString;
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
         //   throw new NotImplementedException();
         CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
          //  throw new NotImplementedException();
          var payMode = new PayModeModel();
          payMode.Id = Convert.ToInt32(payMode.Id);
          payMode.Name = view.PayModeName;
          payMode.Observation = view.PayModeObservación;

            try
            {                                                           
                new Common.ModelDataValidation().Validate(payMode);
                if (view.IsEdit)
                {
                    repository.Edit(payMode);
                    view.Mesage = "PayMode edited succesfuly";
                }

                else 
                {
                    repository.Add(payMode);
                    view.Mesage = "PayMode added succesfuly";
                }
                view.IsSuccesful = true;    
                loadAllPayModeList();
                CleanViewFields();


            }

            catch (Exception ex)             
            {
                    view.IsSuccesful = false;
                    view.Mesage = ex.Message;   
            
            }



        }

        private void CleanViewFields()
        {
            //throw new NotImplementedException();
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservación = "";
        }
  

        private void DeleteSelelctedPayMode(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();            try
            try
            {
                var payMode = (PayModeModel)payModeBindingSource.Current;


                repository.Delete(payMode.Id);
                view.IsSuccesful = true;
                view.Mesage = "Pay Mode deleted succesfully";
                loadAllPayModeList();
            
            }


            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Mesage = "An error ocurred, Could not delete pay mode";

            }



        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            // throw new NotImplementedException();
            var payMode = (PayModeModel)payModeBindingSource.Current;

            view.PayModeId = payMode.Id.ToString();
            view.PayModeName = payMode.Name;
            view.PayModeObservación = payMode.Observation;

            view.IsEdit = true;

        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //   MessageBox.Show("Se hizo clic en el boton nuevo");
            view.IsEdit = false;
        }

        private void SearcPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);

            }
            else
            {
                payModeList = repository.GetAll();
            
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
