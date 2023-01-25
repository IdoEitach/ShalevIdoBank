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
    private SqlTransaction transaction;

    // create public constructor
    public AccountServiceDal()
    {
      this.connection = new SqlConnection(Database.connectionString);
      this.connection.Open();
      this.transaction = null;
    }

    public void Dispose()
    {
      this.connection.Close();
    }

    public string GetAccountEmail(int accId)
    {
      SqlCommand cmd = new SqlCommand("spGetAccountEmail", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
      cmd.CommandType = CommandType.StoredProcedure;
      string res = (string)cmd.ExecuteScalar();
      return res;
    }

    public double GetBalance(int accId)
    {
      SqlCommand cmd = new SqlCommand("spRetrieveBalance", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
      cmd.CommandType = CommandType.StoredProcedure;
      double res = (double)cmd.ExecuteScalar();
      return res;
    }

    public DataTable GetTransactions(int accId)
    {

      DataTable dataTable = new DataTable();
      SqlCommand cmd = new SqlCommand("spGetTransactions", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataReader reader = cmd.ExecuteReader();
      //load the data table
      dataTable.Load(reader);
      return dataTable;
    }

    public void PayThatBill(int accId, string payee, double amount)
    {
      transaction = connection.BeginTransaction();
      try
      {
        SqlCommand cmd = new SqlCommand("spInsertTransaction", connection, transaction);
        cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = DateTime.Now.ToString();
        cmd.Parameters.Add("@amount", SqlDbType.Float).Value = amount;
        cmd.Parameters.Add("@payee", SqlDbType.NVarChar).Value = payee;
        cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteScalar();

        cmd = new SqlCommand("spUpdateBalance", connection, transaction);
        cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accId;
        cmd.Parameters.Add("@newBalance", SqlDbType.Float).Value = GetBalance(accId) - amount;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteScalar();

        transaction.Commit();
      }
      catch (Exception ex)
      {
        transaction.Rollback();
        throw ex;
      }
      finally
      {
        transaction = null;
      }
    }
  }
}