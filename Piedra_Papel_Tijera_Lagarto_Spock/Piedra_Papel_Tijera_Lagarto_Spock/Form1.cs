using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra_Papel_Tijera_Lagarto_Spock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_res_Click(object sender, EventArgs e)
        {
            string[] game = new string[] { "Piedra", "Papel", "Tijera", "Lagarto", "Spock" };

            Random rnd = new Random();

            int j1 = rnd.Next(0, 4);
            int j2 = rnd.Next(0, 4);

            tx_j1.Text = game[j1] + " - " + j1;
            tx_j2.Text = game[j2] + " - " + j2;
  

            if (j1 == j2)
            {

                tx_res.Text = "Empat";
            }
            else if (j1 == 0 && (j2 == 3 || j2 == 2))
            {

                tx_res.Text = "Ha guanyat el J1";

            }
            else if (j1 == 1 && j2 == 2 || j2 == 4)
            {
                tx_res.Text = "Ha guanyat el J1";

            }
            else if (j1 == 2 && j2 == 3 || j2 == 1)
            {
                tx_res.Text = "Ha guanyat el J1";

            }
            else if (j1 == 3 && j2 == 4 || j2 == 1)
            {
                tx_res.Text = "Ha guanyat el J1";

            }
            else if (j1 == 4 && j2 == 0 || j2 == 2)
            {
                tx_res.Text = "Ha guanyat el J1";
            }
            else if (j2 == 0 && j1 == 3 || j1 == 2)
            {

                tx_res.Text = "Ha guanyat el J2";

            }
            else if (j2 == 1 && j1 == 2 || j1 == 4)
            {
                tx_res.Text = "Ha guanyat el J2";

            }
            else if (j2 == 2 && j1 == 3 || j1 == 1)
            {
                tx_res.Text = "Ha guanyat el J2";

            }
            else if (j2 == 3 && j1 == 4 || j1 == 1)
            {
                tx_res.Text = "Ha guanyat el J2";

            }
            else if (j2 == 4 && j1 == 0 || j1 == 2)
            {
                tx_res.Text = "Ha guanyat el J2";
            }


        }
    }
}
