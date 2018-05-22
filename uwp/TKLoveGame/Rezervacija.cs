using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class Rezervacija
    {
        private string idKorisnika;
        private bool Trener;
        private string IdRezervacije;
        private string idTrenera;
        private int idTerena;

        public Rezervacija(string idKorisnika, bool trener, string idRezervacije, string idTrenera, int idTerena)
        {
            this.idKorisnika = idKorisnika;
            Trener = trener;
            IdRezervacije = idRezervacije;
            this.idTrenera = idTrenera;
            this.idTerena = idTerena;
        }

        public string IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
        public bool Trener1 { get => Trener; set => Trener = value; }
        public string IdRezervacije1 { get => IdRezervacije; set => IdRezervacije = value; }
        public string IdTrenera { get => idTrenera; set => idTrenera = value; }
        public int IdTerena { get => idTerena; set => idTerena = value; }
    }
}
