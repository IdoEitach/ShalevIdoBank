using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ShalevIdoBank
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {

        [WebMethod]
        public void PayThatBill(int accId, string payee, double amount)
        {
            BLL.AccountService.PayThatBill(accId, payee, amount);
        }
    }
}
