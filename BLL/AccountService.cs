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
    static public bool PayThatBill(int accId)
    {
      return DAL.AccountServiceDal.PayThatBill(accId);

    }
  }
}