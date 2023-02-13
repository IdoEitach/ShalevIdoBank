﻿using ShalevIdoBank.DAL;
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
        static public double GetBalance(int accountId)
        {
            var service = new AccountServiceDal();
            var res = service.GetBalance(accountId);
            service.Dispose();
            return res;
        }
        static public DataTable GetTransactions(int accountId)
        {
            var service = new AccountServiceDal();
            var res = service.GetTransactions(accountId);
            service.Dispose();
            return res;
        }
        static public bool ValidateUser(string accountUserName, string password)
        {
            var service = new AccountServiceDal();
            var res = (service.ValidateUser(accountUserName, password));
            service.Dispose();
            return res;
        }
        static public bool PayThatBill(float amount, string description, string payingUserName, string payingPassword, string payeeUserName)
        {
            var service = new AccountServiceDal();
            if (!service.ValidateUser(payingUserName, payingPassword)) return false;

            int payingAccountId = service.GetAccountIdByUserName(payingUserName);
            int payeeAccountId = service.GetAccountIdByUserName(payeeUserName);

            if (AccountService.GetBalance(payingAccountId) < amount) return false;
            bool res = service.PayThatBill(amount, description, payingAccountId, payeeAccountId);


            // Send an Email
            if (amount >= 100_000)
            {
                string from = "bank@gmail.com";
                string to = service.GetAccountEmail(payingAccountId);
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
            return res;
        }
    }
}