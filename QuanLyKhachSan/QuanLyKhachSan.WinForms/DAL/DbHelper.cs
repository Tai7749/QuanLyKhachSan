using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyKhachSan.WinForms.DAL
{
    internal class DbHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}
