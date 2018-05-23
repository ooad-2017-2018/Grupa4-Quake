using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class TKLoveGame
    {

        private List<Zaposlenik> listaZaposlenika;
        private List<Igrac> listaIgraca;
        private List<Profesionalni> RangLista;
        private List<SaraSlam> SaraSlam;
        private List<Teren> listaTerena;
        private List<Takmicenje> listaTakmicenja;
        private List<Rezervacija>listaRezervacija;

       
        public TKLoveGame()
        {
            listaZaposlenika = new List<Zaposlenik>();
            listaIgraca = new List<Igrac>();
            RangLista = new List<Profesionalni>();
           
            SaraSlam = new List<SaraSlam>();
            listaTerena = new List<Teren>();
            listaRezervacija = new List<Rezervacija>();
           

        }

        public List<Zaposlenik> ListaZaposlenika
        {
            get { return listaZaposlenika; }
        }


        public List<Igrac> ListaIgraca
        {
            get { return listaIgraca; }
        }


        public List<Profesionalni> R_Lista
        {
            get { return RangLista; }
        }

        public List<SaraSlam> SaraSlam1 { get => SaraSlam; set => SaraSlam = value; }
        public List<Teren> ListaTerena { get => listaTerena; set => listaTerena = value; }
        public List<Takmicenje> ListaTakmicenja { get => listaTakmicenja; set => listaTakmicenja = value; }
        public List<Rezervacija> ListaRezervacija { get => listaRezervacija; set => listaRezervacija = value; }
    }
}
