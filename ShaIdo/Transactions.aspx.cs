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
      grd_transactions.DataSource = service.GetTransactions("Ido", "123a");
      grd_transactions.DataBind();
    }

    protected void grdTransactions_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}