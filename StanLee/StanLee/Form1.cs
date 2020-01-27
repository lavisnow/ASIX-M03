using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanLee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string _text = tx_search.Text.ToUpper();
            string _stanlee = "STAN LEE";
            int _count = 0;
            int _next = 0;

            for (int i = 0; i < _text.Length; i++) {

                string _search = _text.Substring(i, 1);
                string _searchSL = _stanlee.Substring(_next, 1);
                if (_search.Equals(_searchSL)) {
                    _next++;
                    if (_next == _stanlee.Length) {
                        _count++;
                        _next = 0;                
                    }
                }
            }

            MessageBox.Show("Hi ha: " + _count);

        }
    }
}
