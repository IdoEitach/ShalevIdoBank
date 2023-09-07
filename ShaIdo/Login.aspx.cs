using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaIdo
{
    public partial class Login : System.Web.UI.Page
    {
        private bank.ClientBankService service = new bank.ClientBankService();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["error_login"] = "";
        }

        protected void btn_login(object sender, EventArgs e)
        {
            string username = txtbox_username.Text;
            string password = txtbox_password.Text;

            bool succecd = service.ValidLogin(username, password);
            if (succecd)
            {
                Response.Redirect("Transactions.aspx");
                Session["user"] = username;
            }
            else
            {
                Session["error_login"] = "Username or password incorrect.";
            }
        }
    }
}