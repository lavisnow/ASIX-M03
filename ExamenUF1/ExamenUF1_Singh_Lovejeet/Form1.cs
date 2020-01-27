using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUF1_Singh_Lovejeet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tx_replace.ReadOnly = true;
            tx_replacechar.ReadOnly = true;
            tx_RotateWord.ReadOnly = true;
            tx_CountSpace.ReadOnly = true;
            tx_char.MaxLength = 1;

        }

        string phrase = "";
        string ch = "";
        int countspace = 0;
        string rotateword = "";
        private void Bt_Pro_Click(object sender, EventArgs e)
        {
            phrase = tx_phrase.Text.ToUpper();
            ch = tx_char.Text.ToUpper();
            tx_replace.Text = "";
            tx_replacechar.Text = "";
            tx_RotateWord.Text = "";
            tx_CountSpace.Text = "";
            rotateword = "";
            countspace = 0;


            if (String.IsNullOrWhiteSpace(phrase))
            {

                MessageBox.Show("Escriu una frase");
                tx_phrase.Focus();
            }
            else if (String.IsNullOrWhiteSpace(ch))
            {

                MessageBox.Show("No es pot deixar Char en blanc");
                tx_char.Focus();

            }
            else
            {

                for (int i = 0; i < phrase.Length; i++)
                {

                    string thPh = phrase.Substring(i, 1);
                    /* La frase substituint les vocals pel caracter apuntat */
                    if (thPh.Equals("A") || thPh.Equals("E") || thPh.Equals("I") || thPh.Equals("O") || thPh.Equals("U"))
                    {

                        tx_replace.Text = tx_replace.Text + ch;

                    }
                    else
                        tx_replace.Text = tx_replace.Text + thPh;

                    /* Girar les paraules + Contar el número d'espais */

                    if (thPh.Equals(" "))
                    {
                        countspace++;
                        tx_RotateWord.Text = tx_RotateWord.Text + " " + rotateword;
                        rotateword = "";
                    }
                    else
                        rotateword = thPh + rotateword;
                }


                tx_RotateWord.Text = tx_RotateWord.Text + " " + rotateword;

                if (countspace > 0)
                {

                    tx_CountSpace.Text = "La frase té: " + countspace + " espais en blanc";
                    /*Substituir el caracter a buscar pel caracter repetit tantes vegades com espais*/

                   
                    for (int j = 0; j < phrase.Length; j++)
                    {

                        string thPh = phrase.Substring(j, 1);

                        if (thPh.Equals(ch))
                        {
                            for (int x = 0; x < countspace; x++)
                                tx_replacechar.Text = tx_replacechar.Text + ch;
                        }
                        else
                            tx_replacechar.Text = tx_replacechar.Text + thPh;

                    }

                }
                else
                {
                    for (int j = 0; j < phrase.Length; j++)
                    {

                        string thPh = phrase.Substring(j, 1);

                        if (thPh.Equals(ch))
                        {
                            ch = "";
                            tx_replacechar.Text = tx_replacechar.Text + ch;

                        }
                        else
                            tx_replacechar.Text = tx_replacechar.Text + thPh;

                    }
                    tx_CountSpace.Text = "La frase no conté espais en blanc";

                }
            }
        }
    }
}
