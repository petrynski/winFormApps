using System;
using System.Collections.Generic;
using System.Text;

namespace zadanieDodatkowe2
{
    class Organizacja
    {
        public Organizacja() { }

        public string name { get; set; }
        public string ticker { get; set; }
        public DateTime date { get; set; }
        public double openrate { get; set; }
        public double rate { get; set; }
        public double volume { get; set; }
        public double tournover { get; set; }
        public string isin { get; set; }
    }
}
