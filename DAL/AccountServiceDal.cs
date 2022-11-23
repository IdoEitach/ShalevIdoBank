using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShalevIdoBank.DAL
{
    public class AccountServiceDal
    {
        private SqlConnection connection;
        // create public constructor
        public AccountServiceDal()
        {
            this.connection = new SqlConnection(Database.connectionString);
            this.connection.Open();
        }

        public void Dispose()
        {
            this.connection.Close();
        }

        public double GetBalance(int accId)
        {
            SqlCommand cmd = new SqlCommand("spRetrieveBalance", connection);
            cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
            cmd.CommandType = CommandType.StoredProcedure;
            double res = (double)cmd.ExecuteScalar();
            return res;
        }

        public DataTable GetTransactions(int accId)
        {

            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("spGetTransactions", connection);
            cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            //load the data table
            dataTable.Load(reader);
            return dataTable;
        }

        static public bool PayThatBill(int accCode)
        {
            throw new NotImplementedException();
        }

    }
}