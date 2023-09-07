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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SignOut_Click(object sender, EventArgs e)
    {
      Session["user"] = "";
      Response.Redirect("login.aspx");
    }
  }
}