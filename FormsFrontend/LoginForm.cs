using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsFrontend
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private bool isValidLogin(string username, string password)
    {
      using (SqlConnection connection = new SqlConnection(Database.connectionString))
      {
        try
        {
          connection.Open();
          DataTable dataTable = new DataTable();
          SqlCommand cmd = new SqlCommand("spValidLogin", connection);
          cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
          cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
          cmd.CommandType = CommandType.StoredProcedure;
          SqlDataReader reader = cmd.ExecuteReader();
          //load the data table
          dataTable.Load(reader);
          return dataTable.Rows.Count == 1;
        }
        finally
        {
          connection.Close();
        }
      }
    }

    private void btn_login_Click(object sender, EventArgs e)
    {
      if (isValidLogin(txtbox_username.Text, txtbox_password.Text))
      {
        DashboardForm dashboardForm = new DashboardForm(txtbox_username.Text);
        dashboardForm.ShowDialog();
        txtbox_username.Text = null;
        txtbox_password.Text = null;
      } else
      {
        MessageBox.Show("Wrong username or password", "error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
