using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbSQLSERVER
{
    public partial class Form1 : Form
    {
        db DB = new db();
        String[] dbnames;
        public Form1()
        {
            InitializeComponent();
            dbnames = DB.GetDatabaseList().ToArray();
            cb_dbnames.DataSource = dbnames;
            cb_dbnames.DisplayMember = dbnames.ToString();
        }

        private void bt_db_Click(object sender, EventArgs e)
        {
            DB.newconnection(cb_dbnames.SelectedItem.ToString());

            DB.CreateDB(tx_db.Text);
        }

        private void bt_table_Click(object sender, EventArgs e)
        {
            DB.newconnection(cb_dbnames.SelectedItem.ToString());
            DB.CreateTable(tx_table.Text);
        }

        private void cb_db_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            dbnames = DB.GetDatabaseList().ToArray();
            cb_dbnames.DataSource = dbnames;
            cb_dbnames.DisplayMember = dbnames.ToString();

        }
    }
}
