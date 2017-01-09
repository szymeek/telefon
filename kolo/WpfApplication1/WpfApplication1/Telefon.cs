using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Telefon : IDodaj//, IBiling
    {
        private List<Usluga> biling = new List<Usluga>();

        public void DodajPolaczenie(string numer, int czasP)
        {
            biling.Add(new Poloczenie(DateTime.Now, numer, czasP));
        }

        public void DodajSms(string numer)
        {
            biling.Add(new Sms(DateTime.Now, numer));
        }
        public void DodajInternet(int iloscMB)
        {
            biling.Add(new Internet(DateTime.Now, iloscMB));
        }

        public override string ToString()
        {
            string info = "biling:";
            foreach (var element in biling)
            {
                info += Environment.NewLine;
            }
            return info;

        }

    }
}
