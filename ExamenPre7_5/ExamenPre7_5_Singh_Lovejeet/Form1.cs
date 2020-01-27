using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPre7_5_Singh_Lovejeet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double player1;
        double player2;
        string resultat = "";


        private void button1_Click(object sender, EventArgs e)
        {

            double suma = 0;
            Random rnd = new Random();
            int num;
            tx_player_01.Text = "";

            while (suma < 7.5)
            {
                num = rnd.Next(1, 12);
                if (num >= 1 && num <= 7)
                {
                    suma = suma + num;

                }
                else if (num > 9 || num < 13)
                {
                    suma = suma + 0.5;
                }
                else if (num == 8 || num == 9)
                {


                }

                tx_player_01.Text = tx_player_01.Text + " " + num;

            }

            player1 = suma;

        }

        private void bt_play_02_Click(object sender, EventArgs e)
        {

            double suma = 0;
            Random rnd = new Random();
            int num;
            tx_player_02.Text = "";

            while (suma < 7.5)
            {
                num = rnd.Next(1, 12);

                if (num >= 1 && num <= 7)
                {
                    suma = suma + num;


                }

                else if (num > 9 || num < 13)
                {
                    suma = suma + 0.5;
                }
                else if (num == 8 || num == 9)
                {


                }
                tx_player_02.Text = tx_player_02.Text + " " + num;
            }

            player2 = suma;


        }

        private void bt_winner_Click(object sender, EventArgs e)
        {
            if (player1 == 7.5 && player2 == 7.5)
            {

                resultat = "Empat";
            }
            else if (player1 < player2)
            {

                resultat = "Ha guanyat el jugador 1 amb: " + player1;
            }
            else
                resultat = "Ha guanyat el jugador 2 amb : " + player2;

            tx_resultat.Text = resultat;


        }
    }

}
