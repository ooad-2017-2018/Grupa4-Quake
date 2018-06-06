using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class Mec
    {
        private string idMec;
        private Igrac igrac1;
        private Igrac igrac2;
        private string rezultat;
        private string pobjednik;
        private int idTeren;

        public Mec(global::System.String idMec, Igrac igrac1, Igrac igrac2, global::System.String rezultat, global::System.String pobjednik, global::System.Int32 idTeren)
        {
            this.idMec = idMec;
            this.igrac1 = igrac1;
            this.igrac2 = igrac2;
            this.rezultat = rezultat;
            this.pobjednik = pobjednik;
            this.idTeren = idTeren;
        }

        public global::System.String IdMec { get => idMec; set => idMec = value; }
        public Igrac Igrac1 { get => igrac1; set => igrac1 = value; }
        public Igrac Igrac2 { get => igrac2; set => igrac2 = value; }
        public global::System.String Rezultat { get => rezultat; set => rezultat = value; }
        public global::System.String Pobjednik { get => pobjednik; set => pobjednik = value; }
        public global::System.Int32 IdTeren { get => idTeren; set => idTeren = value; }

    }
}
