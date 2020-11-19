using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SopaLletres_DB
{

    class DB
    {
        SqlConnection conn;

        public DB()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=192.168.56.106;" +
                "Initial Catalog=test;" +
                "User id=sa;" +
                "Password=P@ssw0rd;";
            conn.Open();

        }

        public Boolean ExecuteSQL(String sql)
        {
            SqlCommand sq = new SqlCommand(sql, conn);
            int res = sq.ExecuteNonQuery();
            if (res > 0)
                return true;
            else
                return false;
        }


    }


}

