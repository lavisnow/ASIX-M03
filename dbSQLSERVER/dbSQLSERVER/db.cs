using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbSQLSERVER
{

    class db
    {
        SqlConnection conn;

        public db()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=192.168.56.106;" +
                "Initial Catalog=master;" +
                "User id=sa;" +
                "Password=P@ssw0rd;";
            conn.Open();

        }

        public void newconnection(string dbname)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=192.168.56.106;" +
        "Initial Catalog=" + dbname + ";" +
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


        public void CreateDB(String dbName)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            String sql = "CREATE DATABASE " + dbName;
            ExecuteSQL(sql);
        }

        public void CreateTable(String table)
        {
            String sql = "CREATE TABLE " + table + " (varchar(50))";
            ExecuteSQL(sql);
        }

        public List<String> GetDatabaseList()
        {

            List<string> list = new List<string>();

            string conString = "Data Source=192.168.56.106;" +
                "Initial Catalog=master;" +
                "User id=sa;" +
                "Password=P@ssw0rd;";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;

        }

    }


}

