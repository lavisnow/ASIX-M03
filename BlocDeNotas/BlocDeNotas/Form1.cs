using System;
using System.IO;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        string[] noms;
        string fitxer_noms = "noms.txt";

        public Form1()
        {
            InitializeComponent();
            nomsbebes();
        }

        private void nomsbebes(){
            StreamReader sr;
            sr = new StreamReader(fitxer_noms);
            int c_noms = 0;
            string linia;
            do
            {
                linia = sr.ReadLine();

                c_noms++;
            }
            while (linia != null);

            sr = new StreamReader(fitxer_noms);
            noms = new string[c_noms];


            for (int i = 0; i < noms.Length; i++)
            {

                noms[i] = sr.ReadLine();
            }
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            tx_notepad.Text = "";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            sw = new StreamWriter(tx_name.Text);
            sw.Write(tx_notepad.Text);
            sw.Close();

        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            sr = new StreamReader(tx_name.Text);
            tx_notepad.Text = sr.ReadToEnd();
            sr.Close();
            
        }

        private void bt_count_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            sr = new StreamReader(tx_name.Text);
            int compt = 0;
            string linia;
            do
            {
                linia = sr.ReadLine();
                compt++;
            }
            while (linia != null);

            tx_notepad.Text = compt.ToString();
        }

        private void bt_name_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, noms.Length);
            tx_notepad.Text = noms[rand];
        }
    }
}