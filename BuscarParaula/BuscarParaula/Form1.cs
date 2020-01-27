using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscarParaula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            string paraula = textBox3.Text.ToLower();
            int count = 0;

            if (!String.IsNullOrWhiteSpace(paraula))
            {
                for (int i = 0; i < text.Length - paraula.Length; i++)
                {

                    string xt = text.Substring(i, paraula.Length);
                    if (xt.Equals(paraula))
                    {

                        count++;
                    }
                }

                if (count > 0)
                {

                    textBox2.Text = "La paraula '" + paraula + "' es repateix " + count + " vegades.";

                }
                else
                    textBox2.Text = "No s'ha trobat cap " + paraula;
            }
            else
                textBox2.Text = "No es poden buscar espais en blanc.";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            textBox2.Text = "";
            for(int i = 0; i < text.Length; i++)
            {
                string xt = text.Substring(i, 1);

                textBox2.Text = xt + textBox2.Text;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
            int A = 0, E = 0, I = 0, O = 0, U = 0;
            for (int x = 0; x < text.Length; x++) {
                string xt = text.Substring(x, 1);
                if (xt.Equals("a")){ A++;}
                else if (xt.Equals("e")){E++;}
                else if (xt.Equals("i")){I++;}
                else if (xt.Equals("o")){O++;}
                else if (xt.Equals("u")){U++;}
            }
            textBox2.Text = "A:"+ A + Environment.NewLine + "E:" + E + Environment.NewLine + "I:" + I + Environment.NewLine + "O:" + O + Environment.NewLine + "U:" + U;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            bool mayus = true;
            for (int x = 0; x < text.Length; x++)
            {
                 string m = text.Substring(x, 1);

                if (mayus)
                {
                    textBox2.Text = textBox2.Text + m.ToUpper();
                    mayus = false;
                }
                else
                {
                    textBox2.Text = textBox2.Text + m.ToLower();
                    mayus = true;
                }

            }

        }

    }
}
