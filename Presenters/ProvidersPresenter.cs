using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.View;
using Supermarket_mvp.Models;
using Microsoft.Data.SqlClient;
using System.Data;
//using Microsoft.IdentityModel.Tokens;

namespace Supermarket_mvp.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;
        private string connectionString;
        private object id;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSeletedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);

            loadAllProvidersList();

            this.view.Show();

        }

        private void loadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
          //  throw new NotImplementedException();
            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSeletedProviders(object? sender, EventArgs e)
        {
            //  throw new NotImplementedException();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }

        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
          //  throw new NotImplementedException();
            var provider = (ProvidersModel)providersBindingSource.Current;

            /*       view.ProviderId = provider.Id.ToString();
                   view.ProviderName = provider.Name;
                   view.ProviderObservation = provider.Observation;

                   view.IsEdit = true;

                   try
       {
           new Common.ModelDataValidation().Validate(provider);

           if (view.IsEdit)
           {
               repository.Edit(provider);
               view.Message = "Provider edited successfuly";
           }
           else
           {
               repository.Add(provider);
               view.Message = "Provider added successfuly";
           }
           view.IsSuccesful = true;
           loadAllProvidersList();
           CleanViewFields();
       }
       catch (Exception ex)
       {
           view.IsSuccesful = false;
           view.Message = ex.Message;
       }

            */

        }

        private void CleanViewFields()
        {
            view.ProviderId = "0";
            view.ProviderName = "";
            view.ProviderObservation = "";
        }



        private void AddNewProviders(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
          //  view.IsEdit = false;
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
          /*  bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);

            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
          */
        }






    }
}
