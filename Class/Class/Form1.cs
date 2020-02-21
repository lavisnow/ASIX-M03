namespace Class
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private int _pos = 0;
        private Computer[] _PCs = new Computer[3];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < _PCs.Length; i++)
            {
                _PCs[i] = new Computer();
            }
        }

        private void save()
        {
            tx_cpu.Text = _PCs[_pos].CPU; ;
            tx_gpu.Text = _PCs[_pos].GPU; ;
            tx_hdd.Text = _PCs[_pos].HDD; ;
            tx_ram.Text = _PCs[_pos].RAM; ;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            _PCs[_pos] = new Computer(tx_cpu.Text, tx_ram.Text, tx_hdd.Text, tx_gpu.Text);
        }

        private void bt_right_Click(object sender, EventArgs e)

        {
            _pos++;
            if (_pos > 2)
                _pos = 0;
            save();
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            _pos--;
            if (_pos < 0)
                _pos = 2;
            save();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog _ofd = new OpenFileDialog();

            _ofd.Filter = "PCs|*.txt";
            _ofd.Title = "Save Computers";
            _ofd.ShowDialog();
            String lines;
            int i = 0;

            if (_ofd.FileName != "")
            {
                StreamReader sr = new StreamReader(_ofd.FileName);

                while (!sr.EndOfStream && i < _PCs.Length)
                {
                    lines = sr.ReadLine();
                    String[] extract;
                    if (lines.Contains("CPU: "))
                    {

                        extract = lines.Split(':');
                        _PCs[i].CPU = extract[1];
                    }
                    if (lines.Contains("RAM: "))
                    {

                        extract = lines.Split(':');
                        _PCs[i].RAM = extract[1];
                    }
                    if (lines.Contains("HDD: "))
                    {

                        extract = lines.Split(':');
                        _PCs[i].HDD = extract[1];
                    }
                    if (lines.Contains("GPU: "))
                    {

                        extract = lines.Split(':');
                        _PCs[i].GPU = extract[1];
                    }
                    if (lines.Equals(""))
                        i++;

                }
                sr.Close();
                save();
            }
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog _sfd = new SaveFileDialog();

            _sfd.Filter = "PCs|*.txt";
            _sfd.Title = "Save Computers";
            _sfd.ShowDialog();

            if (_sfd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(_sfd.FileName);
                for (int i = 0; i < _PCs.Length; i++)
                {
                    sw.WriteLine(_PCs[i].Print());
                    sw.WriteLine("");
                }
                sw.Close();
            }
        }

        private void bt_loadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog _ofd = new OpenFileDialog();

            _ofd.Filter = "PCs|*.txt";
            _ofd.Title = "Save Computers";
            _ofd.ShowDialog();

            if (_ofd.FileName != "")
            {
                StreamReader sr = new StreamReader(_ofd.FileName);

                while (!sr.EndOfStream)
                {
                    tx_spec.Text = sr.ReadToEnd();
                }
                sr.Close();
            }
        }
    }
}