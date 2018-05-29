using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace TKLoveGame.ViewModel
{
   public class LoginVM : INotifyPropertyChanged
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

        public TKLoveGame TK = TKLoveGame.getInstance();
        public Igrac korisnik;
        public Zaposlenik musterija;
        public String potvrdaPassworda;
        public ICommand LogIn_Click { get; set; }
        /*  public ICommand RegistrujSe_Click { get; set; }
          public ICommand NemateRacun_Click { get; set; }*/
        private List<Igrac> korisnici;
        private List<Zaposlenik> zaposlenici;
        private String korisnikUsername;
        private String korisnikPassword;
        public INavigationService navigationService { get; set; }

        public List<Igrac> Korisnici { get => korisnici; set => korisnici = value; }
        public List<Zaposlenik> Zaposlenici { get => zaposlenici; set => zaposlenici = value; }


        public string KorisnikUsername
        {
            get => korisnikUsername;
            set
            {
                korisnikUsername = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(KorisnikUsername)));
                }
            }
        }

        public string KorisnikPassword
        {
            get => korisnikPassword;
            set
            {
                korisnikPassword = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(KorisnikPassword)));
                }
            }
        }

        public Boolean validateIgraca()
        {
            foreach(Igrac p in TK.ListaIgraca)
            {
                if(p.Username.Equals("") && p.Password.Equals(" "))
                {
                    return true;
                }
            }

            return false;
        }

        public Boolean validateRadnika()
        {
            foreach( Zaposlenik z in TK.ListaZaposlenika)
            {
                if(z.Username.Equals("") && z.Password.Equals(""))
                {
                    return true;
                }
            }

            return false;
        }

        public LoginVM()
        {
            navigationService = new NavigationService();
            KorisnikUsername = KorisnikPassword = "";
        }




    }
}
