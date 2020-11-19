using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrama
{
    public partial class Form1 : Form
    {
        DB db = new DB();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            String[] words = txb_in.Text.ToLower().Split(' ');
            String word1 = words[0];
            String word2 = words[1];
            string ch1 = "", ch2 = "", leftover = "";
            bool check = false;

            for (int i = 0; i < word1.Length; i++)
            {

                ch1 = word1.Substring(i, 1);
                for (int j = 0; j < word2.Length; j++)
                {

                    ch2 = word2.Substring(j, 1);
                    if (ch2.Equals(ch1))
                    {
                        word2 = word2.Substring(0, j) + word2.Substring(j + 1, word2.Length - 1 - j);
                        check = true;
                        break;
                    }
                    else
                    {

                        continue;
                    }
                }

                if (!check)
                    leftover = leftover + ch1;
                else
                    check = false;

            }

            if (word2.Equals("") && leftover.Equals(""))
                txb_out.Text = "SI és un anagrama";
            else if (!word2.Equals("") && leftover.Equals(""))
                txb_out.Text = "NO és un anagrama perque li falta/en les lletres: " + word2;
            else if (word2.Equals("") && !leftover.Equals(""))
                txb_out.Text = "NO és un anagrama perque li falta/en les lletres: " + leftover;
            else
                txb_out.Text = "NO és un anagrama perque li falta/en les lletres: " + leftover + word2;

            String checkinDB = db.SQLtoValor("SELECT CHECKINDB FROM EXAMEN WHERE CHECKINDB = '" + txb_in.Text + "'");

            if (!checkinDB.Equals(""))
                db.ExecutarSQL("INSERT EXAMEN VALUES('" + txb_in.Text + "', '" + txb_out.Text + "')");
            else
                MessageBox.Show("Aquestes paraules ja s'han comprovat.!!!");

        }
    }
}
