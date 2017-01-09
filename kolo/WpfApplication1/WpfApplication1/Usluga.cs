using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    abstract class Usluga
    {
        protected DateTime czas;
        protected double cena;
        abstract public void ObliczCene();
        public Usluga()
        {
            DateTime czas = new DateTime(2008, 5, 1, 8, 30, 52);
        }
    }
}
