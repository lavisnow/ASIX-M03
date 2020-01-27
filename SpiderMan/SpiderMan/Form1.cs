using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiderMan
{
    public partial class Form1 : Form
    {
        int PosSM;
        int PosB1;
        int PosB2;
        int move1;
        int move2;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_calc_dist_Click(object sender, EventArgs e)
        {
            PosSM = int.Parse(tx_posSM.Text);
            PosB1 = int.Parse(tx_posB1.Text);
            PosB2 = int.Parse(tx_posB2.Text);

            if (PosSM < PosB1)
            {

                move1 = PosB1 - PosSM;

            }
            else
                move1 = PosSM - PosB1;

            PosSM = PosB1;

            if (PosSM < PosB2)
            {

                move2 = PosB2 - PosSM;

            }
            else
                move2 = PosSM - PosB2;

            MessageBox.Show("Spider-Man recorrerà una distància de: " + (move1 + move2) + " metres");

        }
    }
}
