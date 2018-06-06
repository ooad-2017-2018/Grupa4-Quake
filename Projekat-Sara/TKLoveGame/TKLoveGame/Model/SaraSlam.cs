using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private List<Igrac> quarterfinals;
        private List<Igrac> semifinals;
        private List<Igrac> finals;

        public SaraSlam(global::System.String idSS, List<Igrac> listaigraca, List<Mec> listameceva, DateTime datumSS, global::System.Boolean aktivan, List<Igrac> quarterfinals, List<Igrac> semifinals, List<Igrac> finals
            )
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
        public List<Igrac> Quarterfinals { get => quarterfinals; set => quarterfinals = value; }
        public List<Igrac> Semifinals { get => semifinals; set => semifinals = value; }
        public List<Igrac> Finals { get => finals; set => finals = value; }
    }
}
