using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaIdo
{
  public partial class Transactions : System.Web.UI.Page
  {
    private bank.ClientBankService service = new bank.ClientBankService();

    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["user"] == null || Session["user"] == "") Response.Redirect("Login.aspx");
      if (Session["pass"] == null || Session["pass"] == "") Response.Redirect("Login.aspx");
      grd_transactions.DataSource = service.GetTransactions(Session["user"] as string, Session["pass"] as string);
      grd_transactions.DataBind();
    }

    protected void grdTransactions_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}