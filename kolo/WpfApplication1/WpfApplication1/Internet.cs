using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Internet:Usluga
    {
        private int iloscMB;
        public override void ObliczCene()
        {
            cena = iloscMB / 756;
        }
        public Internet(DateTime czas, int iloscMB)
        {
            this.czas = czas;
            this.iloscMB = iloscMB;
            ObliczCene();
        }
        public override string ToString()
        {
            return "internet, ilosc MB" + iloscMB + " , cena internetu" + cena;
        }
    }
}
