using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noms
{
    public partial class Form1 : Form
    {
        string[] noms;
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
            tx_main.Enabled = false;
            bt_save.Enabled = false;
            bt_load.Enabled = false;
            bt_esq.Enabled = false;
            bt_dret.Enabled = false;

        }

        private void bt_array_Click(object sender, EventArgs e)
        {
            try
            {
                noms = new String[int.Parse(tx_array.Text)];
            }
            catch {

                MessageBox.Show("Només s'ha accepten numeros");
            }
            tx_main.Enabled = true;
            bt_esq.Enabled = true;
            bt_dret.Enabled = true;
            bt_load.Enabled = true;
            bt_save.Enabled = true;


        }

        private void bt_esq_Click(object sender, EventArgs e)
        {
            noms[pos] = tx_main.Text;
            pos--;   
            if (pos < 0)
                pos = noms.Length -1;

            tx_main.Text = noms[pos];
        }

        private void bt_dret_Click(object sender, EventArgs e)
        {
            noms[pos] = tx_main.Text;
            pos++;

            if (pos == noms.Length)
                pos = 0;

            tx_main.Text = noms[pos];

        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("noms.txt");

            for (int i = 0; i < noms.Length; i++) {

                noms[i] = sr.ReadLine();

            }

            tx_main.Text = noms[0];

            sr.Close();
            bt_save.Enabled = true;

        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("noms.txt");
            for (int i = 0; i < noms.Length; i++)
            {
                if (!noms[i].Equals("")) {

                    sw.WriteLine(noms[i]);
                }

            }
            sw.Close();
        }

    }
}
