using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            bt_bolita.Enabled = false;

        }

        string[,] cartro = new string[4, 5];
        string[,] cartro2 = new string[4, 5];
        string[] bombo = new string[100];
        int bola = 0;
        bool linia = false;

        public static void Shuffle(string[] array)
        {

            Random rng = new Random();
            string temp;
            int n = array.Length;
            while (n > 1)
            {

                int k = rng.Next(n--);
                temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            int x = 0;
            bola = 0;

            for (int i = 0; i < bombo.Length; i++)
            {

                bombo[i] = (i + 1).ToString();
            }

            Shuffle(bombo);
            for (int i = 0; i < cartro.GetLength(0); i++)
            {

                for (int j = 0; j < cartro.GetLength(1); j++)
                {

                    cartro[i, j] = bombo[x];
                    x++;
                }
            }

            Shuffle(bombo);
            x = 0;
            for (int i = 0; i < cartro2.GetLength(0); i++)
            {

                for (int j = 0; j < cartro2.GetLength(1); j++)
                {

                    cartro2[i, j] = bombo[x];
                    x++;
                }
            }

            for (int i = 0; i < cartro.GetLength(0); i++)
            {

                for (int j = 0; j < cartro.GetLength(1); j++)
                {

                    textBox1.Text += "   " + cartro[i, j].ToString();
                    textBox3.Text += "   " + cartro2[i, j].ToString();
                }

                textBox1.Text += Environment.NewLine;
                textBox3.Text += Environment.NewLine;
            }




            Shuffle(bombo);
            bt_carton.Enabled = false;
            bt_bolita.Enabled = true;

        }

        private void bt_bolita_Click(object sender, EventArgs e)
        {
            bool win = true;
            bool win2 = true;
            bool linia1win = false;
            bool linia2win = false;
            int linia1 = 0;
            int linia2 = 0;

            textBox1.Text = "";
            textBox3.Text = "";          
            textBox2.Text = bombo[bola].ToString();

            for (int i = 0; i < cartro.GetLength(0); i++)
            {

                for (int j = 0; j < cartro.GetLength(1); j++)
                {
                    if (bombo[bola].Equals(cartro[i, j]))
                    {
                        cartro[i, j] = "X";
                    }
                    textBox1.Text += "   " + cartro[i, j];

                }
                textBox1.Text += Environment.NewLine;
            }


            for (int i = 0; i < cartro2.GetLength(0); i++)
            {

                for (int j = 0; j < cartro2.GetLength(1); j++)
                {

                    if (bombo[bola].Equals(cartro2[i, j]))
                    {
                        cartro2[i, j] = "X";
                    }
                    textBox3.Text += "   " + cartro2[i, j];

                }
                textBox3.Text += Environment.NewLine;
            }

            for (int i = 0; i < cartro.GetLength(0); i++)
            {
                linia1 = 0;
                linia2 = 0;

                for (int j = 0; j < cartro.GetLength(1); j++)
                {

                    if (!cartro[i, j].Equals("X"))
                    {
                        win = false;

                    }
                    else
                    {
                        if (!linia)
                        {
                            linia1++;
                            if (linia1 == cartro.GetLength(1))
                            {
                                linia1win = true;
                            }
                        }

                    }

                    if (!cartro2[i, j].Equals("X"))
                    {
                        win2 = false;

                    }
                    else
                    {
                        if (!linia)
                        {
                            linia2++;
                            if (linia2 == cartro.GetLength(1))
                            {
                                linia2win = true;
                            }
                        }
                    }
                }
            }


            if (linia1win)
            {

                MessageBox.Show("LINIA JUGADOR 1");
                linia = true;

            }
            else if (linia2win)
            {

                MessageBox.Show("LINIA JUGADOR 2");
                linia = true;

            }


            if (win)
            {

                textBox1.Text = "BINGGGOOOOO!!!!";
                textBox3.Text = "Has perdut!!!";
                bt_carton.Enabled = true;
                bt_bolita.Enabled = false;

            }

            if (win2)
            {

                textBox3.Text = "BINGGGOOOOO!!!!";
                textBox1.Text = "Has perdut!!!";
                bt_carton.Enabled = true;
                bt_bolita.Enabled = false;

            }

            bola++;
        }
    }
}


