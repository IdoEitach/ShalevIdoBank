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

    public string GetAccountEmail(int accountId)
    {
      SqlCommand cmd = new SqlCommand("spGetAccountEmail", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
      cmd.CommandType = CommandType.StoredProcedure;
      string res = (string)cmd.ExecuteScalar();
      return res;
    }

    public float GetBalance(int accountId)
    {
      SqlCommand cmd = new SqlCommand("spRetrieveBalance", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
      cmd.CommandType = CommandType.StoredProcedure;
      float res = (float)cmd.ExecuteScalar();
      return res;
    }
    public void UpdateBalance(int accountId, float newBalance)
    {
      SqlCommand cmd = new SqlCommand("spUpdateBalance", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
      cmd.Parameters.Add("@newBalance", SqlDbType.Int).Value = newBalance;
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.ExecuteNonQuery();

    }

    public void InsertTransaction(float amount, string description, int payingAccountId, int payeeAccountId)
    {
      SqlCommand cmd = new SqlCommand("spInsertTransaction", connection, transaction);
      cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = DateTime.Now.ToString();
      cmd.Parameters.Add("@amount", SqlDbType.Float).Value = amount;
      cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
      cmd.Parameters.Add("@payingAccountId", SqlDbType.Int).Value = payingAccountId;
      cmd.Parameters.Add("@payingAccountId", SqlDbType.Int).Value = payeeAccountId;
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.ExecuteNonQuery();

    }

    public DataTable GetTransactions(int accountId)
    {

      DataTable dataTable = new DataTable();
      SqlCommand cmd = new SqlCommand("spGetTransactions", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataReader reader = cmd.ExecuteReader();
      //load the data table
      dataTable.Load(reader);
      return dataTable;
    }

    public bool PayThatBill(float amount, string description, int payingAccountId, int payeeAccountId)
    {
      transaction = connection.BeginTransaction();
      try
      {
        InsertTransaction(amount, description, payingAccountId, payeeAccountId);

        UpdateBalance(payingAccountId, GetBalance(payingAccountId) - amount);
        UpdateBalance(payeeAccountId, GetBalance(payeeAccountId) + amount);

        transaction.Commit();
      }
      catch (Exception)
      {
        transaction.Rollback();
        return false;
      }
      finally
      {
        transaction = null;
      }
      return true;
    }
  }
}