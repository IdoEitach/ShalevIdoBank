﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShalevIdoBank
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(BLL.AccountService.GetBalance(1));
            Response.Write(BLL.AccountService.GetTransactions(1).Rows);
        }
    }
}