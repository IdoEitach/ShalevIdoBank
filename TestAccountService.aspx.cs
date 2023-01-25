using System;
using ShalevIdoBank.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ShalevIdoBank
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Testing PayThatBill + GetBalance
            Response.Write("Before running \"PayThatBill\" on Account 1. Current amount: " + AccountService.GetBalance(1).ToString() + "<br/>");
            AccountService.PayThatBill(1, "Ido", 122.15);
            Response.Write("After running \"PayThatBill\" on Account 1. Current amount: " + AccountService.GetBalance(1).ToString() + "<br/>");
            
            // Testing GetTransactions
            Response.Write("<br/><br/>All transactions:<br/>");

            DataTable table = BLL.AccountService.GetTransactions(1);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Response.Write(table.Rows[i][j].ToString() + " |  ");
                }
                Response.Write("<br/>");
            }
        }
    }
}