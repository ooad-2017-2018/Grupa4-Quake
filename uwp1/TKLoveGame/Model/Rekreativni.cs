using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class Rekreativni: Igrac
    {
        private double popust;
        private int broj_posjeta;


        public Rekreativni(String ime, String prezime, String username, String password, String email, DateTime datumRodjenja,double popust):base ( ime, prezime, username, password, email, datumRodjenja) { Popust = popust; broj_posjeta = 0; }

        public double Popust
        {
            get { return popust; }
            set {
                if (broj_posjeta == 5)
                {
                    popust = 0.5;
                    broj_posjeta = 0;
                }
                else
                {
                    popust = 0;
                }
            }
        }
    }
}
