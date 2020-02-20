namespace Class
{
    using System;

    public class Computer
    {
        private String _CPU;

        private String _RAM;

        private String _HDD;

        private String _GPU;

        public Computer()
        {
        }

        public Computer(String C, String R, String H, String G)
        {
            _CPU = C;
            _RAM = R;
            _HDD = H;
            _GPU = G;
        }

        public string CPU { get => _CPU; set => _CPU = value; }
        public String RAM { get => _RAM; set => _RAM = value; }
        public String HDD { get => _HDD; set => _HDD = value; }
        public string GPU { get => _GPU; set => _GPU = value; }

        public String Print()
        {
            return "Aquest ordinador te les següents característiques: "
                + Environment.NewLine
                + "CPU: " + _CPU + Environment.NewLine
                + "RAM: " + _RAM + Environment.NewLine
                + "HDD: " + _HDD + Environment.NewLine
                + "GPU: " + _GPU;
        }
    }
}