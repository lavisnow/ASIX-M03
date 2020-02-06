using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SopaLletres
{
    public partial class Form1 : Form
    {
        String[,] sopa;
        String paraula;
        

        public Form1()
        {
            InitializeComponent();
            sopa = new string[8, 8];
            Random rnd = new Random();
            

            for (int i = 0; i < sopa.GetLength(0); i++) {

                for (int j = 0; j < sopa.GetLength(1); j++) {

                    int abcd = rnd.Next(26);
                    char p = (char)('a' + abcd);
                    sopa[i, j] = p.ToString();

                    tx_sopa.Text += "    " + sopa[i, j];
                }

                tx_sopa.Text += Environment.NewLine;
            }


            
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            int PosX_Inici = int.Parse(tx_inici_X.Text) -1;
            int PosY_Inici = int.Parse(tx_inici_Y.Text) -1;
            int PosX_Fi = int.Parse(tx_fi_X.Text) -1;
            int PosY_Fi = int.Parse(tx_fi_Y.Text) -1;
            int aux = 0;

            if (PosX_Inici == PosX_Fi) {

                if (PosY_Inici > PosY_Fi) {

                    for (int i = PosY_Inici; i >= PosY_Fi; i--)
                    {

                        paraula += sopa[PosX_Inici, i];
                    }

                }
                else 
                   for (int i = PosY_Inici; i <= PosY_Fi; i++)
                    {

                        paraula += sopa[PosX_Inici, i];
                    }
            }
            else if (PosY_Inici == PosY_Fi)
            {

                if (PosX_Inici > PosX_Fi)
                {

                    for (int i = PosX_Inici; i >= PosX_Fi; i--)
                    {

                        paraula += sopa[i,PosY_Inici];
                    }

                }
                else
                    for (int i = PosX_Inici; i <= PosX_Fi; i++)
                    {

                        paraula += sopa[i, PosY_Inici];
                    }
            }




        }
    }
}
