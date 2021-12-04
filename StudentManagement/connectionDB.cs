using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentManagement
{
    class connectionDB
    {
        public static SqlConnection conString() 
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FBMUVKM\SQLEXPRESS;Initial Catalog=LMU_SEP_2021;Integrated Security=True");
            return conn;
        }
    }
}
