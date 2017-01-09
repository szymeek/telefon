using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Sms:Usluga
    {
        private string numer;
        public override void ObliczCene()
        {
            cena = 0.15;
        }
        public Sms(DateTime czas, string numer)
        {
            this.czas = czas;
            this.numer = numer;
            ObliczCene();
        }
        public override string ToString()
        {
            return "numer" + numer + ", czas smsa" + czas + " , cena smsa" + cena;
        }
    }
}
