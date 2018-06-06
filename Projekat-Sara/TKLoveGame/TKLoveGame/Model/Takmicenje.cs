using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class Takmicenje
    {
        private string idTakmicenje;
        private int kategorija;
        private string naziv;
        private string lokacija;
        private List<Profesionalni> entrylist;

        public Takmicenje(string idTakmicenje, int kategorija, string naziv, string lokacija, List<Profesionalni> entrylist)
        {
            this.idTakmicenje = idTakmicenje;
            this.kategorija = kategorija;
            this.naziv = naziv;
            this.lokacija = lokacija;
            this.entrylist = entrylist;
        }

        public string IdTakmicenje { get => idTakmicenje; set => idTakmicenje = value; }
        public int Kategorija { get => kategorija; set => kategorija = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Lokacija { get => lokacija; set => lokacija = value; }

    }
}
