using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SopaLletres_DB
{
    public partial class Form1 : Form
    {
        String[,] sopa;
        // DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            sr = new StreamReader("Sopa.txt");
            string linia;
            sopa = new string[14, 14];
            int moveY = 0;
            String[] x;
            while (!sr.EndOfStream)
            {
                linia = sr.ReadLine();
                x = linia.Split(' ');
                if (moveY < 15)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        sopa[moveY, i] = x[i];
                    }
                }

                moveY++;
            }
            sr.Close();

            for (int i = 0; i < sopa.GetLength(0); i++)
            {

                for (int j = 0; j < sopa.GetLength(1); j++)
                {

                    dataGridView1[i, j].Value += sopa[i, j];
                }

                tx_main.Text += Environment.NewLine;
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            String paraula = tx_main.SelectedText.Replace(" ", "");
            bool check = false;
            StreamReader sr;
            sr = new StreamReader("Paraules.txt");
            string linia;
            while (!sr.EndOfStream)
            {
                linia = sr.ReadLine();
                if (paraula.Equals(linia))
                    check = true;
            }
            sr.Close();

            if (check)
                tx_result.Text += tx_main.SelectedText + Environment.NewLine;
            else
                MessageBox.Show("Paraula incorrecte");
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
        }
    }
}
