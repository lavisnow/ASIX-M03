using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Anagrama
{
    class DB
    {
        SqlConnection conn;

        public DB()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "User ID=sa;Password=sa;Initial Catalog=M3;Data Source=GT;Connect Timeout=3;";
            conn.Open();
        }

        public Boolean ExecutarSQL(String sql)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand sq = new SqlCommand(sql, conn);
            int res = sq.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
                return true;
            else
                return false;
        }

        public DataTable SQLtoDataGrid(String sql)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            SqlCommand sq = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(sq);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public String SQLtoValor(String sql)
        {
            String valor = "";
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            SqlDataReader sqlDR;
            SqlCommand sqlCMD = new SqlCommand(sql, conn);
            sqlDR = sqlCMD.ExecuteReader();
            if (sqlDR.HasRows)
            {
                if (sqlDR.Read())
                {
                    if (sqlDR[0] != System.DBNull.Value)
                    {
                        valor = sqlDR[0].ToString();
                    }
                }
            }
            conn.Close();
            return valor;
        }
    }
}
