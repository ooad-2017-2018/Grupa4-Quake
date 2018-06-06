using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKLoveGame
{
   public  class LogInViewModel: INotifyPropertyChanged
    {

        #region Implementacija interfejsa
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
        TKLoveGame klub = TKLoveGame.Instanca;

        private string eMail;
        private string pass;

        public string EMail { get => eMail;
            set {
                eMail = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(EMail)));
                }
            }
        }

        public string Pass { get => pass;
            set {
                pass = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Pass)));
                }
            }
        }

        public LogInViewModel()
        {
            eMail = "";
            pass = "";
        }

        public Boolean JeLiZaposlenik(string user, string pass)
        {
            foreach(Zaposlenik p in klub.ListaZaposlenika)
            {
                if(p.Username.Equals(user) && p.Password.Equals(pass))
                {
                    return true;
                }
            }

            return false;
        }

        public Boolean JeLiIgrac(string user, string pass)
        {
            foreach (Igrac p in klub.ListaIgraca)
            {
                if (p.Username.Equals(user) && p.Password.Equals(pass))
                {
                    return true;
                }
            }

            return false;
        }

        public Boolean JeLiRekreativac(string user, string pass)
        {
            foreach (Igrac p in klub.ListaIgraca)
            {
                if (p.Username.Equals(user) && p.Password.Equals(pass) && p is Rekreativni)
                {
                    return true;
                }
            }
            return false;
        }





    }
}
