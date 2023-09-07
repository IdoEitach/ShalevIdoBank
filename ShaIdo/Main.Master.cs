using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaIdo
{
  public partial class Main : System.Web.UI.MasterPage
  {
        private bank.ClientBankService service = new bank.ClientBankService();


        protected void Page_Load(object sender, EventArgs e)
    {
            if (Session["user"] != null && Session["user"] != "" &&
                Session["pass"] != null && Session["pass"] != "")
            {
                Session["amount"] = service.RetrieveBalance(Session["user"] as string, Session["pass"] as string).ToString() + "₪";
            } else
            {
                Session["amount"] = "0₪";
            }
    }

    protected void SignOut_Click(object sender, EventArgs e)
    {
      Session["user"] = "";
      Response.Redirect("login.aspx");
    }
  }
}