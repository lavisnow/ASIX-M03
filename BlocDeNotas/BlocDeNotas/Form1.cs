using System;
using System.IO;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        string[] noms;
        string fitxer_noms = "noms.txt";
        int le; //llargada array 
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            nomsbebes();
            bt_triangle.Enabled = false;

        }

        private void nomsbebes()
        {
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
            sr.Close();
            sr = new StreamReader(fitxer_noms);
            noms = new string[c_noms];


            for (int i = 0; i < noms.Length; i++)
            {

                noms[i] = sr.ReadLine();
            }
            sr.Close();
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
            sr.Close();
        }

        private void bt_name_Click(object sender, EventArgs e)
        {
            int rand = rnd.Next(0, noms.Length);
            tx_notepad.Text = noms[rand];
        }

        private void bt_tri_gen_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(tx_name.Text);
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(rnd.Next(0, 20) + ";" + rnd.Next(0, 20) + ";" + rnd.Next(0, 20));
                le++;
            }
            sw.Close();

            bt_triangle.Enabled = true;
        }

        private void bt_triangle_Click(object sender, EventArgs e)
        {
            //Llegim el fitxer
            StreamReader sr = new StreamReader(tx_name.Text); ;
            string[] a;
            string linia;
            int[,] m = new int[le, 4];
            int i = 0;

            while (!sr.EndOfStream)
            {
                linia = sr.ReadLine();
                a = linia.Split(';');
                m[i, 0] = int.Parse(a[0]);
                m[i, 1] = int.Parse(a[1]);
                m[i, 2] = int.Parse(a[2]);
                i++;
            }
            sr.Close();

            //Escrivim al fitxer
            StreamWriter sw = new StreamWriter(tx_name.Text);

            for (int j = 0; j < m.GetLength(0); j++)
            {

                for (int h = 0; h < m.GetLength(1); h++)
                {
                    if (m[j, 0] + m[j, 1] > m[j, 2] && m[j, 2] + m[j, 0] > m[j, 1] && m[j, 1] + m[j, 2] > m[j, 0])
                        m[j, 3] = 0;
                    else
                        m[j, 3] = 1;
                }
                if (m[j, 3] == 0)
                {
                    sw.WriteLine(m[j, 0] + ";" + m[j, 1] + ";" + m[j, 2] + "--> Correcte");
                }
                else
                    sw.WriteLine(m[j, 0] + ";" + m[j, 1] + ";" + m[j, 2] + "-- > Incorrecte");

            }
            sw.Close();

            sr = new StreamReader(tx_name.Text);
            tx_notepad.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
