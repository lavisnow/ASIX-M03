using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheeloffortune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string phrase = "";
        string hiddenphrase = "";
        string letter = "";
        string solve = "";
        int countletter = 0;
        int pull = 0;
        int player = 1;
        int marker01 = 0;
        int marker02 = 0;

        private void BtStart_Click(object sender, EventArgs e)
        {
            phrase = txPhrase.Text;
            txPhrase.Text = "";
            for (int i = 0; i < phrase.Length; i++)
            {

                string checkletter = phrase.Substring(i, 1);

                if (checkletter.Equals(" "))
                {
                    hiddenphrase = hiddenphrase + " ";

                }
                else
                    hiddenphrase = hiddenphrase + "#";

            }

            txMarker1.BackColor = Color.Green;
            txPhrase.Text = hiddenphrase;
            btStart.Enabled = false;
            txPhrase.Enabled = false;
            btTry.Enabled = false;
            txTry.Enabled = false;
        }

        private void BtPull_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            txTry.Text = "";
            bool letternotfound = false;


            int segments = 0;
            int segmentsControl = rnd.Next(1, 100);
            int Control = rnd.Next(0, 200);

            if (segmentsControl < 85)
            {

                segments = 1;
            }
            else if (segmentsControl > 85 && segmentsControl < 95)
            {

                segments = 2;
            }
            else
                segments = 3;

            if (segments == 1) //Premis
            {
                btTry.Enabled = true;
                btPull.Enabled = false;

                if (Control < 5)
                {

                    pull = 200;

                }
                else if (Control >= 5 && Control < 15)
                {
                    pull = 150;
                }
                else if (Control >= 15 && Control < 35)
                {

                    pull = 100;

                }
                else if (Control >= 35 && Control < 65)
                {

                    pull = 75;
                }
                else if (Control >= 65 && Control < 105)
                {

                    pull = 50;
                }
                else if (Control >= 105 && Control < 155)
                {

                    pull = 25;
                }
                else
                    pull = 0;

                ptbox.Load(pull + ".png");

            }
            else if (segments == 2) // Canvi torn
            {
                btTry.Enabled = false;
                btPull.Enabled = true;
                letternotfound = true;
                ptbox.Load("pierdeturno.png");


                if (player == 1)
                {

                    player = 2;
                }
                else
                    player = 1;

            }
            else if (segments == 3) //Quiebra
            {
                btTry.Enabled = false;
                btPull.Enabled = true;
                letternotfound = true;
                ptbox.Load("quiebra.png");


                if (player == 1)
                {
                    marker01 = 0;
                    player = 2;
                }
                else
                {
                    marker02 = 0;
                    player = 1;

                }
            }

            if (letternotfound)
            {
                if (player == 1)
                {
                    txMarker1.BackColor = Color.White;
                    txMarker2.BackColor = Color.Green;

                    player = 2;
                }
                else
                {
                    txMarker1.BackColor = Color.Green;
                    txMarker2.BackColor = Color.White;

                    player = 1;
                }

            }

            txTry.Enabled = true;
        }

        private void BtTry_Click(object sender, EventArgs e)
        {
            letter = txTry.Text;
            txPhrase.Text = "";
            countletter = 0;
            bool letternotfound = false;
            for (int i = 0; i < phrase.Length; i++)
            {

                string checkletter = phrase.Substring(i, 1);
                string checkhash = hiddenphrase.Substring(i, 1);
                if (checkletter.Equals(letter))
                {

                    checkhash = letter;
                    txPhrase.Text = txPhrase.Text + checkletter;
                    countletter++;
                    letternotfound = true;
                }
                else
                {
                    txPhrase.Text = txPhrase.Text + checkhash;

                }
            }


            if (player == 1)
            {

                marker01 = marker01 + (pull * countletter);
            }
            else
            {
                marker02 = marker02 + (pull * countletter);
            }

            if (!letternotfound)
            {
                if (player == 1)
                {
                    txMarker1.BackColor = Color.White;
                    txMarker2.BackColor = Color.Green;

                    player = 2;
                }
                else
                {
                    txMarker1.BackColor = Color.Green;
                    txMarker2.BackColor = Color.White;

                    player = 1;
                }

            }

            hiddenphrase = txPhrase.Text;
            txMarker1.Text = marker01.ToString();
            txMarker2.Text = marker02.ToString();
            btTry.Enabled = false;
            btPull.Enabled = true;

        }

        private void BtSolve_Click(object sender, EventArgs e)
        {
            solve = txSolve.Text;

            if (phrase.Equals(solve))
            {
                if (player == 1)
                {

                    txMarker1.Text = "WINNER!!! has guanyat: " + marker01 + "€";
                    txMarker2.Text = "LOSER!!!";
                }
                else
                {
                    txMarker2.Text = "WINNER!!! has guanyat: " + marker02 + "€";
                    txMarker1.Text = "LOSER!!!";
                }
            }
        }
    }
}
