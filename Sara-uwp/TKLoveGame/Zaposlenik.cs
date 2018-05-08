using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
   public class Zaposlenik
    {

        private String ime;
        private String prezime;
        private DateTime datum_rodjenja;
        private String idZaposlenika;
        private String password;
        private String username;
        private String JMBG;
        //private String adresa;
        private String email;
        private double plata;
        private static int counter=1;
        //private DateTime datum_zap;

        public Zaposlenik(String ime, String prezime, String username, String password, String email, DateTime datumRodjenja, String JMBG, double plata)
        {
            Ime = ime;
            Prezime = prezime;
            Datum_rodjenja = datumRodjenja;
            IdZaposlenika = counter.ToString();
            counter++;
            Username = username;
            Password = password;
            JMBGG = JMBG;
            Plata = plata;
        }

        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public String Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public DateTime Datum_rodjenja
        {
            get { return datum_rodjenja; }
            set { datum_rodjenja= value; }
        }

        public String IdZaposlenika
        {
            get { return idZaposlenika; }
            set { idZaposlenika = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String JMBGG
        {
            get { return JMBG; }
            set { JMBG = value; }
        }

        public double Plata
        {
            get { return plata; }
            set { plata = value; }
        }
    }
}
