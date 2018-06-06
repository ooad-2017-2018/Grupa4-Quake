using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    public class Teren
    {
        private bool zauzet;
        private int id_terena;

        public Teren(bool zauzet, int id_terena)
        {
            this.zauzet = zauzet;
            this.id_terena = id_terena;
        }

        public bool Zauzet { get => zauzet; set => zauzet = value; }
        public int Id_terena { get => id_terena; set => id_terena = value; }
        /*public void OznaciZauzeto
{

}*/
        //public void OznaciSlobodan { }




    }
}
