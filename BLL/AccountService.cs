using ShalevIdoBank.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShalevIdoBank.BLL
{
    public class AccountService
    {
        static public double GetBalance(int accId)
        {
            var service = new AccountServiceDal();
            var res = service.GetBalance(accId);
            service.Dispose();
            return res;
        }
        static public DataTable GetTransactions(int accId)
        {
            var service = new AccountServiceDal();
            var res = service.GetTransactions(accId);
            service.Dispose();
            return res;
        }
        static public void PayThatBill(int accId, string payee, double amount)
        {
            var service = new AccountServiceDal();
            service.PayThatBill(accId, payee, amount);
            
            service.Dispose();

            if (amount >= 100_000)
            {
                    
            }
        }
    }
}