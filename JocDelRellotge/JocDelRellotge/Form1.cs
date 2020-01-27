using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocDelRellotge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int contador = 0;
        int cartas = 0;
        int j1cartas = 24;
        int j2cartas = 24;

        private void Bt_start_Click(object sender, EventArgs e)
        {
            contador = 0;
            cartas = 0;
            j1cartas = 24;
            j2cartas = 24;
            tx_p1_cartas.Text = j1cartas.ToString();
            tx_p2_cartas.Text = j2cartas.ToString();
            tx_contador_cartas.Text = "0";
            tx_contador.Text = "0";
            tx_p1_resultat.Text = "0";
            tx_p2_resultat.Text = "0";
            bt_p1.Enabled = true;
            bt_p2.Enabled = true;

        }

        private void Bt_p1_Click(object sender, EventArgs e)
        {
            int j1random = rnd.Next(1, 12);
            contador++;
            cartas++;
            j1cartas--;
            bt_p2.Enabled = true;
            bt_p1.Enabled = false;
            bt_start.Enabled = false;

            if (contador > 11)
            {

                contador = 0;
            }


            if (j1random == contador)
            {

                j1cartas = j1cartas + cartas;
                cartas = 0;
            }

            if (j1cartas == 0)
            {

                MessageBox.Show("Ha guanyat el jugador 1, fes clic a START per tornar començar");
                bt_p1.Enabled = false;
                bt_p2.Enabled = false;
                bt_start.Enabled = true;

            }
            tx_p1_cartas.Text = j1cartas.ToString();
            tx_contador.Text = contador.ToString();
            tx_contador_cartas.Text = cartas.ToString();
            tx_p1_resultat.Text = j1random.ToString();


        }

        private void Bt_p2_Click(object sender, EventArgs e)
        {
            int j2random = rnd.Next(1, 12);
            contador++;
            cartas++;
            j2cartas--;
            bt_p1.Enabled = true;
            bt_p2.Enabled = false;
            bt_start.Enabled = false;



            if (contador > 11)
            {

                contador = 0;
            }

            if (j2random == contador)
            {

                j2cartas = j2cartas + cartas;
                cartas = 0;
            }

            if (j2cartas == 0)
            {

                MessageBox.Show("Ha guanyat el jugador 2, fes clic a START per tornar començar");
                bt_p1.Enabled = false;
                bt_p2.Enabled = false;
                bt_start.Enabled = true;
            }
            tx_p2_cartas.Text = j2cartas.ToString();
            tx_contador.Text = contador.ToString();
            tx_contador_cartas.Text = cartas.ToString();
            tx_p2_resultat.Text = j2random.ToString();


        }


    }
}
