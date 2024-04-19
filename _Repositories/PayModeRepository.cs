using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

           // throw new NotImplementedException();
        using (var connection = new SqlConnection())
        using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;                                                
                command.CommandText = "INSERT INTO PayMode Values (@Name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Name;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
            using (var connection = new SqlConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM PayMode WHERE  Pay_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(PayModeModel payModeModel)
        {

           // throw new NotImplementedException();
           using(var connection = new SqlConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;   //SE VE MAL ESA LINEA DE CODIGO ASI PERO ME TOCO NO ME DEJABA HACERLO COMO EN LA GUIA
                command.CommandText = "@UPDATE PayMode SET Pay_Mode_Name = @name, Pay_Mode_Observation = @observation WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Name;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeModel.Id;
                command.ExecuteNonQuery();                                                                                        

            }
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
