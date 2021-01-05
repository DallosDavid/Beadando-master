using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Pakseg
    {
        string nev;
        List<Pekaru> termekek;
        DateTime alapitva;

        public Pakseg(string nev, List<Pekaru> termekek, DateTime alapitva)
        {
            this.nev = nev;
            this.termekek = termekek;
            this.alapitva = alapitva;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva;}
        public List<Pekaru> Termekek { get => termekek;}

        public override string ToString()
        {
            return string.Format(nev+"-"+alapitva);
        }
    }
}
