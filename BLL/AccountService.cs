using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShalevIdoBank.BLL
{
    public class AccountService
    {
        static public double GetBalance(int accCode)
        {
            return DAL.AccountServiceDal.GetBalance(accCode);
        }
        static public DataTable GetTransactions(int accCode)
        {
            return DAL.AccountServiceDal.GetTransactions(accCode);

        }
        static public bool PayThatBill(int accCode)
        {
            return DAL.AccountServiceDal.PayThatBill(accCode);

        }
    }
}