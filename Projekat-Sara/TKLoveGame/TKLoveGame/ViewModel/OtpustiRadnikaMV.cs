using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
    class OtpustiRadnikaMV: INotifyPropertyChanged
    {

        TKLoveGame klub = TKLoveGame.Instanca;

        public OtpustiRadnikaMV()
        {
           
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public Boolean Postoji(String id)
        {
            foreach(Zaposlenik p in klub.ListaZaposlenika)
            {
                if (p.Username.Equals(id))
                {
                    return true;
                }
            }

            return false;
        }

        public int DajIndex(String id)
        {
            int brojac = 0;
            foreach (Zaposlenik p in klub.ListaZaposlenika)
            {
                if (p.Username.Equals(id))
                {
                    return brojac;
                }
                brojac++;
            }

            return -1;
        }
    }
}
