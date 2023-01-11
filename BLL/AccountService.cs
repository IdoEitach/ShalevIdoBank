using ShalevIdoBank.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
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
      if (AccountService.GetBalance(accId) < amount) return;

      service.PayThatBill(accId, payee, amount);

      // Send an Email
      if (amount >= 100_000)
      {
        string from = "bank@gmail.com";
        string to = service.GetAccountEmail(accId);
        MailMessage message = new MailMessage(from, to);

        string mailbody = "Your account has been billed a total of " + amount.ToString() + " money.";
        message.Subject = "Warning! Your bank account has been billed more than 100,000 money.";
        message.Body = mailbody;
        message.BodyEncoding = Encoding.UTF8;
        message.IsBodyHtml = true;
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Gmail smtp    
        System.Net.NetworkCredential basicCredential1 = new
        System.Net.NetworkCredential("yourmail id", "Password");
        client.EnableSsl = true;
        client.UseDefaultCredentials = false;
        client.Credentials = basicCredential1;
        try
        {
          client.Send(message);
        }
        catch (Exception ex)
        {
          // Couldn't send Email.
          throw ex;
        }
      }

      service.Dispose();
    }
  }
}