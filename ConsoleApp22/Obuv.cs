using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    public class Obuv
    {
        public Obuv(string proiz, float cen, double raz)
        {
            Proiz = proiz;
            Cen = cen;
            Raz = raz;
        }
        public string Proiz { get; set; }
        public float Cen { get; set; }
        public double Raz { get; set; }
    }
}
