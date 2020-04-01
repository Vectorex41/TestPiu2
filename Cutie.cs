using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cutie
    {
        private double lungime;
        private double latime;
        private double adancime;
        private enum culoare
        {
            Rosu=0,
            Galben=1,
            Albastru=2,
            Verde=3
        }
        public Cutie()
        {
            lungime = 0;
            latime = 0;
            adancime = 0;
        }
        public Cutie(double L,double l,double a)
        {
            lungime = L;
            latime = l;
            adancime = a;
        }
        public string ConversieLaSir()
        {
            string buff = " ";
            buff += "Cutie cu lungimea";
            buff += lungime;
            buff += "Cu latimea ";
            buff += latime;
            buff += "Si adancimea";
            buff += adancime;
            return buff;
        }
    }

    
}
