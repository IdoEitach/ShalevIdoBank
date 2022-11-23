using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ShalevIdoBank
{
  static public class Database
  {
    static public string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
  }
}