using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.System;
using System.Threading.Tasks;


namespace TKLoveGame
{
    public class SaraSlam
    {
        private string idSS;
        private List<Igrac> listaigraca;
        private List<Mec> listameceva;
        private DateTime datumSS;
        private bool Aktivan;
        private list<Igrac> quarterfinals;
        private list<Igrac> semifinals;
        private list<Igrac> finals;

        public SaraSlam(global::System.String idSS, List<Igrac> listaigraca, List<Mec> listameceva, DateTime datumSS, global::System.Boolean aktivan, list<Igrac> quarterfinals, list<Igrac> semifinals, list<Igrac> finals)
        {
            this.idSS = idSS;
            this.listaigraca = listaigraca;
            this.listameceva = listameceva;
            this.datumSS = datumSS;
            Aktivan = aktivan;
            this.quarterfinals = quarterfinals;
            this.semifinals = semifinals;
            this.finals = finals;
        }

        public global::System.String IdSS { get => idSS; set => idSS = value; }
        public List<Igrac> Listaigraca { get => listaigraca; set => listaigraca = value; }
        public List<Mec> Listameceva { get => listameceva; set => listameceva = value; }
        public DateTime DatumSS { get => datumSS; set => datumSS = value; }
        public global::System.Boolean Aktivan1 { get => Aktivan; set => Aktivan = value; }
        public list<Igrac> Quarterfinals { get => quarterfinals; set => quarterfinals = value; }
        public list<Igrac> Semifinals { get => semifinals; set => semifinals = value; }
        public list<Igrac> Finals { get => finals; set => finals = value; }
    }
}
