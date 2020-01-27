using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class Form1 : Form
    {

        String[,] board = new string[6, 9];
        int player = 1;
        int colum;
        int check_colum;
        int posicion = 5;
        int horzX;
        int horzO;
        int vertX;
        int vertO;


        public Form1()
        {
            InitializeComponent();
            tx_board.ReadOnly = true;

            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    board[i, j] = "#";
                    tx_board.Text += "  " + board[i, j];

                }
                tx_board.Text += Environment.NewLine;
            }

        }

        private void printboard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    tx_board.Text += "  " + board[i, j];

                }
                tx_board.Text += Environment.NewLine;
            }


        }

        private void bt_Play_Click(object sender, EventArgs e)
        {
            tx_board.Text = "";
            colum = int.Parse(cb_Colum.Text) - 1;
            bool play = true;
            bool winP1 = false;
            bool winP2 = false;
            if (colum != check_colum)
                posicion = board.GetLength(0) - 1;

            for (int j = board.GetLength(0) - 1; j >= 0; j--)
            {
                {
                    if (board[j, colum].Equals("#"))
                    {
                        if (play)
                        {
                            play = false;

                            if (player == 1)
                            {
                                board[j, colum] = "X";
                                player = 2;
                                posicion--;
                            }
                            else
                            {
                                board[j, colum] = "O";
                                player = 1;
                                posicion--;
                            }
                        }
                    }
                    else if (posicion == -1)
                    {
                        MessageBox.Show("Columna plena");
                    }
                }
            }

            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                horzX = 0;
                horzO = 0;
                for (int j = board.GetLength(1) -1 ; j >= 0; j--)
                {
                    if (board[i,j].Equals("X"))
                    {
                        horzX++;
                    }
                    else if (board[i, j].Equals("O"))
                    {
                        horzO++;
                    }else 
                    {
                        horzX = 0;
                        horzO = 0;
                    }

                    if (horzX == 4 ) {

                        winP1 = true;
                    }
                    else if (horzO == 4)
                    {

                        winP2 = true;
                    }
                }
            }

            for (int i = board.GetLength(1) - 1; i >= 0; i--)
            {
                vertX = 0;
                vertO = 0;
                for (int j = board.GetLength(0) - 1; j >= 0; j--)
                {
                    if (board[j, i].Equals("X"))
                    {
                        vertX++;
                    }
                    else if (board[j, i].Equals("O"))
                    {
                        vertO++;
                    }
                    else
                    {
                        vertX = 0;
                        vertO = 0;
                    }

                    if (vertX == 4)
                    {

                        winP1 = true;
                    }
                    else if (vertO == 4)
                    {

                        winP2 = true;
                    }
                }
            }

            printboard();

            if (winP1)
            {
                MessageBox.Show("Ha guanyat el jugador 1!!!");
            }
            else if (winP2)
            {
                MessageBox.Show("Ha guanyat el jugador 2!!!");
            }

            check_colum = colum;

        }

        private void bt_res_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
