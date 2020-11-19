using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*13. El tren de l'amor. L'entrada sera un seguit de caràcters que representaran un tren, cada caràcter representa un vagó. 
 * El tren es peculiar ja que a part de persones porta mercaderies. A més a més per buscar parella són els homes els que busquen 
 * parella. Els homes per no marejarse només poden anar cap endevant (a la dreta, que es on hi ha la locomotora). Les dones no es 
 * mouen i a cada vagó només hi ha lloc per una persona (això no impedeix als homes passar per sobre de vagons amb persones). 
 * El caracter M i m representen dones, la M són dones altes i la m son dones baixes. Els homes H i h son H homes alts i h homes 
 * baixos, els homes alts només poden anar amb dones altes i les dones baixes amb les baixes. Qualsevol altre caràcter són mercaderies 
 * que es poden saltar, excepte la @ que és una mercaderia que bloqueja l'avanç. La sortida ha de donar el número de parelles que es poden formar.
 * Exemple: H.$.*M ----> Es poden formar 1 parelles  H==@M ----> No es poden formar parelles  MHMHMHHMM  ----> Es poden formar 4   */

namespace Singh_Lovejeet_Examen_UF3
{
    public partial class Form1 : Form
    {

        DB db = new DB();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string couples = txb_in.Text, men = "", ch = "", ch2 = "";
            int couple = 0;

            for (int i = 0; i < couples.Length; i++)
            {

                ch = couples.Substring(i, 1);

                if (ch.Equals("H") || ch.Equals("h"))

                    men = ch;

                else
                    continue;

                if (men.Equals("H") || men.Equals("h"))
                {

                    for (int j = i; j < couples.Length; j++)
                    {
                        ch2 = couples.Substring(j, 1);

                        if (!ch2.Equals("@"))
                        {

                            if (ch2.Equals("M") && men.Equals("H"))
                            {
                                couple++;
                                couples = couples.Substring(0, j) + couples.Substring(j + 1, couples.Length - 1 - j);
                                break;

                            }
                            else if (ch2.Equals("m") && men.Equals("h"))
                            {
                                couple++;
                                couples = couples.Substring(0, j) + couples.Substring(j + 1, couples.Length - 1 - j);
                                break;
                            }
                            else
                                continue;
                        }
                        else
                            break;
                    }
                }
            }

            if (couple == 0)
                txb_out.Text = "No es poden formar parelles";
            else
                txb_out.Text = "Es poden formar " + couple.ToString() + " parelles";

            String checkinDB = db.SQLtoValor("SELECT ENTRADA FROM EXAMEN WHERE ENTRADA = '" + txb_in.Text + "'");

            if (checkinDB.Equals(""))
                db.ExecutarSQL("INSERT EXAMEN VALUES('" + txb_in.Text + "', '" + txb_out.Text + "')");
            else
                MessageBox.Show("Aquests grup de parelles ja s'han comprovat.!!!");

        }
    }
}
