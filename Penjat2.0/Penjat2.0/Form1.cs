using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjat2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string word = "";
        string letter = "";
        string hiddenword = "";
        int count = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            word = textBox1.Text.ToUpper();
            textBox1.Text = "";
            for (int i = 0; i < word.Length; i++)
            {

                hiddenword = hiddenword + "#";

            }
            textBox1.Text = hiddenword;

            textBox1.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            letter = textBox2.Text.ToUpper();
            bool winlose = false;

            for (int i = 0; i < word.Length; i++)
            {
                string cw = word.Substring(i, 1);
                string ch = hiddenword.Substring(i, 1);

                if (cw.Equals(letter))
                {
                    winlose = true;
                    textBox1.Text = textBox1.Text + cw;

                }
                else
                {

                    textBox1.Text = textBox1.Text + ch;

                }

            }
            hiddenword = textBox1.Text;

            if (winlose)
            {

                textBox3.Text = "Has encertat";
            }
            else
            {
                textBox3.Text = "Has fallat";
                count++;
            }

            if (textBox1.Text.Contains("#"))
            {
                if (count == 8)
                {

                    textBox3.Text = "Penjat!!!";
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
                pictureBox1.Load(count + ".png");
            }
            else
            {
                textBox3.Text = "Has guanyat";
                button3.Enabled = true;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }
    }
}
