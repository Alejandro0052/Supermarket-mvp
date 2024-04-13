using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {
        public PayModeRepository(string connectionString) 
        {
          this.connetionString = connectionString;
        }

        public IEnumerable<PayModeModel> GetAll() 
        {
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connetionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeList.Add(payModeModel);  
                    
                    }
                }
            }
            return payModeList;
        }
        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();
        }
        /*
        public IEnumerable<PayModeModel> GetAll()
        {
            throw new NotImplementedException();
        }
        */
        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
