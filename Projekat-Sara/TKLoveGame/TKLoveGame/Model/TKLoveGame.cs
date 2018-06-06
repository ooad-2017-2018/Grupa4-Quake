using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public sealed class TKLoveGame
    {

        private List<Zaposlenik> listaZaposlenika;
        private List<Igrac> listaIgraca;
        private List<Profesionalni> RangLista;
        private List<SaraSlam> SaraSlam;
        private List<Teren> listaTerena;
        private List<Takmicenje> listaTakmicenja;
        private List<Rezervacija> listaRezervacija;

        private static TKLoveGame uniqueInstance = new TKLoveGame();

        public static TKLoveGame Klub1;
        

        public static TKLoveGame Instanca
        {
            get
            {
                return Klub1 ?? (Klub1 = new TKLoveGame());
            }
        }


        public TKLoveGame()
        {
            listaZaposlenika = new List<Zaposlenik>();
            listaIgraca = new List<Igrac>();
            RangLista = new List<Profesionalni>();

            SaraSlam = new List<SaraSlam>();
            listaTerena = new List<Teren>();
            listaRezervacija = new List<Rezervacija>();

            Administrator Sara = new Administrator("admin", "sarita");
            Rekreativni rekr = new Rekreativni("Armin", "Z", "armin11", "armin11", "email", 1);
            Profesionalni nadalko = new Profesionalni("Rafa", "Nadal", "Rafa", "Rafa", "111");
            Zaposlenik merjem = new Zaposlenik("merjem", "hur", "meri", "meri", "email11", "1111111", 23);
            Zaposlenik merjem2 = new Zaposlenik("merjem", "hur", "meri2", "meri2", "email11", "1111111", 23);

            //dodati 
            ListaIgraca.Add(rekr);
            ListaIgraca.Add(nadalko);
            ListaZaposlenika.Add(merjem);
            ListaZaposlenika.Add(merjem2);


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

        public static TKLoveGame getInstance()
        {
            return uniqueInstance;
        }


    }
}

