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


namespace EndavinaParaula
{
    public partial class Form1 : Form
    {
        string[] paraules;
        string paraula;
        string paraulamagada;
        int aletori;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("Paraules.txt");
            string linia;
            int count = 0;
            while ((sr.ReadLine()) != null)
            {

                linia = sr.ReadToEnd();
                paraules = linia.Split(';');
            }
            sr.Close();
            sr = new StreamReader("Paraules.txt");
            while ((sr.ReadLine()) != null)
            {

                count++;
            }
            sr.Close();

            do
            {
                aletori = rnd.Next(count);
            } while ((aletori % 2) != 0);

            paraula = paraules[aletori];

            for (int i = 0; i < paraula.Length; i++)
            {
                paraulamagada += "#";

            }

            tx_endavina.Text = paraulamagada;
        }

        private void bt_juga_Click(object sender, EventArgs e)
        {
            tx_endavina.Text = "";

            try
            {
                string lletra = tx_paraula.Text.ToUpper();

                if (paraula.Contains(lletra))
                {

                    for (int i = 0; i < paraula.Length; i++)
                    {

                        string subA = paraula.Substring(i, 1);
                        string subB = paraulamagada.Substring(i, 1);

                        if (subA.Equals(lletra))
                        {

                            tx_endavina.Text += subA;

                        }
                        else
                            tx_endavina.Text += subB;
                    }
                    paraulamagada = tx_endavina.Text;
                }
                tx_endavina.Text = paraulamagada;
            }
            catch {

                MessageBox.Show("Escriu només lletres");
            
            }

        }

        private void bt_pista_Click(object sender, EventArgs e)
        {
            tx_pista.Text = paraules[aletori + 1];
        }

        private void bt_endavina_Click(object sender, EventArgs e)
        {
            if (tx_pista.Text.Equals(paraula)) {

                MessageBox.Show("Endavinat!!!");
            
            }else
                MessageBox.Show("Para incorrecte");

        }
    }
}
