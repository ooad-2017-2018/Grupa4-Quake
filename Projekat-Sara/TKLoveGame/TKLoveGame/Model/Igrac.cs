using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public abstract class Igrac//: Placanje
    {
        private String ime;
        private String prezime;
        private DateTime datum_rodjenja;
        private String idIgraca;
        private String password;
        private String username;
        private String email;
        private int br_rundi;
        private static int counter_igraci = 1;



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
        /*
        public DateTime Datum_rodjenja
        {
            get { return datum_rodjenja; }
            set { datum_rodjenja = value; }
        }*/

        public String IdIgraca
        {
            get { return idIgraca; }
            set { idIgraca = value; }
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

        public Igrac(String ime, String prezime, String username, String password, String email)
        {
            Ime = ime;
            Prezime = prezime;
           
            IdIgraca = Ime[0] + Prezime[0] + counter_igraci.ToString();
            counter_igraci++;
            Username = username;
            Password = password;
            br_rundi = 0;
        }

    }


    // void PlatiE() { }
}
