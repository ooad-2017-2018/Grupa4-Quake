using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class Profesionalni : Igrac
    {
        private int rank;
        private int bodovi;
        private String best_result;
        //private List<Takmicenje> MyTakmicenje = new List<Takmicenje>();

        public Profesionalni(String ime, String prezime, String username, String password, String email) : base(ime, prezime, username, password, email) { bodovi = 0; best_result = "/"; rank = 0; }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }

        }


        public int Bodovi
        {
            get { return bodovi; }
            set { bodovi = value; }
        }

        public String BestResult
        {
            get { return best_result; }
            set { best_result = value; }
        }
    }
}
