using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
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

            if (!IsPostBack)
            {
                DataTable dt = service.GetTransactions(Session["user"] as string, Session["pass"] as string);
                grd_transactions.EditIndex = -1;

                grd_transactions.DataSource = dt;
                grd_transactions.DataBind();
            }
                
        }

        protected void ToCSV_Click(object sender, EventArgs e)
        {
            DataTable dt = service.GetTransactions(Session["user"] as string, Session["pass"] as string);

            Response.ClearContent();
            Response.Clear();
            Response.ContentType = "text/plain";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + "Transactions.csv" + ";");
            Response.Write(dt.ToCSV());
            Response.Flush();
            Response.End();
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            Session["start_date"] = Request.Form["startDate"].Length > 2 ? Request.Form["startDate"] : null;
            Session["end_date"] = Request.Form["endDate"].Length > 2 ? Request.Form["endDate"] : null;

            DataTable dt = service.GetTransactions(Session["user"] as string, Session["pass"] as string);

            DateTime start = DateTime.Parse(Session["start_date"] as string ?? "1/1/1970");
            DateTime end = DateTime.Parse(Session["end_date"] as string ?? "1/1/3000").AddDays(1);

            var rows = dt.AsEnumerable().Where((row) =>
            {
                DateTime date = DateTime.Parse(row.Field<String>("DatePosted"));
                return date >= start && date <= end;
            });

            dt = rows.Any() ? rows.CopyToDataTable() : dt.Clone();
 
            grd_transactions.DataSource = dt;
            grd_transactions.DataBind();
        }

        protected void grd_transactions_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grd_transactions.EditIndex = e.NewEditIndex;
            DataTable dt = service.GetTransactions(Session["user"] as string, Session["pass"] as string);
            grd_transactions.DataSource = dt;
            //grd_transactions.DataSource = dt;

            grd_transactions.DataBind();

        }

        protected void grd_transactions_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow gvr = grd_transactions.Rows[e.RowIndex];
            service.ChangeTransactionDescription(Session["user"] as string, Session["pass"] as string, int.Parse(gvr.Cells[1].Text), e.NewValues["Description"] as string);

            DataTable dt = service.GetTransactions(Session["user"] as string, Session["pass"] as string);

            grd_transactions.EditIndex = -1;
            grd_transactions.DataSource = dt;
            grd_transactions.DataBind();

        }

        protected void grd_transactions_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
        }

        protected void grd_transactions_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            DataTable dt = service.GetTransactions(Session["user"] as string, Session["pass"] as string);

            grd_transactions.EditIndex = -1;
            grd_transactions.DataSource = dt;
            grd_transactions.DataBind();
        }
    }
}