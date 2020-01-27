using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeInRow
{
    public partial class Form1 : Form
    {
        string[,] board;
        int player = 1;
        bool fichas = false;
        int countX = 0;
        int countO = 0;
        int winH1 = 0;
        int winH2 = 0;
        int winV1 = 0;
        int winV2 = 0;
        int winX1;
        int winX2;
        int win1X;
        int win2X;
        bool win1 = false;
        bool win2 = false;


        private void print()
        {

            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    tx_Board.Text += "   " + board[i, j];
                }

                tx_Board.Text += Environment.NewLine;
            }
        }

        private void bt_Replay()
        {

            bt_Play.Enabled = false;
            bt_replay.Enabled = true;
        }

        public Form1()
        {

            InitializeComponent();
            tx_Board.ReadOnly = true;
            board = new string[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    board[i, j] = "#";
                    tx_Board.Text += "   " + board[i, j];
                }

                tx_Board.Text += Environment.NewLine;
            }

            lb_player1.ForeColor = System.Drawing.Color.Green;

        }

        private void playerchange()
        {

            if (player == 1)
            {

                lb_player2.ForeColor = System.Drawing.Color.Green;
                lb_player1.ForeColor = System.Drawing.Color.Black;

            }
            else
            {
                lb_player1.ForeColor = System.Drawing.Color.Green;
                lb_player2.ForeColor = System.Drawing.Color.Black;

            }

        }

        private void bt_Play_Click(object sender, EventArgs e)
        {


            try
            {

                tx_Board.Text = "";
                int x = int.Parse(tx_X.Text) - 1;
                int y = int.Parse(tx_Y.Text) - 1;

                bt_replay.Enabled = false;


                if (board[y, x].Equals("#"))
                {
                    if (player == 1)
                    {
                        if (countX < 3)
                        {

                            playerchange();
                            board[y, x] = "X";
                            player = 2;
                            countX++;
                        }
                        else
                            MessageBox.Show("EPPP, nomes tens 3 fitxes, juga amb aquestes...Reclamacions a : dferreiro@lasalle.cat ");
                    }
                    else if (player == 2)
                    {
                        if (countO < 3)
                        {
                            playerchange();
                            board[y, x] = "O";
                            player = 1;
                            countO++;
                        }
                        else
                            MessageBox.Show("EPPP, nomes tens 3 fitxes, juga amb aquestes...Reclamacions a : dferreiro@lasalle.cat");
                    }

                    if (countX == 3 && countO == 3)
                    {
                        lb_change.ForeColor = System.Drawing.Color.Green;
                        fichas = true;
                    }
                }
                else if (fichas)
                {

                    if (player == 1)
                    {

                        if (board[y, x].Equals("X"))
                        {
                            board[y, x] = "#";
                            countX--;
                            lb_change.ForeColor = System.Drawing.Color.Black;
                            fichas = false;
                        }
                        else
                            MessageBox.Show("La fitxa escullida no es teva.");
                    }
                    else
                    {
                        if (board[y, x].Equals("O"))
                        {
                            board[y, x] = "#";
                            countO--;
                            lb_change.ForeColor = System.Drawing.Color.Black;
                            fichas = false;
                        }
                        else
                            MessageBox.Show("La fitxa escullida no es teva.");
                    }

                }
                else if (board[y, x].Equals("X") || board[y, x].Equals("O"))
                    MessageBox.Show("Ubicacio ja ocupada escull un altre.");

                winX1 = 0;
                winX2 = 0;
                win1X = 0;
                win2X = 0;

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    winH1 = 0;
                    winH2 = 0;
                    winV1 = 0;
                    winV2 = 0;

                    for (int j = 0; j < board.GetLength(1); j++)
                    {

                        if (board[i, j].Equals("X"))
                            winH1++;
                        else if (board[i, j].Equals("O"))
                            winH2++;

                        if (board[j, i].Equals("X"))
                            winV1++;
                        else if (board[j, i].Equals("O"))
                            winV2++;

                        if (i == j)
                        {
                            if (board[i, j].Equals("X"))
                            {
                                winX1++;
                            }
                            else if (board[i, j].Equals("O"))
                            {
                                winX2++;
                            }
                        }

                        if (i + j == 2)
                        {
                            if (board[i, j].Equals("X"))
                            {
                                win1X++;
                            }
                            else if (board[i, j].Equals("O"))
                                win2X++;
                        }
                    }

                    if (winH1 == 3 || winV1 == 3 || winX1 == 3 || win1X == 3)
                    {
                        win1 = true;
                        break;
                    }

                    else if (winH2 == 3 || winV2 == 3 || winX2 == 3 || win2X == 3) 
                    {
                        win2 = true;
                        break;
                    }

                }

                print();

                if (win1)
                {
                    MessageBox.Show("Ha guanyat el jugador 1!!!");
                    bt_Replay();
                }
                else if (win2)
                {
                    MessageBox.Show("Ha guanyat el jugador 2!!!");
                    bt_Replay();
                }

            }
            catch
            {
                print();
                MessageBox.Show("Escriu el valors correctes, recorda que han de ser numerics de entre 1 i 3");
            }

        }
        private void bt_replay_Click(object sender, EventArgs e)
        {
            Application.Restart();
            bt_Play.Enabled = true;
            bt_replay.Enabled = false;

        }
    }
}

