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
            this.connection = new SqlConnection(SQLHelper.connectionString);
            this.connection.Open();
        }

        public void Dispose()
        {
            this.connection.Close();
        }

        public double GetBalance(int accId)
        {
            SqlCommand cmd = new SqlCommand("GetBalance", connection);
            cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
            cmd.CommandType = CommandType.StoredProcedure;
            double res = (double)cmd.ExecuteScalar();
            return res;
        }
        static public DataTable GetTransactions(int accCode)
        {
            throw new NotImplementedException();
        }
        static public bool PayThatBill(int accCode)
        {
            throw new NotImplementedException();
        }

    }
}