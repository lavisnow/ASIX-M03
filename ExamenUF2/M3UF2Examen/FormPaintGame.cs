using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3UF2Examen
{
    public partial class FormPaintGame : Form
    {
        string[,] tauler = new string[6, 10];
        int x;
        int y;
        int punts = 0;
        bool final = false;
        Random rnd = new Random();

        public FormPaintGame()
        {
            InitializeComponent();

            for (int i = 0; i < tauler.GetLength(0); i++)
            {

                for (int j = 0; j < tauler.GetLength(1); j++)
                {

                    tauler[i, j] = "[ ]";
                    txResultat.Text += tauler[i, j];
                }

                txResultat.Text += Environment.NewLine;
            }

            bt1.Enabled = false;
            bt2.Enabled = false;
            bt3.Enabled = false;
            bt4.Enabled = false;
            bt5Objectes.Enabled = false;

        }

        private void imprimir()
        {
            for (int i = 0; i < tauler.GetLength(0); i++)
            {

                for (int j = 0; j < tauler.GetLength(1); j++)
                {

                    txResultat.Text += tauler[i, j];
                }

                txResultat.Text += Environment.NewLine;
            }

        }

        private void victoria()
        {

            bool victoria = true;

            for (int i = 0; i < tauler.GetLength(0); i++)
            {

                for (int j = 0; j < tauler.GetLength(1); j++)
                {
                    if (tauler[i, j].Equals("[ ]"))
                    {

                        victoria = false;

                    }

                }

                txResultat.Text += Environment.NewLine;
            }

            if (victoria)
            {

                MessageBox.Show("Has guanyat");
                bt1.Enabled = false;
                bt2.Enabled = false;
                bt3.Enabled = false;
                bt4.Enabled = false;
            }

        }

        private void finaltauler(bool fi)
        {

            if (fi)
            {

                MessageBox.Show("Final del tauler");
                final = false;

            }

        }

        private void punt()
        {

            if (tauler[x, y].Equals("[@]"))
            {

                punts += 10;
            }

            txMarcador.Text = punts.ToString();

        }


        private void btColoca_Click(object sender, EventArgs e)
        {
            txResultat.Text = "";
            try
            {
                x = int.Parse(txX.Text) - 1;
                y = int.Parse(txY.Text) - 1;

                if (tauler[x, y].Equals("[ ]"))
                {

                    tauler[x, y] = "[O]";

                }


                btColoca.Enabled = false;
            }
            catch
            {

                MessageBox.Show("Els valors han de ser numerics i entre: " + tauler.GetLength(0) + " - " + tauler.GetLength(1));

            }

            imprimir();

            bt1.Enabled = true;
            bt2.Enabled = true;
            bt3.Enabled = true;
            bt4.Enabled = true;
            bt5Objectes.Enabled = true;
        }

        private void bt2_Click(object sender, EventArgs e) //Pass →
        {
            txResultat.Text = "";
            y++;
            if (y < tauler.GetLength(1))
            {

                if (chkDuplicarPassada.Checked)
                {
                    punt();
                    tauler[x, y] = "[O]";
                    y--;
                    tauler[x, y] = "[#]";
                    y++;

                }
                else
                {
                    if (tauler[x, y].Equals("[#]"))
                    {
                        MessageBox.Show("Ja has passat per aqui");
                        y--;

                    }
                    else
                    {

                        punt();
                        tauler[x, y] = "[O]";
                        y--;
                        tauler[x, y] = "[#]";
                        y++;

                    }

                }

            }
            else
            {
                MessageBox.Show("Final del tauler");
                y = tauler.GetLength(1) -1;
            }

            imprimir();
            victoria();
            finaltauler(final);


        }

        private void bt1_Click(object sender, EventArgs e) // Pass ←
        {
            txResultat.Text = "";
            y--;
            if (y >= 0)
            {

                if (chkDuplicarPassada.Checked)
                {
                    punt();
                    tauler[x, y] = "[O]";
                    y++;
                    tauler[x, y] = "[#]";
                    y--;

                }
                else
                {
                    if (tauler[x, y].Equals("[#]"))
                    {
                        MessageBox.Show("Ja has passat per aqui");
                        y++;

                    }
                    else
                    {

                        punt();
                        tauler[x, y] = "[O]";
                        y++;
                        tauler[x, y] = "[#]";
                        y--;

                    }

                }

            }
            else
            {
                MessageBox.Show("Final del tauler");
                y = 0;
            }

            imprimir();
            victoria();
            finaltauler(final);

        }

        private void bt3_Click(object sender, EventArgs e) //Pass ↑
        {
            txResultat.Text = "";
            x--;
            if (x >= 0)
            {

                if (chkDuplicarPassada.Checked)
                {
                    punt();
                    tauler[x, y] = "[O]";
                    x++;
                    tauler[x, y] = "[#]";
                    x--;

                }
                else
                {
                    if (tauler[x, y].Equals("[#]"))
                    {
                        MessageBox.Show("Ja has passat per aqui");
                        x++;

                    }
                    else
                    {

                        punt();
                        tauler[x, y] = "[O]";
                        x++;
                        tauler[x, y] = "[#]";
                        x--;

                    }

                }

            }
            else
            {
                MessageBox.Show("Final del tauler");
                x = 0;
            }

            imprimir();
            victoria();
            finaltauler(final);

        }

        private void bt4_Click(object sender, EventArgs e) //Pass ↓
        {
            txResultat.Text = "";
            x++;
            if (x < tauler.GetLength(0))
            {

                if (chkDuplicarPassada.Checked)
                {
                    punt();
                    tauler[x, y] = "[O]";
                    x--;
                    tauler[x, y] = "[#]";
                    x++;

                }
                else
                {
                    if (tauler[x, y].Equals("[#]"))
                    {
                        MessageBox.Show("Ja has passat per aqui");
                        x--;

                    }
                    else
                    {

                        punt();
                        tauler[x, y] = "[O]";
                        x--;
                        tauler[x, y] = "[#]";
                        x++;

                    }

                }

            }
            else
            {
                MessageBox.Show("Final del tauler");
                x = tauler.GetLength(0) - 1;
            }

            imprimir();
            victoria();
            finaltauler(final);

        }

        private void bt5Objectes_Click(object sender, EventArgs e)
        {

            txResultat.Text = "";

            for (int i = 0; i < 5; i++)
            {
                int objecteX = rnd.Next(tauler.GetLength(0));
                int objecteY = rnd.Next(tauler.GetLength(1));
                if (tauler[objecteX, objecteY].Equals("[ ]"))
                {
                    tauler[objecteX, objecteY] = "[@]";
                }
                else
                    i--;

            }

            imprimir();
            bt5Objectes.Enabled = false;
        }

        private void btJugadaInfernal_Click(object sender, EventArgs e)
        {
            int infernalX = rnd.Next(tauler.GetLength(0));
            int infernalY = rnd.Next(tauler.GetLength(1));
            txResultat.Text = "";

            if (tauler[infernalX, infernalY].Equals("[O]"))
            {
                MessageBox.Show("DECEASED, GAME OVER");
                bt1.Enabled = false;
                bt2.Enabled = false;
                bt3.Enabled = false;
                bt4.Enabled = false;
                btJugadaInfernal.Enabled = false;
            }
            else if (tauler[infernalX, infernalY].Equals("[@]"))
            {

                tauler[infernalX, infernalY] = "[ ]";
                MessageBox.Show("OBJECTE DESTRUIT");
            }
            else if (tauler[infernalX, infernalY].Equals("[#]"))
            {
                tauler[infernalX, infernalY] = "[ ]";
            }

            imprimir();
        }
    }
}
