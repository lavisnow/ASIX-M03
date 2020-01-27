using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trilero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int bola = rnd.Next(1, 3);

            if (checkBox1.Checked && bola == 1)
            {
                MessageBox.Show("Encertat");
            }
            else if (checkBox2.Checked && bola == 2)
            {

                MessageBox.Show("Encertat");
            }
            else if (checkBox3.Checked  && bola == 3)
            {
                MessageBox.Show("Encertat");
            }
            else
                MessageBox.Show("Mala sort, torna a probar");
            button1.Text = bola.ToString();
            
        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void CheckBox3_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }
    }
}
