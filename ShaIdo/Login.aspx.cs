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
    public partial class Login2 : System.Web.UI.Page
    {
        private bank.ClientBankService service = new bank.ClientBankService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null && Session["user"] != "") Response.Redirect("Transactions.aspx");
            Session["error_login"] = "";
        }

        protected void btn_login(object sender, EventArgs e)
        {
            string username = txtbox_username.Text;
            string password = txtbox_password.Text;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            bool succecd = service.ValidLogin(username, password);
            if (succecd)
            {
                Session["user"] = username;
                Session["pass"] = password;
                Response.Redirect("Transactions.aspx");
            }
            else
            {
                Session["error_login"] = "Username or password incorrect.";
            }
        }
    }
}