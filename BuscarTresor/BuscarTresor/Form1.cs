using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscarTresor
{
    public partial class Form1 : Form
    {
        int MidaX = 0;
        int MidaY = 0;
        string[,] treasure;
        int count;
        int prizeX;
        int prizeY;

        public Form1()
        {
            InitializeComponent();
            tx_main.ReadOnly = true;
            tx_try.ReadOnly = true;
            bt_Search.Enabled = false;
            tx_x.Enabled = false;
            tx_y.Enabled = false;

        }


        private void bt_create_Click(object sender, EventArgs e)
        {
            try
            {
                tx_main.Text = "";
                MidaX = int.Parse(tx_MidaX.Text);
                MidaY = int.Parse(tx_MidaY.Text);
                treasure = new string[MidaX, MidaY];
                count = treasure.Length / 2;

                if (MidaX >= 2 && MidaY >= 2)
                {

                    for (int i = 0; i < treasure.GetLength(0); i++)
                    {

                        for (int j = 0; j < treasure.GetLength(1); j++)
                        {

                            treasure[i, j] = "O";
                            tx_main.Text += "   " + treasure[i, j];
                        }
                        tx_main.Text += Environment.NewLine;
                    }

                    tx_try.Text = count.ToString();
                }
                else
                    MessageBox.Show("Les mides han de ser mes gran que 2x2");


                Random rnd = new Random();

                prizeX = rnd.Next(0, treasure.GetLength(0));
                prizeY = rnd.Next(0, treasure.GetLength(1));
                bt_Search.Enabled = true;
                tx_x.Enabled = true;
                tx_y.Enabled = true;

                tx_MidaX.Enabled = false;
                tx_MidaY.Enabled = false;
                bt_create.Enabled = false;

            }
            catch
            {

                MessageBox.Show("Escriu una mida valida, recorda nomes numeros!!!");

            }



        }

        private void bt_Search_Click_1(object sender, EventArgs e)
        {

            try
            {
                int x = int.Parse(tx_x.Text) - 1;
                int y = int.Parse(tx_y.Text) - 1;

                bool prize = false;

                tx_main.Text = "";

                if (x < treasure.GetLength(0) && y < treasure.GetLength(1) && x >= 0 && y >= 0)
                {

                    for (int i = 0; i < treasure.GetLength(0); i++)
                    {

                        for (int j = 0; j < treasure.GetLength(1); j++)
                        {

                            if (prizeX == x && prizeY == y)
                            {

                                if (x == i && y == j)
                                {

                                    treasure[i, j] = "T";
                                    prize = true;

                                }

                            }
                            else if (x == i && y == j)
                            {
                                if (treasure[i, j].Equals("X"))
                                {
                                    MessageBox.Show("Ubicació ja buscada, has perdut un intent");
                                    count--;
                                }
                                else
                                {
                                    treasure[i, j] = "X";
                                    count--;
                                }

                            }
                            tx_main.Text += "   " + treasure[i, j];
                        }

                        tx_main.Text += Environment.NewLine;
                    }

                    if (prize)
                    {
                        MessageBox.Show("Premi!!! has trobat el tresor");
                        bt_Search.Enabled = false;
                    }

                }
                else
                {

                    for (int i = 0; i < treasure.GetLength(0); i++)
                    {

                        for (int j = 0; j < treasure.GetLength(1); j++)
                        {

                            tx_main.Text += "   " + treasure[i, j];
                        }

                        tx_main.Text += Environment.NewLine;
                    }

                    MessageBox.Show("Els valors de X han de estar entre: 1 - " + treasure.GetLength(0) + " i " + "els valors de Y han de estar entre: 1 - " + treasure.GetLength(1));

                }

                tx_try.Text = count.ToString();

                if (count == 0)
                {
                    MessageBox.Show("S'han acabat els intens has perdut. El tresor estaba en la posicio: " + (prizeX + 1)+";" + (prizeY + 1));
                    bt_Search.Enabled = false;
                }

            }
            catch
            {

                if (tx_x.Text.Equals("") || tx_y.Text.Equals(""))
                    MessageBox.Show("No es poden deixar els camps X i Y en blanc");
                else
                    MessageBox.Show("NOMES es permeten NUMEROS.");

            }

        }
    }
}
