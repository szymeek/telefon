using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Poloczenie:Usluga
    {
        private string numer;
        private int czasP;
        //private int cenaP;
        public override void ObliczCene()
        {
            cena = czasP * 0.29;
        }
        public Poloczenie(DateTime czas, string numer, int czasP)
        
        {
            this.czas = czas;
            this.numer = numer;
            this.czasP = czasP;
            ObliczCene();
        }
        public override string ToString()
        {
            return "numer" + numer + ", czas" + czas + " , czas poloczenia" + czasP + " , cena poloczenia" + cena;
        }

    }
}
