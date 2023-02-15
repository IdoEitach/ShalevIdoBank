using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace ShalevIdoBank.DAL
{
  public class AccountServiceDal
  {
    private SqlConnection connection;
    private SqlTransaction transaction;
    private Random random;

    // create public constructor
    public AccountServiceDal()
    {
      this.connection = new SqlConnection(Database.connectionString);
      this.connection.Open();
      this.transaction = null;
      this.random = new Random();
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
      float res = Convert.ToSingle(cmd.ExecuteScalar()); // Convert to float
      return res;
    }
    public bool ValidateUser(string accountUserName, string password)
    {
      DataTable dataTable = new DataTable();
      SqlCommand cmd = new SqlCommand("spValidateUser", connection, transaction);
      cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = accountUserName;
      cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataReader reader = cmd.ExecuteReader();
      //load the data table
      dataTable.Load(reader);
      return dataTable.Rows.Count > 0;
    }
    public int GetAccountIdByUserName(string accountUserName)
    {
      SqlCommand cmd = new SqlCommand("spGetAccountIdByUsername", connection, transaction);
      cmd.Parameters.Add("@accountUserName", SqlDbType.NVarChar).Value = accountUserName;
      cmd.CommandType = CommandType.StoredProcedure;
      int res = (int)cmd.ExecuteScalar();
      return res;
    }
    public Dictionary<int, string> GetAllAccountUsernames()
    {
      DataTable dataTable = new DataTable();
      SqlCommand cmd = new SqlCommand("spGetAllAccountUsernames", connection, transaction);
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataReader reader = cmd.ExecuteReader();
      //load the data table
      dataTable.Load(reader);
      Dictionary<int, string> idsUsernames = new Dictionary<int, string>();
      
      for (int i = 0; i < dataTable.Rows.Count; i++)
      {
         idsUsernames.Add((int)dataTable.Rows[i][0], dataTable.Rows[i][1] as string);
      }

      return idsUsernames;
    }

    public void UpdateBalance(int accountId, float newBalance)
    {
      SqlCommand cmd = new SqlCommand("spUpdateBalance", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
      cmd.Parameters.Add("@newBalance", SqlDbType.Int).Value = newBalance;
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.ExecuteNonQuery();

    }

    private string RandomDigits(int length)
    {
      string s = string.Empty;
      for (int i = 0; i < length; i++)
        s = String.Concat(s, this.random.Next(10).ToString());
      return s;
    }

    public void InsertTransaction(float amount, string description, int payingAccountId, int payeeAccountId)
    {
      SqlCommand cmd = new SqlCommand("spInsertTransaction", connection, transaction);
      cmd.Parameters.Add("@date", SqlDbType.NVarChar).Value = DateTime.Now.ToString();
      cmd.Parameters.Add("@amount", SqlDbType.Float).Value = amount;
      cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
      cmd.Parameters.Add("@checkNumber", SqlDbType.NVarChar).Value = RandomDigits(10);
      cmd.Parameters.Add("@payingAccountId", SqlDbType.Int).Value = payingAccountId;
      cmd.Parameters.Add("@payeeAccountId", SqlDbType.Int).Value = payeeAccountId;
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.ExecuteNonQuery();

    }

    public DataTable GetTransactions(int accountId)
    {
      Dictionary<int, string> idsUsernames = GetAllAccountUsernames();
      DataTable dataTable = new DataTable();
      SqlCommand cmd = new SqlCommand("spGetTransactions", connection, transaction);
      cmd.Parameters.Add("@accountId", SqlDbType.Int).Value = accountId;
      cmd.CommandType = CommandType.StoredProcedure;
      SqlDataReader reader = cmd.ExecuteReader();
      //load the data table
      dataTable.Load(reader);

      DataTable dtCloned = dataTable.Clone();
      dtCloned.Columns[5].DataType = typeof(string);
      dtCloned.Columns[6].DataType = typeof(string);
      dtCloned.Columns[5].ColumnName = "Paying Account";
      dtCloned.Columns[6].ColumnName = "Payee Account";
      for (int i = 0; i < dataTable.Rows.Count; i++)
      {
        // row[5] = idsUsernames[(int)row[5]];
        // row[6] = idsUsernames[(int)row[6]];


        dtCloned.ImportRow(dataTable.Rows[i]);
        dtCloned.Rows[i][5] = idsUsernames[(int)dataTable.Rows[i][5]];
        dtCloned.Rows[i][6] = idsUsernames[(int)dataTable.Rows[i][6]];
      }

      return dtCloned;
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