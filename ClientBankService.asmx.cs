﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShalevIdoBank
{
    /// <summary>
    /// Summary description for ClientBankService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ClientBankService : System.Web.Services.WebService
    {

        [WebMethod]
        public bool PayThatBill(int accountId, string payee, float amount)
        {
            return BLL.AccountService.PayThatBill(accountId, payee, amount);
        }
    }
}
