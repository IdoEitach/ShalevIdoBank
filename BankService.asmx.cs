using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShalevIdoBank
{
    /// <summary>
    /// Summary description for BankService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BankService : System.Web.Services.WebService
    {

        [WebMethod]
        public double GetBalance(int accountId)
        {
            return BLL.AccountService.GetBalance(accountId);
        }

        // [WebMethod]
        // public DataTable GetTransactions(int accountId)
        // {
        //     return BLL.AccountService.GetTransactions(accountId);
        // }
    }
}
