using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace ShaIdo
{
    public static class Extensions
    {
        public static string ToCSV(this DataTable dtDataTable)
        {
            string final = "";
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                final += dtDataTable.Columns[i];
                if (i < dtDataTable.Columns.Count - 1)
                {
                    final += ",";
                }
            }
            final += "\n";
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            final += value;
                        }
                        else
                        {
                            final += dr[i].ToString();
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        final += ",";
                    }
                }
                final += "\n";
            }
            return final;
        }
    }
}